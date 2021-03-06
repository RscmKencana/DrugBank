
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
	[KnownType(typeof(Drugbanktaxonomy))]
	[XmlType("Drugbanktaxonomy")]
	public partial class Drugbanktaxonomy : tgDrugbanktaxonomy
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbanktaxonomy();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbanktaxonomy : tgEntity
	{
		public tgDrugbanktaxonomy()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbanktaxonomy.DrugBankWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankWID
		{
			get
			{
				return base.GetSystemInt32(DrugbanktaxonomyMetadata.ColumnNames.DrugBankWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbanktaxonomyMetadata.ColumnNames.DrugBankWID, value))
				{
					OnPropertyChanged(DrugbanktaxonomyMetadata.PropertyNames.DrugBankWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktaxonomy.Kingdom
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Kingdom
		{
			get
			{
				return base.GetSystemString(DrugbanktaxonomyMetadata.ColumnNames.Kingdom);
			}

			set
			{
				if (base.SetSystemString(DrugbanktaxonomyMetadata.ColumnNames.Kingdom, value))
				{
					OnPropertyChanged(DrugbanktaxonomyMetadata.PropertyNames.Kingdom);
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
				return DrugbanktaxonomyMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbanktaxonomyQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktaxonomyQuery("e9");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktaxonomyQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbanktaxonomyQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbanktaxonomyQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbanktaxonomyCollection")]
	public partial class DrugbanktaxonomyCollection : tgDrugbanktaxonomyCollection, IEnumerable<Drugbanktaxonomy>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbanktaxonomy))]
		public class DrugbanktaxonomyCollectionWCFPacket : tgCollectionWCFPacket<DrugbanktaxonomyCollection>
		{
			public static implicit operator DrugbanktaxonomyCollection(DrugbanktaxonomyCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbanktaxonomyCollectionWCFPacket(DrugbanktaxonomyCollection collection)
			{
				return new DrugbanktaxonomyCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbanktaxonomyCollection : tgEntityCollection<Drugbanktaxonomy>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktaxonomyMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbanktaxonomyCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbanktaxonomyQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktaxonomyQuery("e9");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktaxonomyQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbanktaxonomyQuery("e9");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbanktaxonomyQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbanktaxonomyQuery)query);
		}

		#endregion

		private DrugbanktaxonomyQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbanktaxonomyQuery : tgDrugbanktaxonomyQuery
	{
		public DrugbanktaxonomyQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbanktaxonomyQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbanktaxonomyQuery query)
		{
			return DrugbanktaxonomyQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbanktaxonomyQuery(string query)
		{
			return (DrugbanktaxonomyQuery)DrugbanktaxonomyQuery.SerializeHelper.FromXml(query, typeof(DrugbanktaxonomyQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbanktaxonomyQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktaxonomyMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugBankWID": return this.DrugBankWID;
				case "Kingdom": return this.Kingdom;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugBankWID
		{
			get { return new tgQueryItem(this, DrugbanktaxonomyMetadata.ColumnNames.DrugBankWID, tgSystemType.Int32); }
		}

		public tgQueryItem Kingdom
		{
			get { return new tgQueryItem(this, DrugbanktaxonomyMetadata.ColumnNames.Kingdom, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbanktaxonomyMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbanktaxonomyMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbanktaxonomyMetadata.ColumnNames.DrugBankWID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbanktaxonomyMetadata.PropertyNames.DrugBankWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktaxonomyMetadata.ColumnNames.Kingdom, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbanktaxonomyMetadata.PropertyNames.Kingdom;
			c.IsNullable = true;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbanktaxonomyMetadata Meta()
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
			public const string DrugBankWID = "DrugBank_WID";
			public const string Kingdom = "Kingdom";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugBankWID = "DrugBankWID";
			public const string Kingdom = "Kingdom";
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
			lock (typeof(DrugbanktaxonomyMetadata))
			{
				if (DrugbanktaxonomyMetadata.mapDelegates == null)
				{
					DrugbanktaxonomyMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbanktaxonomyMetadata.meta == null)
				{
					DrugbanktaxonomyMetadata.meta = new DrugbanktaxonomyMetadata();
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


				meta.AddTypeMap("DrugBankWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Kingdom", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbanktaxonomy";
				meta.Destination = "drugbanktaxonomy";

				meta.spInsert = "proc_DrugbanktaxonomyInsert";
				meta.spUpdate = "proc_DrugbanktaxonomyUpdate";
				meta.spDelete = "proc_DrugbanktaxonomyDelete";
				meta.spLoadAll = "proc_DrugbanktaxonomyLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbanktaxonomyLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbanktaxonomyMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

