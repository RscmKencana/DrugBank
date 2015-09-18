
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
	[KnownType(typeof(Drugbankdruginteraction))]
	[XmlType("Drugbankdruginteraction")]
	public partial class Drugbankdruginteraction : tgDrugbankdruginteraction
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankdruginteraction();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 drugbankWid, System.Int32 drug)
		{
			var obj = new Drugbankdruginteraction();
			obj.DrugbankWid = drugbankWid;
			obj.Drug = drug;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 drugbankWid, System.Int32 drug, tgSqlAccessType sqlAccessType)
		{
			var obj = new Drugbankdruginteraction();
			obj.DrugbankWid = drugbankWid;
			obj.Drug = drug;
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
	abstract public partial class tgDrugbankdruginteraction : tgEntity
	{
		public tgDrugbankdruginteraction()
		{

		}

		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 drugbankWid, System.Int32 drug)
		{
			if (this.tg.Connection.SqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(drugbankWid, drug);
			else
				return LoadByPrimaryKeyStoredProcedure(drugbankWid, drug);
		}

		public virtual bool LoadByPrimaryKey(tgSqlAccessType sqlAccessType, System.Int32 drugbankWid, System.Int32 drug)
		{
			if (sqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(drugbankWid, drug);
			else
				return LoadByPrimaryKeyStoredProcedure(drugbankWid, drug);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 drugbankWid, System.Int32 drug)
		{
			DrugbankdruginteractionQuery query = new DrugbankdruginteractionQuery("");
			query.Where(query.DrugbankWid == drugbankWid && query.Drug == drug);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 drugbankWid, System.Int32 drug)
		{
			tgParameters parms = new tgParameters();
			parms.Add("DrugbankWid", drugbankWid);
			parms.Add("Drug", drug);
			return this.Load(tgQueryType.StoredProcedure, this.tg.spLoadByPrimaryKey, parms);
		}
		#endregion

		#region Properties

		/// <summary>
		/// Maps to Drugbankdruginteraction.DrugbankWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankdruginteractionMetadata.ColumnNames.DrugbankWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankdruginteractionMetadata.ColumnNames.DrugbankWid, value))
				{
					OnPropertyChanged(DrugbankdruginteractionMetadata.PropertyNames.DrugbankWid);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankdruginteraction.Drug
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? Drug
		{
			get
			{
				return base.GetSystemInt32(DrugbankdruginteractionMetadata.ColumnNames.Drug);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankdruginteractionMetadata.ColumnNames.Drug, value))
				{
					OnPropertyChanged(DrugbankdruginteractionMetadata.PropertyNames.Drug);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankdruginteraction.Description
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Description
		{
			get
			{
				return base.GetSystemString(DrugbankdruginteractionMetadata.ColumnNames.Description);
			}

			set
			{
				if (base.SetSystemString(DrugbankdruginteractionMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(DrugbankdruginteractionMetadata.PropertyNames.Description);
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
				return DrugbankdruginteractionMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankdruginteractionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankdruginteractionQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankdruginteractionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankdruginteractionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankdruginteractionQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankdruginteractionCollection")]
	public partial class DrugbankdruginteractionCollection : tgDrugbankdruginteractionCollection, IEnumerable<Drugbankdruginteraction>
	{
		public Drugbankdruginteraction FindByPrimaryKey(int drugbankWid, int drug)
		{
			return this.SingleOrDefault(e => e.DrugbankWid == drugbankWid && e.Drug == drug);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankdruginteraction))]
		public class DrugbankdruginteractionCollectionWCFPacket : tgCollectionWCFPacket<DrugbankdruginteractionCollection>
		{
			public static implicit operator DrugbankdruginteractionCollection(DrugbankdruginteractionCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankdruginteractionCollectionWCFPacket(DrugbankdruginteractionCollection collection)
			{
				return new DrugbankdruginteractionCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankdruginteractionCollection : tgEntityCollection<Drugbankdruginteraction>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankdruginteractionMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankdruginteractionCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankdruginteractionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankdruginteractionQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankdruginteractionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankdruginteractionQuery("");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankdruginteractionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankdruginteractionQuery)query);
		}

		#endregion

		private DrugbankdruginteractionQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankdruginteractionQuery : tgDrugbankdruginteractionQuery
	{
		public DrugbankdruginteractionQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankdruginteractionQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankdruginteractionQuery query)
		{
			return DrugbankdruginteractionQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankdruginteractionQuery(string query)
		{
			return (DrugbankdruginteractionQuery)DrugbankdruginteractionQuery.SerializeHelper.FromXml(query, typeof(DrugbankdruginteractionQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankdruginteractionQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankdruginteractionMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugbankWid": return this.DrugbankWid;
				case "Drug": return this.Drug;
				case "Description": return this.Description;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugbankWid
		{
			get { return new tgQueryItem(this, DrugbankdruginteractionMetadata.ColumnNames.DrugbankWid, tgSystemType.Int32); }		
		}

		public tgQueryItem Drug
		{
			get { return new tgQueryItem(this, DrugbankdruginteractionMetadata.ColumnNames.Drug, tgSystemType.Int32); }		
		}

		public tgQueryItem Description
		{
			get { return new tgQueryItem(this, DrugbankdruginteractionMetadata.ColumnNames.Description, tgSystemType.String); }		
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankdruginteractionMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankdruginteractionMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankdruginteractionMetadata.ColumnNames.DrugbankWid, 0, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankdruginteractionMetadata.PropertyNames.DrugbankWid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankdruginteractionMetadata.ColumnNames.Drug, 1, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankdruginteractionMetadata.PropertyNames.Drug;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankdruginteractionMetadata.ColumnNames.Description, 2, typeof(System.String), tgSystemType.String);			
			c.PropertyName = DrugbankdruginteractionMetadata.PropertyNames.Description;
			c.IsNullable = true;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankdruginteractionMetadata Meta()
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
			public const string Drug = "Drug";
			public const string Description = "Description";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugbankWid = "DrugbankWid";
			public const string Drug = "Drug";
			public const string Description = "Description";
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
			lock (typeof(DrugbankdruginteractionMetadata))
			{
				if (DrugbankdruginteractionMetadata.mapDelegates == null)
				{
					DrugbankdruginteractionMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankdruginteractionMetadata.meta == null)
				{
					DrugbankdruginteractionMetadata.meta = new DrugbankdruginteractionMetadata();
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
				meta.AddTypeMap("Drug", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Description", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankdruginteraction";
				meta.Destination = "drugbankdruginteraction";

				meta.spInsert = "proc_DrugbankdruginteractionInsert";
				meta.spUpdate = "proc_DrugbankdruginteractionUpdate";
				meta.spDelete = "proc_DrugbankdruginteractionDelete";
				meta.spLoadAll = "proc_DrugbankdruginteractionLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankdruginteractionLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankdruginteractionMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}
