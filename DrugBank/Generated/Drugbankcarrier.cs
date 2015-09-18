
//==============================================
// Generated by http://www.My2ndGeneration.com
//==============================================

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using Tiraggo.Core;
using Tiraggo.Interfaces;
using Tiraggo.DynamicQuery;

namespace DrugBank
{

	//===============================================
	// Concrete Entity Class
	//===============================================
	[DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Drugbankcarrier))]
	[XmlType("Drugbankcarrier")]
	public partial class Drugbankcarrier : tgDrugbankcarrier
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankcarrier();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 wID)
		{
			var obj = new Drugbankcarrier();
			obj.WID = wID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 wID, tgSqlAccessType sqlAccessType)
		{
			var obj = new Drugbankcarrier();
			obj.WID = wID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion
	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbankcarrier : tgEntity
	{
		public tgDrugbankcarrier()
		{

		}

		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 wID)
		{
			if (this.tg.Connection.SqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(wID);
			else
				return LoadByPrimaryKeyStoredProcedure(wID);
		}

		public virtual bool LoadByPrimaryKey(tgSqlAccessType sqlAccessType, System.Int32 wID)
		{
			if (sqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(wID);
			else
				return LoadByPrimaryKeyStoredProcedure(wID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 wID)
		{
			DrugbankcarrierQuery query = new DrugbankcarrierQuery("");
			query.Where(query.WID == wID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 wID)
		{
			tgParameters parms = new tgParameters();
			parms.Add("WID", wID);
			return this.Load(tgQueryType.StoredProcedure, this.tg.spLoadByPrimaryKey, parms);
		}
		#endregion

		#region Properties

		/// <summary>
		/// Maps to Drugbankcarrier.WID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? WID
		{
			get
			{
				return base.GetSystemInt32(DrugbankcarrierMetadata.ColumnNames.WID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankcarrierMetadata.ColumnNames.WID, value))
				{
					OnPropertyChanged(DrugbankcarrierMetadata.PropertyNames.WID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankcarrier.DrugbankWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankcarrierMetadata.ColumnNames.DrugbankWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankcarrierMetadata.ColumnNames.DrugbankWid, value))
				{
					OnPropertyChanged(DrugbankcarrierMetadata.PropertyNames.DrugbankWid);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankcarrier.Id
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Id
		{
			get
			{
				return base.GetSystemString(DrugbankcarrierMetadata.ColumnNames.Id);
			}

			set
			{
				if (base.SetSystemString(DrugbankcarrierMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(DrugbankcarrierMetadata.PropertyNames.Id);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankcarrier.Name
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Name
		{
			get
			{
				return base.GetSystemString(DrugbankcarrierMetadata.ColumnNames.Name);
			}

			set
			{
				if (base.SetSystemString(DrugbankcarrierMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(DrugbankcarrierMetadata.PropertyNames.Name);
				}
			}
		}


		// For Tiraggo.js support and basic serialization of extra properties
		// brought back via Joins
		[DataMember(EmitDefaultValue = false)]
        public tgKeyValuePair[] tgExtendedData
        {
            get
            {
                Dictionary<string, object> extra = GetExtraColumns();

                if (extra.Keys.Count > 0)
                {
                    List<tgKeyValuePair> extended = new List<tgKeyValuePair>();

                    foreach (string key in extra.Keys)
                    {
                        extended.Add(new tgKeyValuePair { Key = key, Value = extra[key] });
                    }

                    return extended.ToArray();
                }

                return null;
            }

            set
            {
                foreach (tgKeyValuePair pair in value)
                {
                    this.SetColumn(pair.Key, pair.Value);
                }
            }
        }

		#endregion

		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return DrugbankcarrierMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankcarrierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankcarrierQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankcarrierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankcarrierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankcarrierQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankcarrierCollection")]
	public partial class DrugbankcarrierCollection : tgDrugbankcarrierCollection, IEnumerable<Drugbankcarrier>
	{
		public Drugbankcarrier FindByPrimaryKey(int wID)
		{
			return this.SingleOrDefault(e => e.WID == wID);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankcarrier))]
		public class DrugbankcarrierCollectionWCFPacket : tgCollectionWCFPacket<DrugbankcarrierCollection>
		{
			public static implicit operator DrugbankcarrierCollection(DrugbankcarrierCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankcarrierCollectionWCFPacket(DrugbankcarrierCollection collection)
			{
				return new DrugbankcarrierCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankcarrierCollection : tgEntityCollection<Drugbankcarrier>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankcarrierMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankcarrierCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankcarrierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankcarrierQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankcarrierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankcarrierQuery("");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankcarrierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankcarrierQuery)query);
		}

		#endregion

		private DrugbankcarrierQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankcarrierQuery : tgDrugbankcarrierQuery
	{
		public DrugbankcarrierQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankcarrierQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankcarrierQuery query)
		{
			return DrugbankcarrierQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankcarrierQuery(string query)
		{
			return (DrugbankcarrierQuery)DrugbankcarrierQuery.SerializeHelper.FromXml(query, typeof(DrugbankcarrierQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankcarrierQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankcarrierMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "WID": return this.WID;
				case "DrugbankWid": return this.DrugbankWid;
				case "Id": return this.Id;
				case "Name": return this.Name;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem WID
		{
			get { return new tgQueryItem(this, DrugbankcarrierMetadata.ColumnNames.WID, tgSystemType.Int32); }		
		}

		public tgQueryItem DrugbankWid
		{
			get { return new tgQueryItem(this, DrugbankcarrierMetadata.ColumnNames.DrugbankWid, tgSystemType.Int32); }		
		}

		public tgQueryItem Id
		{
			get { return new tgQueryItem(this, DrugbankcarrierMetadata.ColumnNames.Id, tgSystemType.String); }		
		}

		public tgQueryItem Name
		{
			get { return new tgQueryItem(this, DrugbankcarrierMetadata.ColumnNames.Name, tgSystemType.String); }		
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankcarrierMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankcarrierMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankcarrierMetadata.ColumnNames.WID, 0, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankcarrierMetadata.PropertyNames.WID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankcarrierMetadata.ColumnNames.DrugbankWid, 1, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankcarrierMetadata.PropertyNames.DrugbankWid;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankcarrierMetadata.ColumnNames.Id, 2, typeof(System.String), tgSystemType.String);			
			c.PropertyName = DrugbankcarrierMetadata.PropertyNames.Id;
			c.IsNullable = true;
			c.CharacterMaxLength = 25;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankcarrierMetadata.ColumnNames.Name, 3, typeof(System.String), tgSystemType.String);			
			c.PropertyName = DrugbankcarrierMetadata.PropertyNames.Name;
			c.IsNullable = true;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankcarrierMetadata Meta()
		{
			return meta;
		}

		public Guid DataID
		{
			get { return base.m_dataID; }
		}

		public bool MultiProviderMode
		{
			get { return false; }
		}

		public tgColumnMetadataCollection Columns
		{
			get { return base.m_columns; }
		}

		#region ColumnNames
		public class ColumnNames
		{
			public const string WID = "WID";
			public const string DrugbankWid = "DrugBank_WID";
			public const string Id = "Id";
			public const string Name = "Name";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string WID = "WID";
			public const string DrugbankWid = "DrugbankWid";
			public const string Id = "Id";
			public const string Name = "Name";
		}
		#endregion

		public tgProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];
			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}

		#region MAP esDefault

		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(DrugbankcarrierMetadata))
			{
				if (DrugbankcarrierMetadata.mapDelegates == null)
				{
					DrugbankcarrierMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankcarrierMetadata.meta == null)
				{
					DrugbankcarrierMetadata.meta = new DrugbankcarrierMetadata();
				}

				MapToMeta mapMethod = new MapToMeta(meta.tgDefault);
				mapDelegates.Add("tgDefault", mapMethod);
				mapMethod("tgDefault");
			}
			return 0;
		}

		private tgProviderSpecificMetadata tgDefault(string mapName)
		{
			if (!m_providerMetadataMaps.ContainsKey(mapName))
			{
				tgProviderSpecificMetadata meta = new tgProviderSpecificMetadata();


				meta.AddTypeMap("WID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("DrugbankWid", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Id", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Name", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankcarrier";
				meta.Destination = "drugbankcarrier";

				meta.spInsert = "proc_DrugbankcarrierInsert";
				meta.spUpdate = "proc_DrugbankcarrierUpdate";
				meta.spDelete = "proc_DrugbankcarrierDelete";
				meta.spLoadAll = "proc_DrugbankcarrierLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankcarrierLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankcarrierMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}
