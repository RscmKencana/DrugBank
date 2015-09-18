
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
	[KnownType(typeof(Drugbankcategoriestemp))]
	[XmlType("Drugbankcategoriestemp")]
	public partial class Drugbankcategoriestemp : tgDrugbankcategoriestemp
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankcategoriestemp();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbankcategoriestemp : tgEntity
	{
		public tgDrugbankcategoriestemp()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbankcategoriestemp.DrugbankWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankcategoriestempMetadata.ColumnNames.DrugbankWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankcategoriestempMetadata.ColumnNames.DrugbankWid, value))
				{
					OnPropertyChanged(DrugbankcategoriestempMetadata.PropertyNames.DrugbankWid);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankcategoriestemp.Category
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Category
		{
			get
			{
				return base.GetSystemString(DrugbankcategoriestempMetadata.ColumnNames.Category);
			}

			set
			{
				if (base.SetSystemString(DrugbankcategoriestempMetadata.ColumnNames.Category, value))
				{
					OnPropertyChanged(DrugbankcategoriestempMetadata.PropertyNames.Category);
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
				return DrugbankcategoriestempMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankcategoriestempQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankcategoriestempQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankcategoriestempQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankcategoriestempQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankcategoriestempQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankcategoriestempCollection")]
	public partial class DrugbankcategoriestempCollection : tgDrugbankcategoriestempCollection, IEnumerable<Drugbankcategoriestemp>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankcategoriestemp))]
		public class DrugbankcategoriestempCollectionWCFPacket : tgCollectionWCFPacket<DrugbankcategoriestempCollection>
		{
			public static implicit operator DrugbankcategoriestempCollection(DrugbankcategoriestempCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankcategoriestempCollectionWCFPacket(DrugbankcategoriestempCollection collection)
			{
				return new DrugbankcategoriestempCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankcategoriestempCollection : tgEntityCollection<Drugbankcategoriestemp>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankcategoriestempMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankcategoriestempCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankcategoriestempQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankcategoriestempQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankcategoriestempQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankcategoriestempQuery("");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankcategoriestempQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankcategoriestempQuery)query);
		}

		#endregion

		private DrugbankcategoriestempQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankcategoriestempQuery : tgDrugbankcategoriestempQuery
	{
		public DrugbankcategoriestempQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankcategoriestempQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankcategoriestempQuery query)
		{
			return DrugbankcategoriestempQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankcategoriestempQuery(string query)
		{
			return (DrugbankcategoriestempQuery)DrugbankcategoriestempQuery.SerializeHelper.FromXml(query, typeof(DrugbankcategoriestempQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankcategoriestempQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankcategoriestempMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugbankWid": return this.DrugbankWid;
				case "Category": return this.Category;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugbankWid
		{
			get { return new tgQueryItem(this, DrugbankcategoriestempMetadata.ColumnNames.DrugbankWid, tgSystemType.Int32); }		
		}

		public tgQueryItem Category
		{
			get { return new tgQueryItem(this, DrugbankcategoriestempMetadata.ColumnNames.Category, tgSystemType.String); }		
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankcategoriestempMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankcategoriestempMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankcategoriestempMetadata.ColumnNames.DrugbankWid, 0, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankcategoriestempMetadata.PropertyNames.DrugbankWid;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankcategoriestempMetadata.ColumnNames.Category, 1, typeof(System.String), tgSystemType.String);			
			c.PropertyName = DrugbankcategoriestempMetadata.PropertyNames.Category;
			c.IsNullable = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankcategoriestempMetadata Meta()
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
			public const string Category = "Category";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugbankWid = "DrugbankWid";
			public const string Category = "Category";
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
			lock (typeof(DrugbankcategoriestempMetadata))
			{
				if (DrugbankcategoriestempMetadata.mapDelegates == null)
				{
					DrugbankcategoriestempMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankcategoriestempMetadata.meta == null)
				{
					DrugbankcategoriestempMetadata.meta = new DrugbankcategoriestempMetadata();
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
				meta.AddTypeMap("Category", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankcategoriestemp";
				meta.Destination = "drugbankcategoriestemp";

				meta.spInsert = "proc_DrugbankcategoriestempInsert";
				meta.spUpdate = "proc_DrugbankcategoriestempUpdate";
				meta.spDelete = "proc_DrugbankcategoriestempDelete";
				meta.spLoadAll = "proc_DrugbankcategoriestempLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankcategoriestempLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankcategoriestempMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

