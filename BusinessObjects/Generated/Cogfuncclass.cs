
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
	[KnownType(typeof(Cogfuncclass))]
	[XmlType("Cogfuncclass")]
	public partial class Cogfuncclass : tgCogfuncclass
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Cogfuncclass();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 wID)
		{
			var obj = new Cogfuncclass();
			obj.WID = wID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 wID, tgSqlAccessType sqlAccessType)
		{
			var obj = new Cogfuncclass();
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
	abstract public partial class tgCogfuncclass : tgEntity
	{
		public tgCogfuncclass()
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
			CogfuncclassQuery query = new CogfuncclassQuery("b1");
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
		/// Maps to Cogfuncclass.WID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? WID
		{
			get
			{
				return base.GetSystemInt32(CogfuncclassMetadata.ColumnNames.WID);
			}

			set
			{
				if (base.SetSystemInt32(CogfuncclassMetadata.ColumnNames.WID, value))
				{
					OnPropertyChanged(CogfuncclassMetadata.PropertyNames.WID);
				}
			}
		}

		/// <summary>
		/// Maps to Cogfuncclass.Letter
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Letter
		{
			get
			{
				return base.GetSystemString(CogfuncclassMetadata.ColumnNames.Letter);
			}

			set
			{
				if (base.SetSystemString(CogfuncclassMetadata.ColumnNames.Letter, value))
				{
					OnPropertyChanged(CogfuncclassMetadata.PropertyNames.Letter);
				}
			}
		}

		/// <summary>
		/// Maps to Cogfuncclass.Name
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Name
		{
			get
			{
				return base.GetSystemString(CogfuncclassMetadata.ColumnNames.Name);
			}

			set
			{
				if (base.SetSystemString(CogfuncclassMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(CogfuncclassMetadata.PropertyNames.Name);
				}
			}
		}

		/// <summary>
		/// Maps to Cogfuncclass.COGFuncClassGroupWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? COGFuncClassGroupWID
		{
			get
			{
				return base.GetSystemInt32(CogfuncclassMetadata.ColumnNames.COGFuncClassGroupWID);
			}

			set
			{
				if (base.SetSystemInt32(CogfuncclassMetadata.ColumnNames.COGFuncClassGroupWID, value))
				{
					OnPropertyChanged(CogfuncclassMetadata.PropertyNames.COGFuncClassGroupWID);
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
				return CogfuncclassMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public CogfuncclassQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CogfuncclassQuery("c1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CogfuncclassQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(CogfuncclassQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private CogfuncclassQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("CogfuncclassCollection")]
	public partial class CogfuncclassCollection : tgCogfuncclassCollection, IEnumerable<Cogfuncclass>
	{
		public Cogfuncclass FindByPrimaryKey(int wID)
		{
			return this.SingleOrDefault(e => e.WID == wID);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Cogfuncclass))]
		public class CogfuncclassCollectionWCFPacket : tgCollectionWCFPacket<CogfuncclassCollection>
		{
			public static implicit operator CogfuncclassCollection(CogfuncclassCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator CogfuncclassCollectionWCFPacket(CogfuncclassCollection collection)
			{
				return new CogfuncclassCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgCogfuncclassCollection : tgEntityCollection<Cogfuncclass>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CogfuncclassMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CogfuncclassCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public CogfuncclassQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CogfuncclassQuery("i1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CogfuncclassQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CogfuncclassQuery("j1");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CogfuncclassQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((CogfuncclassQuery)query);
		}

		#endregion

		private CogfuncclassQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class CogfuncclassQuery : tgCogfuncclassQuery
	{
		public CogfuncclassQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CogfuncclassQuery";
		}

		#region Explicit Casts

		public static explicit operator string(CogfuncclassQuery query)
		{
			return CogfuncclassQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CogfuncclassQuery(string query)
		{
			return (CogfuncclassQuery)CogfuncclassQuery.SerializeHelper.FromXml(query, typeof(CogfuncclassQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgCogfuncclassQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CogfuncclassMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "WID": return this.WID;
				case "Letter": return this.Letter;
				case "Name": return this.Name;
				case "COGFuncClassGroupWID": return this.COGFuncClassGroupWID;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem WID
		{
			get { return new tgQueryItem(this, CogfuncclassMetadata.ColumnNames.WID, tgSystemType.Int32); }
		}

		public tgQueryItem Letter
		{
			get { return new tgQueryItem(this, CogfuncclassMetadata.ColumnNames.Letter, tgSystemType.String); }
		}

		public tgQueryItem Name
		{
			get { return new tgQueryItem(this, CogfuncclassMetadata.ColumnNames.Name, tgSystemType.String); }
		}

		public tgQueryItem COGFuncClassGroupWID
		{
			get { return new tgQueryItem(this, CogfuncclassMetadata.ColumnNames.COGFuncClassGroupWID, tgSystemType.Int32); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class CogfuncclassMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected CogfuncclassMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(CogfuncclassMetadata.ColumnNames.WID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = CogfuncclassMetadata.PropertyNames.WID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(CogfuncclassMetadata.ColumnNames.Letter, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = CogfuncclassMetadata.PropertyNames.Letter;
			c.CharacterMaxLength = 1;
			m_columns.Add(c);

			c = new tgColumnMetadata(CogfuncclassMetadata.ColumnNames.Name, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = CogfuncclassMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);

			c = new tgColumnMetadata(CogfuncclassMetadata.ColumnNames.COGFuncClassGroupWID, 3, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = CogfuncclassMetadata.PropertyNames.COGFuncClassGroupWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
		}
		#endregion

		static public CogfuncclassMetadata Meta()
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
			public const string Letter = "Letter";
			public const string Name = "Name";
			public const string COGFuncClassGroupWID = "COGFuncClassGroup_WID";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string WID = "WID";
			public const string Letter = "Letter";
			public const string Name = "Name";
			public const string COGFuncClassGroupWID = "COGFuncClassGroupWID";
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
			lock (typeof(CogfuncclassMetadata))
			{
				if (CogfuncclassMetadata.mapDelegates == null)
				{
					CogfuncclassMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (CogfuncclassMetadata.meta == null)
				{
					CogfuncclassMetadata.meta = new CogfuncclassMetadata();
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
				meta.AddTypeMap("Letter", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Name", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("COGFuncClassGroupWID", new tgTypeMap("integer", "System.Int32"));

				meta.Source = "cogfuncclass";
				meta.Destination = "cogfuncclass";

				meta.spInsert = "proc_CogfuncclassInsert";
				meta.spUpdate = "proc_CogfuncclassUpdate";
				meta.spDelete = "proc_CogfuncclassDelete";
				meta.spLoadAll = "proc_CogfuncclassLoadAll";
				meta.spLoadByPrimaryKey = "proc_CogfuncclassLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private CogfuncclassMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

