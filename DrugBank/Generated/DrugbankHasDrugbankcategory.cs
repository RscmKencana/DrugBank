
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
	[KnownType(typeof(DrugbankHasDrugbankcategory))]
	[XmlType("DrugbankHasDrugbankcategory")]
	public partial class DrugbankHasDrugbankcategory : tgDrugbankHasDrugbankcategory
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new DrugbankHasDrugbankcategory();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 drugbankWid, System.Int32 drugbankcategoryWid)
		{
			var obj = new DrugbankHasDrugbankcategory();
			obj.DrugbankWid = drugbankWid;
			obj.DrugbankcategoryWid = drugbankcategoryWid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 drugbankWid, System.Int32 drugbankcategoryWid, tgSqlAccessType sqlAccessType)
		{
			var obj = new DrugbankHasDrugbankcategory();
			obj.DrugbankWid = drugbankWid;
			obj.DrugbankcategoryWid = drugbankcategoryWid;
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
	abstract public partial class tgDrugbankHasDrugbankcategory : tgEntity
	{
		public tgDrugbankHasDrugbankcategory()
		{

		}

		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 drugbankWid, System.Int32 drugbankcategoryWid)
		{
			if (this.tg.Connection.SqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(drugbankWid, drugbankcategoryWid);
			else
				return LoadByPrimaryKeyStoredProcedure(drugbankWid, drugbankcategoryWid);
		}

		public virtual bool LoadByPrimaryKey(tgSqlAccessType sqlAccessType, System.Int32 drugbankWid, System.Int32 drugbankcategoryWid)
		{
			if (sqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(drugbankWid, drugbankcategoryWid);
			else
				return LoadByPrimaryKeyStoredProcedure(drugbankWid, drugbankcategoryWid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 drugbankWid, System.Int32 drugbankcategoryWid)
		{
			DrugbankHasDrugbankcategoryQuery query = new DrugbankHasDrugbankcategoryQuery("");
			query.Where(query.DrugbankWid == drugbankWid && query.DrugbankcategoryWid == drugbankcategoryWid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 drugbankWid, System.Int32 drugbankcategoryWid)
		{
			tgParameters parms = new tgParameters();
			parms.Add("DrugbankWid", drugbankWid);
			parms.Add("DrugbankcategoryWid", drugbankcategoryWid);
			return this.Load(tgQueryType.StoredProcedure, this.tg.spLoadByPrimaryKey, parms);
		}
		#endregion

		#region Properties

		/// <summary>
		/// Maps to DrugbankHasDrugbankcategory.DrugbankWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankHasDrugbankcategoryMetadata.ColumnNames.DrugbankWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankHasDrugbankcategoryMetadata.ColumnNames.DrugbankWid, value))
				{
					OnPropertyChanged(DrugbankHasDrugbankcategoryMetadata.PropertyNames.DrugbankWid);
				}
			}
		}

		/// <summary>
		/// Maps to DrugbankHasDrugbankcategory.DrugbankcategoryWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankcategoryWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankHasDrugbankcategoryMetadata.ColumnNames.DrugbankcategoryWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankHasDrugbankcategoryMetadata.ColumnNames.DrugbankcategoryWid, value))
				{
					OnPropertyChanged(DrugbankHasDrugbankcategoryMetadata.PropertyNames.DrugbankcategoryWid);
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
				return DrugbankHasDrugbankcategoryMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankHasDrugbankcategoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankHasDrugbankcategoryQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankHasDrugbankcategoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankHasDrugbankcategoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankHasDrugbankcategoryQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankHasDrugbankcategoryCollection")]
	public partial class DrugbankHasDrugbankcategoryCollection : tgDrugbankHasDrugbankcategoryCollection, IEnumerable<DrugbankHasDrugbankcategory>
	{
		public DrugbankHasDrugbankcategory FindByPrimaryKey(int drugbankWid, int drugbankcategoryWid)
		{
			return this.SingleOrDefault(e => e.DrugbankWid == drugbankWid && e.DrugbankcategoryWid == drugbankcategoryWid);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(DrugbankHasDrugbankcategory))]
		public class DrugbankHasDrugbankcategoryCollectionWCFPacket : tgCollectionWCFPacket<DrugbankHasDrugbankcategoryCollection>
		{
			public static implicit operator DrugbankHasDrugbankcategoryCollection(DrugbankHasDrugbankcategoryCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankHasDrugbankcategoryCollectionWCFPacket(DrugbankHasDrugbankcategoryCollection collection)
			{
				return new DrugbankHasDrugbankcategoryCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankHasDrugbankcategoryCollection : tgEntityCollection<DrugbankHasDrugbankcategory>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankHasDrugbankcategoryMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankHasDrugbankcategoryCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankHasDrugbankcategoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankHasDrugbankcategoryQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankHasDrugbankcategoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankHasDrugbankcategoryQuery("");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankHasDrugbankcategoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankHasDrugbankcategoryQuery)query);
		}

		#endregion

		private DrugbankHasDrugbankcategoryQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankHasDrugbankcategoryQuery : tgDrugbankHasDrugbankcategoryQuery
	{
		public DrugbankHasDrugbankcategoryQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankHasDrugbankcategoryQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankHasDrugbankcategoryQuery query)
		{
			return DrugbankHasDrugbankcategoryQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankHasDrugbankcategoryQuery(string query)
		{
			return (DrugbankHasDrugbankcategoryQuery)DrugbankHasDrugbankcategoryQuery.SerializeHelper.FromXml(query, typeof(DrugbankHasDrugbankcategoryQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankHasDrugbankcategoryQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankHasDrugbankcategoryMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugbankWid": return this.DrugbankWid;
				case "DrugbankcategoryWid": return this.DrugbankcategoryWid;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugbankWid
		{
			get { return new tgQueryItem(this, DrugbankHasDrugbankcategoryMetadata.ColumnNames.DrugbankWid, tgSystemType.Int32); }		
		}

		public tgQueryItem DrugbankcategoryWid
		{
			get { return new tgQueryItem(this, DrugbankHasDrugbankcategoryMetadata.ColumnNames.DrugbankcategoryWid, tgSystemType.Int32); }		
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankHasDrugbankcategoryMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankHasDrugbankcategoryMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankHasDrugbankcategoryMetadata.ColumnNames.DrugbankWid, 0, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankHasDrugbankcategoryMetadata.PropertyNames.DrugbankWid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankHasDrugbankcategoryMetadata.ColumnNames.DrugbankcategoryWid, 1, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankHasDrugbankcategoryMetadata.PropertyNames.DrugbankcategoryWid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankHasDrugbankcategoryMetadata Meta()
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
			public const string DrugbankWid = "DrugBank_WID";
			public const string DrugbankcategoryWid = "DrugBankCategory_WID";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugbankWid = "DrugbankWid";
			public const string DrugbankcategoryWid = "DrugbankcategoryWid";
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
			lock (typeof(DrugbankHasDrugbankcategoryMetadata))
			{
				if (DrugbankHasDrugbankcategoryMetadata.mapDelegates == null)
				{
					DrugbankHasDrugbankcategoryMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankHasDrugbankcategoryMetadata.meta == null)
				{
					DrugbankHasDrugbankcategoryMetadata.meta = new DrugbankHasDrugbankcategoryMetadata();
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


				meta.AddTypeMap("DrugbankWid", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("DrugbankcategoryWid", new tgTypeMap("integer", "System.Int32"));

				meta.Source = "drugbank_has_drugbankcategory";
				meta.Destination = "drugbank_has_drugbankcategory";

				meta.spInsert = "proc_DrugbankHasDrugbankcategoryInsert";
				meta.spUpdate = "proc_DrugbankHasDrugbankcategoryUpdate";
				meta.spDelete = "proc_DrugbankHasDrugbankcategoryDelete";
				meta.spLoadAll = "proc_DrugbankHasDrugbankcategoryLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankHasDrugbankcategoryLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankHasDrugbankcategoryMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

