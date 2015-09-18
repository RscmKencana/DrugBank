
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
	[KnownType(typeof(CogorthologousgroupHasProtein))]
	[XmlType("CogorthologousgroupHasProtein")]
	public partial class CogorthologousgroupHasProtein : tgCogorthologousgroupHasProtein
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new CogorthologousgroupHasProtein();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 cOGOrthologousGroupWID, System.Int32 proteinWID)
		{
			var obj = new CogorthologousgroupHasProtein();
			obj.COGOrthologousGroupWID = cOGOrthologousGroupWID;
			obj.ProteinWID = proteinWID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 cOGOrthologousGroupWID, System.Int32 proteinWID, tgSqlAccessType sqlAccessType)
		{
			var obj = new CogorthologousgroupHasProtein();
			obj.COGOrthologousGroupWID = cOGOrthologousGroupWID;
			obj.ProteinWID = proteinWID;
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
	abstract public partial class tgCogorthologousgroupHasProtein : tgEntity
	{
		public tgCogorthologousgroupHasProtein()
		{

		}

		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 cOGOrthologousGroupWID, System.Int32 proteinWID)
		{
			if (this.tg.Connection.SqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(cOGOrthologousGroupWID, proteinWID);
			else
				return LoadByPrimaryKeyStoredProcedure(cOGOrthologousGroupWID, proteinWID);
		}

		public virtual bool LoadByPrimaryKey(tgSqlAccessType sqlAccessType, System.Int32 cOGOrthologousGroupWID, System.Int32 proteinWID)
		{
			if (sqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(cOGOrthologousGroupWID, proteinWID);
			else
				return LoadByPrimaryKeyStoredProcedure(cOGOrthologousGroupWID, proteinWID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 cOGOrthologousGroupWID, System.Int32 proteinWID)
		{
			CogorthologousgroupHasProteinQuery query = new CogorthologousgroupHasProteinQuery("h2");
			query.Where(query.COGOrthologousGroupWID == cOGOrthologousGroupWID && query.ProteinWID == proteinWID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 cOGOrthologousGroupWID, System.Int32 proteinWID)
		{
			tgParameters parms = new tgParameters();
			parms.Add("COGOrthologousGroupWID", cOGOrthologousGroupWID);
			parms.Add("ProteinWID", proteinWID);
			return this.Load(tgQueryType.StoredProcedure, this.tg.spLoadByPrimaryKey, parms);
		}
		#endregion

		#region Properties

		/// <summary>
		/// Maps to CogorthologousgroupHasProtein.COGOrthologousGroupWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? COGOrthologousGroupWID
		{
			get
			{
				return base.GetSystemInt32(CogorthologousgroupHasProteinMetadata.ColumnNames.COGOrthologousGroupWID);
			}

			set
			{
				if (base.SetSystemInt32(CogorthologousgroupHasProteinMetadata.ColumnNames.COGOrthologousGroupWID, value))
				{
					OnPropertyChanged(CogorthologousgroupHasProteinMetadata.PropertyNames.COGOrthologousGroupWID);
				}
			}
		}

		/// <summary>
		/// Maps to CogorthologousgroupHasProtein.ProteinWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? ProteinWID
		{
			get
			{
				return base.GetSystemInt32(CogorthologousgroupHasProteinMetadata.ColumnNames.ProteinWID);
			}

			set
			{
				if (base.SetSystemInt32(CogorthologousgroupHasProteinMetadata.ColumnNames.ProteinWID, value))
				{
					OnPropertyChanged(CogorthologousgroupHasProteinMetadata.PropertyNames.ProteinWID);
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
				return CogorthologousgroupHasProteinMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public CogorthologousgroupHasProteinQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CogorthologousgroupHasProteinQuery("i2");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CogorthologousgroupHasProteinQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(CogorthologousgroupHasProteinQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private CogorthologousgroupHasProteinQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("CogorthologousgroupHasProteinCollection")]
	public partial class CogorthologousgroupHasProteinCollection : tgCogorthologousgroupHasProteinCollection, IEnumerable<CogorthologousgroupHasProtein>
	{
		public CogorthologousgroupHasProtein FindByPrimaryKey(int cOGOrthologousGroupWID, int proteinWID)
		{
			return this.SingleOrDefault(e => e.COGOrthologousGroupWID == cOGOrthologousGroupWID && e.ProteinWID == proteinWID);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(CogorthologousgroupHasProtein))]
		public class CogorthologousgroupHasProteinCollectionWCFPacket : tgCollectionWCFPacket<CogorthologousgroupHasProteinCollection>
		{
			public static implicit operator CogorthologousgroupHasProteinCollection(CogorthologousgroupHasProteinCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator CogorthologousgroupHasProteinCollectionWCFPacket(CogorthologousgroupHasProteinCollection collection)
			{
				return new CogorthologousgroupHasProteinCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgCogorthologousgroupHasProteinCollection : tgEntityCollection<CogorthologousgroupHasProtein>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CogorthologousgroupHasProteinMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CogorthologousgroupHasProteinCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public CogorthologousgroupHasProteinQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CogorthologousgroupHasProteinQuery("j2");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CogorthologousgroupHasProteinQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CogorthologousgroupHasProteinQuery("k2");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CogorthologousgroupHasProteinQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((CogorthologousgroupHasProteinQuery)query);
		}

		#endregion

		private CogorthologousgroupHasProteinQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class CogorthologousgroupHasProteinQuery : tgCogorthologousgroupHasProteinQuery
	{
		public CogorthologousgroupHasProteinQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CogorthologousgroupHasProteinQuery";
		}

		#region Explicit Casts

		public static explicit operator string(CogorthologousgroupHasProteinQuery query)
		{
			return CogorthologousgroupHasProteinQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CogorthologousgroupHasProteinQuery(string query)
		{
			return (CogorthologousgroupHasProteinQuery)CogorthologousgroupHasProteinQuery.SerializeHelper.FromXml(query, typeof(CogorthologousgroupHasProteinQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgCogorthologousgroupHasProteinQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CogorthologousgroupHasProteinMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "COGOrthologousGroupWID": return this.COGOrthologousGroupWID;
				case "ProteinWID": return this.ProteinWID;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem COGOrthologousGroupWID
		{
			get { return new tgQueryItem(this, CogorthologousgroupHasProteinMetadata.ColumnNames.COGOrthologousGroupWID, tgSystemType.Int32); }
		}

		public tgQueryItem ProteinWID
		{
			get { return new tgQueryItem(this, CogorthologousgroupHasProteinMetadata.ColumnNames.ProteinWID, tgSystemType.Int32); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class CogorthologousgroupHasProteinMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected CogorthologousgroupHasProteinMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(CogorthologousgroupHasProteinMetadata.ColumnNames.COGOrthologousGroupWID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = CogorthologousgroupHasProteinMetadata.PropertyNames.COGOrthologousGroupWID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(CogorthologousgroupHasProteinMetadata.ColumnNames.ProteinWID, 1, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = CogorthologousgroupHasProteinMetadata.PropertyNames.ProteinWID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
		}
		#endregion

		static public CogorthologousgroupHasProteinMetadata Meta()
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
			public const string COGOrthologousGroupWID = "COGOrthologousGroup_WID";
			public const string ProteinWID = "Protein_WID";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string COGOrthologousGroupWID = "COGOrthologousGroupWID";
			public const string ProteinWID = "ProteinWID";
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
			lock (typeof(CogorthologousgroupHasProteinMetadata))
			{
				if (CogorthologousgroupHasProteinMetadata.mapDelegates == null)
				{
					CogorthologousgroupHasProteinMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (CogorthologousgroupHasProteinMetadata.meta == null)
				{
					CogorthologousgroupHasProteinMetadata.meta = new CogorthologousgroupHasProteinMetadata();
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


				meta.AddTypeMap("COGOrthologousGroupWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("ProteinWID", new tgTypeMap("integer", "System.Int32"));

				meta.Source = "cogorthologousgroup_has_protein";
				meta.Destination = "cogorthologousgroup_has_protein";

				meta.spInsert = "proc_CogorthologousgroupHasProteinInsert";
				meta.spUpdate = "proc_CogorthologousgroupHasProteinUpdate";
				meta.spDelete = "proc_CogorthologousgroupHasProteinDelete";
				meta.spLoadAll = "proc_CogorthologousgroupHasProteinLoadAll";
				meta.spLoadByPrimaryKey = "proc_CogorthologousgroupHasProteinLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private CogorthologousgroupHasProteinMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}
