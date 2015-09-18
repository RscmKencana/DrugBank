
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
	[KnownType(typeof(Drugbanktarget))]
	[XmlType("Drugbanktarget")]
	public partial class Drugbanktarget : tgDrugbanktarget
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbanktarget();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 wID)
		{
			var obj = new Drugbanktarget();
			obj.WID = wID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 wID, tgSqlAccessType sqlAccessType)
		{
			var obj = new Drugbanktarget();
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
	abstract public partial class tgDrugbanktarget : tgEntity
	{
		public tgDrugbanktarget()
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
			DrugbanktargetQuery query = new DrugbanktargetQuery("a9");
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
		/// Maps to Drugbanktarget.WID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? WID
		{
			get
			{
				return base.GetSystemInt32(DrugbanktargetMetadata.ColumnNames.WID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbanktargetMetadata.ColumnNames.WID, value))
				{
					OnPropertyChanged(DrugbanktargetMetadata.PropertyNames.WID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktarget.DrugBankWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankWID
		{
			get
			{
				return base.GetSystemInt32(DrugbanktargetMetadata.ColumnNames.DrugBankWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbanktargetMetadata.ColumnNames.DrugBankWID, value))
				{
					OnPropertyChanged(DrugbanktargetMetadata.PropertyNames.DrugBankWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktarget.Id
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Id
		{
			get
			{
				return base.GetSystemString(DrugbanktargetMetadata.ColumnNames.Id);
			}

			set
			{
				if (base.SetSystemString(DrugbanktargetMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(DrugbanktargetMetadata.PropertyNames.Id);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktarget.Name
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Name
		{
			get
			{
				return base.GetSystemString(DrugbanktargetMetadata.ColumnNames.Name);
			}

			set
			{
				if (base.SetSystemString(DrugbanktargetMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(DrugbanktargetMetadata.PropertyNames.Name);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktarget.KnownAction
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string KnownAction
		{
			get
			{
				return base.GetSystemString(DrugbanktargetMetadata.ColumnNames.KnownAction);
			}

			set
			{
				if (base.SetSystemString(DrugbanktargetMetadata.ColumnNames.KnownAction, value))
				{
					OnPropertyChanged(DrugbanktargetMetadata.PropertyNames.KnownAction);
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
				return DrugbanktargetMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbanktargetQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktargetQuery("a9");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktargetQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbanktargetQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbanktargetQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbanktargetCollection")]
	public partial class DrugbanktargetCollection : tgDrugbanktargetCollection, IEnumerable<Drugbanktarget>
	{
		public Drugbanktarget FindByPrimaryKey(int wID)
		{
			return this.SingleOrDefault(e => e.WID == wID);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbanktarget))]
		public class DrugbanktargetCollectionWCFPacket : tgCollectionWCFPacket<DrugbanktargetCollection>
		{
			public static implicit operator DrugbanktargetCollection(DrugbanktargetCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbanktargetCollectionWCFPacket(DrugbanktargetCollection collection)
			{
				return new DrugbanktargetCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbanktargetCollection : tgEntityCollection<Drugbanktarget>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktargetMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbanktargetCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbanktargetQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktargetQuery("a9");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktargetQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbanktargetQuery("a9");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbanktargetQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbanktargetQuery)query);
		}

		#endregion

		private DrugbanktargetQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbanktargetQuery : tgDrugbanktargetQuery
	{
		public DrugbanktargetQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbanktargetQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbanktargetQuery query)
		{
			return DrugbanktargetQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbanktargetQuery(string query)
		{
			return (DrugbanktargetQuery)DrugbanktargetQuery.SerializeHelper.FromXml(query, typeof(DrugbanktargetQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbanktargetQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktargetMetadata.Meta();
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
				case "KnownAction": return this.KnownAction;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem WID
		{
			get { return new tgQueryItem(this, DrugbanktargetMetadata.ColumnNames.WID, tgSystemType.Int32); }
		}

		public tgQueryItem DrugBankWID
		{
			get { return new tgQueryItem(this, DrugbanktargetMetadata.ColumnNames.DrugBankWID, tgSystemType.Int32); }
		}

		public tgQueryItem Id
		{
			get { return new tgQueryItem(this, DrugbanktargetMetadata.ColumnNames.Id, tgSystemType.String); }
		}

		public tgQueryItem Name
		{
			get { return new tgQueryItem(this, DrugbanktargetMetadata.ColumnNames.Name, tgSystemType.String); }
		}

		public tgQueryItem KnownAction
		{
			get { return new tgQueryItem(this, DrugbanktargetMetadata.ColumnNames.KnownAction, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbanktargetMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbanktargetMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbanktargetMetadata.ColumnNames.WID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbanktargetMetadata.PropertyNames.WID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktargetMetadata.ColumnNames.DrugBankWID, 1, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbanktargetMetadata.PropertyNames.DrugBankWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktargetMetadata.ColumnNames.Id, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbanktargetMetadata.PropertyNames.Id;
			c.CharacterMaxLength = 25;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktargetMetadata.ColumnNames.Name, 3, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbanktargetMetadata.PropertyNames.Name;
			c.IsNullable = true;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktargetMetadata.ColumnNames.KnownAction, 4, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbanktargetMetadata.PropertyNames.KnownAction;
			c.IsNullable = true;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbanktargetMetadata Meta()
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
			public const string KnownAction = "KnownAction";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string WID = "WID";
			public const string DrugBankWID = "DrugBankWID";
			public const string Id = "Id";
			public const string Name = "Name";
			public const string KnownAction = "KnownAction";
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
			lock (typeof(DrugbanktargetMetadata))
			{
				if (DrugbanktargetMetadata.mapDelegates == null)
				{
					DrugbanktargetMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbanktargetMetadata.meta == null)
				{
					DrugbanktargetMetadata.meta = new DrugbanktargetMetadata();
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
				meta.AddTypeMap("KnownAction", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbanktarget";
				meta.Destination = "drugbanktarget";

				meta.spInsert = "proc_DrugbanktargetInsert";
				meta.spUpdate = "proc_DrugbanktargetUpdate";
				meta.spDelete = "proc_DrugbanktargetDelete";
				meta.spLoadAll = "proc_DrugbanktargetLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbanktargetLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbanktargetMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}
