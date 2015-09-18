
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
	[KnownType(typeof(DrugbankHasDrugbankpatent))]
	[XmlType("DrugbankHasDrugbankpatent")]
	public partial class DrugbankHasDrugbankpatent : tgDrugbankHasDrugbankpatent
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new DrugbankHasDrugbankpatent();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 drugbankWid, System.Int32 drugbankpatentWid)
		{
			var obj = new DrugbankHasDrugbankpatent();
			obj.DrugbankWid = drugbankWid;
			obj.DrugbankpatentWid = drugbankpatentWid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 drugbankWid, System.Int32 drugbankpatentWid, tgSqlAccessType sqlAccessType)
		{
			var obj = new DrugbankHasDrugbankpatent();
			obj.DrugbankWid = drugbankWid;
			obj.DrugbankpatentWid = drugbankpatentWid;
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
	abstract public partial class tgDrugbankHasDrugbankpatent : tgEntity
	{
		public tgDrugbankHasDrugbankpatent()
		{

		}

		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 drugbankWid, System.Int32 drugbankpatentWid)
		{
			if (this.tg.Connection.SqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(drugbankWid, drugbankpatentWid);
			else
				return LoadByPrimaryKeyStoredProcedure(drugbankWid, drugbankpatentWid);
		}

		public virtual bool LoadByPrimaryKey(tgSqlAccessType sqlAccessType, System.Int32 drugbankWid, System.Int32 drugbankpatentWid)
		{
			if (sqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(drugbankWid, drugbankpatentWid);
			else
				return LoadByPrimaryKeyStoredProcedure(drugbankWid, drugbankpatentWid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 drugbankWid, System.Int32 drugbankpatentWid)
		{
			DrugbankHasDrugbankpatentQuery query = new DrugbankHasDrugbankpatentQuery("");
			query.Where(query.DrugbankWid == drugbankWid && query.DrugbankpatentWid == drugbankpatentWid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 drugbankWid, System.Int32 drugbankpatentWid)
		{
			tgParameters parms = new tgParameters();
			parms.Add("DrugbankWid", drugbankWid);
			parms.Add("DrugbankpatentWid", drugbankpatentWid);
			return this.Load(tgQueryType.StoredProcedure, this.tg.spLoadByPrimaryKey, parms);
		}
		#endregion

		#region Properties

		/// <summary>
		/// Maps to DrugbankHasDrugbankpatent.DrugbankWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankHasDrugbankpatentMetadata.ColumnNames.DrugbankWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankHasDrugbankpatentMetadata.ColumnNames.DrugbankWid, value))
				{
					OnPropertyChanged(DrugbankHasDrugbankpatentMetadata.PropertyNames.DrugbankWid);
				}
			}
		}

		/// <summary>
		/// Maps to DrugbankHasDrugbankpatent.DrugbankpatentWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankpatentWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankHasDrugbankpatentMetadata.ColumnNames.DrugbankpatentWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankHasDrugbankpatentMetadata.ColumnNames.DrugbankpatentWid, value))
				{
					OnPropertyChanged(DrugbankHasDrugbankpatentMetadata.PropertyNames.DrugbankpatentWid);
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
				return DrugbankHasDrugbankpatentMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankHasDrugbankpatentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankHasDrugbankpatentQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankHasDrugbankpatentQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankHasDrugbankpatentQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankHasDrugbankpatentQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankHasDrugbankpatentCollection")]
	public partial class DrugbankHasDrugbankpatentCollection : tgDrugbankHasDrugbankpatentCollection, IEnumerable<DrugbankHasDrugbankpatent>
	{
		public DrugbankHasDrugbankpatent FindByPrimaryKey(int drugbankWid, int drugbankpatentWid)
		{
			return this.SingleOrDefault(e => e.DrugbankWid == drugbankWid && e.DrugbankpatentWid == drugbankpatentWid);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(DrugbankHasDrugbankpatent))]
		public class DrugbankHasDrugbankpatentCollectionWCFPacket : tgCollectionWCFPacket<DrugbankHasDrugbankpatentCollection>
		{
			public static implicit operator DrugbankHasDrugbankpatentCollection(DrugbankHasDrugbankpatentCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankHasDrugbankpatentCollectionWCFPacket(DrugbankHasDrugbankpatentCollection collection)
			{
				return new DrugbankHasDrugbankpatentCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankHasDrugbankpatentCollection : tgEntityCollection<DrugbankHasDrugbankpatent>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankHasDrugbankpatentMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankHasDrugbankpatentCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankHasDrugbankpatentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankHasDrugbankpatentQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankHasDrugbankpatentQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankHasDrugbankpatentQuery("");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankHasDrugbankpatentQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankHasDrugbankpatentQuery)query);
		}

		#endregion

		private DrugbankHasDrugbankpatentQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankHasDrugbankpatentQuery : tgDrugbankHasDrugbankpatentQuery
	{
		public DrugbankHasDrugbankpatentQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankHasDrugbankpatentQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankHasDrugbankpatentQuery query)
		{
			return DrugbankHasDrugbankpatentQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankHasDrugbankpatentQuery(string query)
		{
			return (DrugbankHasDrugbankpatentQuery)DrugbankHasDrugbankpatentQuery.SerializeHelper.FromXml(query, typeof(DrugbankHasDrugbankpatentQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankHasDrugbankpatentQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankHasDrugbankpatentMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugbankWid": return this.DrugbankWid;
				case "DrugbankpatentWid": return this.DrugbankpatentWid;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugbankWid
		{
			get { return new tgQueryItem(this, DrugbankHasDrugbankpatentMetadata.ColumnNames.DrugbankWid, tgSystemType.Int32); }		
		}

		public tgQueryItem DrugbankpatentWid
		{
			get { return new tgQueryItem(this, DrugbankHasDrugbankpatentMetadata.ColumnNames.DrugbankpatentWid, tgSystemType.Int32); }		
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankHasDrugbankpatentMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankHasDrugbankpatentMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankHasDrugbankpatentMetadata.ColumnNames.DrugbankWid, 0, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankHasDrugbankpatentMetadata.PropertyNames.DrugbankWid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankHasDrugbankpatentMetadata.ColumnNames.DrugbankpatentWid, 1, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankHasDrugbankpatentMetadata.PropertyNames.DrugbankpatentWid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankHasDrugbankpatentMetadata Meta()
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
			public const string DrugbankpatentWid = "DrugBankPatent_WID";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugbankWid = "DrugbankWid";
			public const string DrugbankpatentWid = "DrugbankpatentWid";
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
			lock (typeof(DrugbankHasDrugbankpatentMetadata))
			{
				if (DrugbankHasDrugbankpatentMetadata.mapDelegates == null)
				{
					DrugbankHasDrugbankpatentMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankHasDrugbankpatentMetadata.meta == null)
				{
					DrugbankHasDrugbankpatentMetadata.meta = new DrugbankHasDrugbankpatentMetadata();
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
				meta.AddTypeMap("DrugbankpatentWid", new tgTypeMap("integer", "System.Int32"));

				meta.Source = "drugbank_has_drugbankpatent";
				meta.Destination = "drugbank_has_drugbankpatent";

				meta.spInsert = "proc_DrugbankHasDrugbankpatentInsert";
				meta.spUpdate = "proc_DrugbankHasDrugbankpatentUpdate";
				meta.spDelete = "proc_DrugbankHasDrugbankpatentDelete";
				meta.spLoadAll = "proc_DrugbankHasDrugbankpatentLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankHasDrugbankpatentLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankHasDrugbankpatentMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

