
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
	[KnownType(typeof(Cogfuncclassgroup))]
	[XmlType("Cogfuncclassgroup")]
	public partial class Cogfuncclassgroup : tgCogfuncclassgroup
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Cogfuncclassgroup();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 wID)
		{
			var obj = new Cogfuncclassgroup();
			obj.WID = wID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 wID, tgSqlAccessType sqlAccessType)
		{
			var obj = new Cogfuncclassgroup();
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
	abstract public partial class tgCogfuncclassgroup : tgEntity
	{
		public tgCogfuncclassgroup()
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
			CogfuncclassgroupQuery query = new CogfuncclassgroupQuery("e1");
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
		/// Maps to Cogfuncclassgroup.WID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? WID
		{
			get
			{
				return base.GetSystemInt32(CogfuncclassgroupMetadata.ColumnNames.WID);
			}

			set
			{
				if (base.SetSystemInt32(CogfuncclassgroupMetadata.ColumnNames.WID, value))
				{
					OnPropertyChanged(CogfuncclassgroupMetadata.PropertyNames.WID);
				}
			}
		}

		/// <summary>
		/// Maps to Cogfuncclassgroup.Name
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Name
		{
			get
			{
				return base.GetSystemString(CogfuncclassgroupMetadata.ColumnNames.Name);
			}

			set
			{
				if (base.SetSystemString(CogfuncclassgroupMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(CogfuncclassgroupMetadata.PropertyNames.Name);
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
				return CogfuncclassgroupMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public CogfuncclassgroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CogfuncclassgroupQuery("f1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CogfuncclassgroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(CogfuncclassgroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private CogfuncclassgroupQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("CogfuncclassgroupCollection")]
	public partial class CogfuncclassgroupCollection : tgCogfuncclassgroupCollection, IEnumerable<Cogfuncclassgroup>
	{
		public Cogfuncclassgroup FindByPrimaryKey(int wID)
		{
			return this.SingleOrDefault(e => e.WID == wID);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Cogfuncclassgroup))]
		public class CogfuncclassgroupCollectionWCFPacket : tgCollectionWCFPacket<CogfuncclassgroupCollection>
		{
			public static implicit operator CogfuncclassgroupCollection(CogfuncclassgroupCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator CogfuncclassgroupCollectionWCFPacket(CogfuncclassgroupCollection collection)
			{
				return new CogfuncclassgroupCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgCogfuncclassgroupCollection : tgEntityCollection<Cogfuncclassgroup>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CogfuncclassgroupMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CogfuncclassgroupCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public CogfuncclassgroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CogfuncclassgroupQuery("g1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CogfuncclassgroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CogfuncclassgroupQuery("h1");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CogfuncclassgroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((CogfuncclassgroupQuery)query);
		}

		#endregion

		private CogfuncclassgroupQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class CogfuncclassgroupQuery : tgCogfuncclassgroupQuery
	{
		public CogfuncclassgroupQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CogfuncclassgroupQuery";
		}

		#region Explicit Casts

		public static explicit operator string(CogfuncclassgroupQuery query)
		{
			return CogfuncclassgroupQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CogfuncclassgroupQuery(string query)
		{
			return (CogfuncclassgroupQuery)CogfuncclassgroupQuery.SerializeHelper.FromXml(query, typeof(CogfuncclassgroupQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgCogfuncclassgroupQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CogfuncclassgroupMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "WID": return this.WID;
				case "Name": return this.Name;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem WID
		{
			get { return new tgQueryItem(this, CogfuncclassgroupMetadata.ColumnNames.WID, tgSystemType.Int32); }
		}

		public tgQueryItem Name
		{
			get { return new tgQueryItem(this, CogfuncclassgroupMetadata.ColumnNames.Name, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class CogfuncclassgroupMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected CogfuncclassgroupMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(CogfuncclassgroupMetadata.ColumnNames.WID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = CogfuncclassgroupMetadata.PropertyNames.WID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(CogfuncclassgroupMetadata.ColumnNames.Name, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = CogfuncclassgroupMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
		}
		#endregion

		static public CogfuncclassgroupMetadata Meta()
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
			public const string Name = "Name";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string WID = "WID";
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
			lock (typeof(CogfuncclassgroupMetadata))
			{
				if (CogfuncclassgroupMetadata.mapDelegates == null)
				{
					CogfuncclassgroupMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (CogfuncclassgroupMetadata.meta == null)
				{
					CogfuncclassgroupMetadata.meta = new CogfuncclassgroupMetadata();
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
				meta.AddTypeMap("Name", new tgTypeMap("text", "System.String"));

				meta.Source = "cogfuncclassgroup";
				meta.Destination = "cogfuncclassgroup";

				meta.spInsert = "proc_CogfuncclassgroupInsert";
				meta.spUpdate = "proc_CogfuncclassgroupUpdate";
				meta.spDelete = "proc_CogfuncclassgroupDelete";
				meta.spLoadAll = "proc_CogfuncclassgroupLoadAll";
				meta.spLoadByPrimaryKey = "proc_CogfuncclassgroupLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private CogfuncclassgroupMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

