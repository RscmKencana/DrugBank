
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
	[KnownType(typeof(Taxonomy))]
	[XmlType("Taxonomy")]
	public partial class Taxonomy : tgTaxonomy
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Taxonomy();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 wID)
		{
			var obj = new Taxonomy();
			obj.WID = wID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 wID, tgSqlAccessType sqlAccessType)
		{
			var obj = new Taxonomy();
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
	abstract public partial class tgTaxonomy : tgEntity
	{
		public tgTaxonomy()
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
			TaxonomyQuery query = new TaxonomyQuery("aa2");
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
		/// Maps to Taxonomy.WID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? WID
		{
			get
			{
				return base.GetSystemInt32(TaxonomyMetadata.ColumnNames.WID);
			}

			set
			{
				if (base.SetSystemInt32(TaxonomyMetadata.ColumnNames.WID, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.WID);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.TaxId
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? TaxId
		{
			get
			{
				return base.GetSystemInt32(TaxonomyMetadata.ColumnNames.TaxId);
			}

			set
			{
				if (base.SetSystemInt32(TaxonomyMetadata.ColumnNames.TaxId, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.TaxId);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.ParentTaxId
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? ParentTaxId
		{
			get
			{
				return base.GetSystemInt32(TaxonomyMetadata.ColumnNames.ParentTaxId);
			}

			set
			{
				if (base.SetSystemInt32(TaxonomyMetadata.ColumnNames.ParentTaxId, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.ParentTaxId);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.Rank
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Rank
		{
			get
			{
				return base.GetSystemString(TaxonomyMetadata.ColumnNames.Rank);
			}

			set
			{
				if (base.SetSystemString(TaxonomyMetadata.ColumnNames.Rank, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.Rank);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.EMBLCode
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string EMBLCode
		{
			get
			{
				return base.GetSystemString(TaxonomyMetadata.ColumnNames.EMBLCode);
			}

			set
			{
				if (base.SetSystemString(TaxonomyMetadata.ColumnNames.EMBLCode, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.EMBLCode);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.TaxonomyDivisionWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? TaxonomyDivisionWID
		{
			get
			{
				return base.GetSystemInt32(TaxonomyMetadata.ColumnNames.TaxonomyDivisionWID);
			}

			set
			{
				if (base.SetSystemInt32(TaxonomyMetadata.ColumnNames.TaxonomyDivisionWID, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.TaxonomyDivisionWID);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.InheritedDivision
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string InheritedDivision
		{
			get
			{
				return base.GetSystemString(TaxonomyMetadata.ColumnNames.InheritedDivision);
			}

			set
			{
				if (base.SetSystemString(TaxonomyMetadata.ColumnNames.InheritedDivision, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.InheritedDivision);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.TaxonomyGenCodeWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? TaxonomyGenCodeWID
		{
			get
			{
				return base.GetSystemInt32(TaxonomyMetadata.ColumnNames.TaxonomyGenCodeWID);
			}

			set
			{
				if (base.SetSystemInt32(TaxonomyMetadata.ColumnNames.TaxonomyGenCodeWID, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.TaxonomyGenCodeWID);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.InheritedGencode
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string InheritedGencode
		{
			get
			{
				return base.GetSystemString(TaxonomyMetadata.ColumnNames.InheritedGencode);
			}

			set
			{
				if (base.SetSystemString(TaxonomyMetadata.ColumnNames.InheritedGencode, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.InheritedGencode);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.TaxonomyMCGenCodeWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? TaxonomyMCGenCodeWID
		{
			get
			{
				return base.GetSystemInt32(TaxonomyMetadata.ColumnNames.TaxonomyMCGenCodeWID);
			}

			set
			{
				if (base.SetSystemInt32(TaxonomyMetadata.ColumnNames.TaxonomyMCGenCodeWID, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.TaxonomyMCGenCodeWID);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.InheritedMCGencode
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string InheritedMCGencode
		{
			get
			{
				return base.GetSystemString(TaxonomyMetadata.ColumnNames.InheritedMCGencode);
			}

			set
			{
				if (base.SetSystemString(TaxonomyMetadata.ColumnNames.InheritedMCGencode, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.InheritedMCGencode);
				}
			}
		}

		/// <summary>
		/// Maps to Taxonomy.DataSetWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DataSetWID
		{
			get
			{
				return base.GetSystemInt32(TaxonomyMetadata.ColumnNames.DataSetWID);
			}

			set
			{
				if (base.SetSystemInt32(TaxonomyMetadata.ColumnNames.DataSetWID, value))
				{
					OnPropertyChanged(TaxonomyMetadata.PropertyNames.DataSetWID);
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
				return TaxonomyMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public TaxonomyQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TaxonomyQuery("ab2");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TaxonomyQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(TaxonomyQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private TaxonomyQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("TaxonomyCollection")]
	public partial class TaxonomyCollection : tgTaxonomyCollection, IEnumerable<Taxonomy>
	{
		public Taxonomy FindByPrimaryKey(int wID)
		{
			return this.SingleOrDefault(e => e.WID == wID);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Taxonomy))]
		public class TaxonomyCollectionWCFPacket : tgCollectionWCFPacket<TaxonomyCollection>
		{
			public static implicit operator TaxonomyCollection(TaxonomyCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator TaxonomyCollectionWCFPacket(TaxonomyCollection collection)
			{
				return new TaxonomyCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgTaxonomyCollection : tgEntityCollection<Taxonomy>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return TaxonomyMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "TaxonomyCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public TaxonomyQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TaxonomyQuery("ac2");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TaxonomyQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new TaxonomyQuery("ad2");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(TaxonomyQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((TaxonomyQuery)query);
		}

		#endregion

		private TaxonomyQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class TaxonomyQuery : tgTaxonomyQuery
	{
		public TaxonomyQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "TaxonomyQuery";
		}

		#region Explicit Casts

		public static explicit operator string(TaxonomyQuery query)
		{
			return TaxonomyQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator TaxonomyQuery(string query)
		{
			return (TaxonomyQuery)TaxonomyQuery.SerializeHelper.FromXml(query, typeof(TaxonomyQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgTaxonomyQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return TaxonomyMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "WID": return this.WID;
				case "TaxId": return this.TaxId;
				case "ParentTaxId": return this.ParentTaxId;
				case "Rank": return this.Rank;
				case "EMBLCode": return this.EMBLCode;
				case "TaxonomyDivisionWID": return this.TaxonomyDivisionWID;
				case "InheritedDivision": return this.InheritedDivision;
				case "TaxonomyGenCodeWID": return this.TaxonomyGenCodeWID;
				case "InheritedGencode": return this.InheritedGencode;
				case "TaxonomyMCGenCodeWID": return this.TaxonomyMCGenCodeWID;
				case "InheritedMCGencode": return this.InheritedMCGencode;
				case "DataSetWID": return this.DataSetWID;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem WID
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.WID, tgSystemType.Int32); }
		}

		public tgQueryItem TaxId
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.TaxId, tgSystemType.Int32); }
		}

		public tgQueryItem ParentTaxId
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.ParentTaxId, tgSystemType.Int32); }
		}

		public tgQueryItem Rank
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.Rank, tgSystemType.String); }
		}

		public tgQueryItem EMBLCode
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.EMBLCode, tgSystemType.String); }
		}

		public tgQueryItem TaxonomyDivisionWID
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.TaxonomyDivisionWID, tgSystemType.Int32); }
		}

		public tgQueryItem InheritedDivision
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.InheritedDivision, tgSystemType.String); }
		}

		public tgQueryItem TaxonomyGenCodeWID
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.TaxonomyGenCodeWID, tgSystemType.Int32); }
		}

		public tgQueryItem InheritedGencode
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.InheritedGencode, tgSystemType.String); }
		}

		public tgQueryItem TaxonomyMCGenCodeWID
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.TaxonomyMCGenCodeWID, tgSystemType.Int32); }
		}

		public tgQueryItem InheritedMCGencode
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.InheritedMCGencode, tgSystemType.String); }
		}

		public tgQueryItem DataSetWID
		{
			get { return new tgQueryItem(this, TaxonomyMetadata.ColumnNames.DataSetWID, tgSystemType.Int32); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class TaxonomyMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected TaxonomyMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.WID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = TaxonomyMetadata.PropertyNames.WID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.TaxId, 1, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = TaxonomyMetadata.PropertyNames.TaxId;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.ParentTaxId, 2, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = TaxonomyMetadata.PropertyNames.ParentTaxId;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.Rank, 3, typeof(System.String), tgSystemType.String);
			c.PropertyName = TaxonomyMetadata.PropertyNames.Rank;
			c.IsNullable = true;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.EMBLCode, 4, typeof(System.String), tgSystemType.String);
			c.PropertyName = TaxonomyMetadata.PropertyNames.EMBLCode;
			c.IsNullable = true;
			c.CharacterMaxLength = 5;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.TaxonomyDivisionWID, 5, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = TaxonomyMetadata.PropertyNames.TaxonomyDivisionWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.InheritedDivision, 6, typeof(System.String), tgSystemType.String);
			c.PropertyName = TaxonomyMetadata.PropertyNames.InheritedDivision;
			c.IsNullable = true;
			c.CharacterMaxLength = 1;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.TaxonomyGenCodeWID, 7, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = TaxonomyMetadata.PropertyNames.TaxonomyGenCodeWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.InheritedGencode, 8, typeof(System.String), tgSystemType.String);
			c.PropertyName = TaxonomyMetadata.PropertyNames.InheritedGencode;
			c.IsNullable = true;
			c.CharacterMaxLength = 1;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.TaxonomyMCGenCodeWID, 9, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = TaxonomyMetadata.PropertyNames.TaxonomyMCGenCodeWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.InheritedMCGencode, 10, typeof(System.String), tgSystemType.String);
			c.PropertyName = TaxonomyMetadata.PropertyNames.InheritedMCGencode;
			c.IsNullable = true;
			c.CharacterMaxLength = 1;
			m_columns.Add(c);

			c = new tgColumnMetadata(TaxonomyMetadata.ColumnNames.DataSetWID, 11, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = TaxonomyMetadata.PropertyNames.DataSetWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
		}
		#endregion

		static public TaxonomyMetadata Meta()
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
			public const string TaxId = "TaxId";
			public const string ParentTaxId = "ParentTaxId";
			public const string Rank = "Rank";
			public const string EMBLCode = "EMBLCode";
			public const string TaxonomyDivisionWID = "TaxonomyDivision_WID";
			public const string InheritedDivision = "InheritedDivision";
			public const string TaxonomyGenCodeWID = "TaxonomyGenCode_WID";
			public const string InheritedGencode = "InheritedGencode";
			public const string TaxonomyMCGenCodeWID = "TaxonomyMCGenCode_WID";
			public const string InheritedMCGencode = "InheritedMCGencode";
			public const string DataSetWID = "DataSetWID";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string WID = "WID";
			public const string TaxId = "TaxId";
			public const string ParentTaxId = "ParentTaxId";
			public const string Rank = "Rank";
			public const string EMBLCode = "EMBLCode";
			public const string TaxonomyDivisionWID = "TaxonomyDivisionWID";
			public const string InheritedDivision = "InheritedDivision";
			public const string TaxonomyGenCodeWID = "TaxonomyGenCodeWID";
			public const string InheritedGencode = "InheritedGencode";
			public const string TaxonomyMCGenCodeWID = "TaxonomyMCGenCodeWID";
			public const string InheritedMCGencode = "InheritedMCGencode";
			public const string DataSetWID = "DataSetWID";
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
			lock (typeof(TaxonomyMetadata))
			{
				if (TaxonomyMetadata.mapDelegates == null)
				{
					TaxonomyMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (TaxonomyMetadata.meta == null)
				{
					TaxonomyMetadata.meta = new TaxonomyMetadata();
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
				meta.AddTypeMap("TaxId", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("ParentTaxId", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Rank", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("EMBLCode", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("TaxonomyDivisionWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("InheritedDivision", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("TaxonomyGenCodeWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("InheritedGencode", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("TaxonomyMCGenCodeWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("InheritedMCGencode", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("DataSetWID", new tgTypeMap("integer", "System.Int32"));

				meta.Source = "taxonomy";
				meta.Destination = "taxonomy";

				meta.spInsert = "proc_TaxonomyInsert";
				meta.spUpdate = "proc_TaxonomyUpdate";
				meta.spDelete = "proc_TaxonomyDelete";
				meta.spLoadAll = "proc_TaxonomyLoadAll";
				meta.spLoadByPrimaryKey = "proc_TaxonomyLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private TaxonomyMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}
