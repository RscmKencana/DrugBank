
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

namespace BusinessObjects
{

	//===============================================
	// Concrete Entity Class
	//===============================================
	[DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Drugbankenzyme))]
	[XmlType("Drugbankenzyme")]
	public partial class Drugbankenzyme : tgDrugbankenzyme
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankenzyme();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 wID)
		{
			var obj = new Drugbankenzyme();
			obj.WID = wID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 wID, tgSqlAccessType sqlAccessType)
		{
			var obj = new Drugbankenzyme();
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
	abstract public partial class tgDrugbankenzyme : tgEntity
	{
		public tgDrugbankenzyme()
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
			DrugbankenzymeQuery query = new DrugbankenzymeQuery("s4");
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
		/// Maps to Drugbankenzyme.WID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? WID
		{
			get
			{
				return base.GetSystemInt32(DrugbankenzymeMetadata.ColumnNames.WID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankenzymeMetadata.ColumnNames.WID, value))
				{
					OnPropertyChanged(DrugbankenzymeMetadata.PropertyNames.WID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankenzyme.DrugBankWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankWID
		{
			get
			{
				return base.GetSystemInt32(DrugbankenzymeMetadata.ColumnNames.DrugBankWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankenzymeMetadata.ColumnNames.DrugBankWID, value))
				{
					OnPropertyChanged(DrugbankenzymeMetadata.PropertyNames.DrugBankWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankenzyme.Id
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Id
		{
			get
			{
				return base.GetSystemString(DrugbankenzymeMetadata.ColumnNames.Id);
			}

			set
			{
				if (base.SetSystemString(DrugbankenzymeMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(DrugbankenzymeMetadata.PropertyNames.Id);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankenzyme.Name
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Name
		{
			get
			{
				return base.GetSystemString(DrugbankenzymeMetadata.ColumnNames.Name);
			}

			set
			{
				if (base.SetSystemString(DrugbankenzymeMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(DrugbankenzymeMetadata.PropertyNames.Name);
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
				return DrugbankenzymeMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankenzymeQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankenzymeQuery("t4");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankenzymeQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankenzymeQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankenzymeQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankenzymeCollection")]
	public partial class DrugbankenzymeCollection : tgDrugbankenzymeCollection, IEnumerable<Drugbankenzyme>
	{
		public Drugbankenzyme FindByPrimaryKey(int wID)
		{
			return this.SingleOrDefault(e => e.WID == wID);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankenzyme))]
		public class DrugbankenzymeCollectionWCFPacket : tgCollectionWCFPacket<DrugbankenzymeCollection>
		{
			public static implicit operator DrugbankenzymeCollection(DrugbankenzymeCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankenzymeCollectionWCFPacket(DrugbankenzymeCollection collection)
			{
				return new DrugbankenzymeCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankenzymeCollection : tgEntityCollection<Drugbankenzyme>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankenzymeMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankenzymeCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankenzymeQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankenzymeQuery("u4");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankenzymeQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankenzymeQuery("v4");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankenzymeQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankenzymeQuery)query);
		}

		#endregion

		private DrugbankenzymeQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankenzymeQuery : tgDrugbankenzymeQuery
	{
		public DrugbankenzymeQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankenzymeQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankenzymeQuery query)
		{
			return DrugbankenzymeQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankenzymeQuery(string query)
		{
			return (DrugbankenzymeQuery)DrugbankenzymeQuery.SerializeHelper.FromXml(query, typeof(DrugbankenzymeQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankenzymeQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankenzymeMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "WID": return this.WID;
				case "DrugBankWID": return this.DrugBankWID;
				case "Id": return this.Id;
				case "Name": return this.Name;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem WID
		{
			get { return new tgQueryItem(this, DrugbankenzymeMetadata.ColumnNames.WID, tgSystemType.Int32); }
		}

		public tgQueryItem DrugBankWID
		{
			get { return new tgQueryItem(this, DrugbankenzymeMetadata.ColumnNames.DrugBankWID, tgSystemType.Int32); }
		}

		public tgQueryItem Id
		{
			get { return new tgQueryItem(this, DrugbankenzymeMetadata.ColumnNames.Id, tgSystemType.String); }
		}

		public tgQueryItem Name
		{
			get { return new tgQueryItem(this, DrugbankenzymeMetadata.ColumnNames.Name, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankenzymeMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankenzymeMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankenzymeMetadata.ColumnNames.WID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbankenzymeMetadata.PropertyNames.WID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankenzymeMetadata.ColumnNames.DrugBankWID, 1, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbankenzymeMetadata.PropertyNames.DrugBankWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankenzymeMetadata.ColumnNames.Id, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankenzymeMetadata.PropertyNames.Id;
			c.CharacterMaxLength = 25;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankenzymeMetadata.ColumnNames.Name, 3, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankenzymeMetadata.PropertyNames.Name;
			c.IsNullable = true;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankenzymeMetadata Meta()
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
			public const string DrugBankWID = "DrugBank_WID";
			public const string Id = "Id";
			public const string Name = "Name";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string WID = "WID";
			public const string DrugBankWID = "DrugBankWID";
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
			lock (typeof(DrugbankenzymeMetadata))
			{
				if (DrugbankenzymeMetadata.mapDelegates == null)
				{
					DrugbankenzymeMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankenzymeMetadata.meta == null)
				{
					DrugbankenzymeMetadata.meta = new DrugbankenzymeMetadata();
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
				meta.AddTypeMap("DrugBankWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Id", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Name", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankenzyme";
				meta.Destination = "drugbankenzyme";

				meta.spInsert = "proc_DrugbankenzymeInsert";
				meta.spUpdate = "proc_DrugbankenzymeUpdate";
				meta.spDelete = "proc_DrugbankenzymeDelete";
				meta.spLoadAll = "proc_DrugbankenzymeLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankenzymeLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankenzymeMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

