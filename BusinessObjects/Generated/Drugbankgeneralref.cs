
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
	[KnownType(typeof(Drugbankgeneralref))]
	[XmlType("Drugbankgeneralref")]
	public partial class Drugbankgeneralref : tgDrugbankgeneralref
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankgeneralref();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbankgeneralref : tgEntity
	{
		public tgDrugbankgeneralref()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbankgeneralref.DrugBankWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankWID
		{
			get
			{
				return base.GetSystemInt32(DrugbankgeneralrefMetadata.ColumnNames.DrugBankWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankgeneralrefMetadata.ColumnNames.DrugBankWID, value))
				{
					OnPropertyChanged(DrugbankgeneralrefMetadata.PropertyNames.DrugBankWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankgeneralref.Cite
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Cite
		{
			get
			{
				return base.GetSystemString(DrugbankgeneralrefMetadata.ColumnNames.Cite);
			}

			set
			{
				if (base.SetSystemString(DrugbankgeneralrefMetadata.ColumnNames.Cite, value))
				{
					OnPropertyChanged(DrugbankgeneralrefMetadata.PropertyNames.Cite);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankgeneralref.Link
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Link
		{
			get
			{
				return base.GetSystemString(DrugbankgeneralrefMetadata.ColumnNames.Link);
			}

			set
			{
				if (base.SetSystemString(DrugbankgeneralrefMetadata.ColumnNames.Link, value))
				{
					OnPropertyChanged(DrugbankgeneralrefMetadata.PropertyNames.Link);
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
				return DrugbankgeneralrefMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankgeneralrefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankgeneralrefQuery("s5");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankgeneralrefQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankgeneralrefQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankgeneralrefQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankgeneralrefCollection")]
	public partial class DrugbankgeneralrefCollection : tgDrugbankgeneralrefCollection, IEnumerable<Drugbankgeneralref>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankgeneralref))]
		public class DrugbankgeneralrefCollectionWCFPacket : tgCollectionWCFPacket<DrugbankgeneralrefCollection>
		{
			public static implicit operator DrugbankgeneralrefCollection(DrugbankgeneralrefCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankgeneralrefCollectionWCFPacket(DrugbankgeneralrefCollection collection)
			{
				return new DrugbankgeneralrefCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankgeneralrefCollection : tgEntityCollection<Drugbankgeneralref>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankgeneralrefMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankgeneralrefCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankgeneralrefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankgeneralrefQuery("t5");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankgeneralrefQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankgeneralrefQuery("u5");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankgeneralrefQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankgeneralrefQuery)query);
		}

		#endregion

		private DrugbankgeneralrefQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankgeneralrefQuery : tgDrugbankgeneralrefQuery
	{
		public DrugbankgeneralrefQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankgeneralrefQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankgeneralrefQuery query)
		{
			return DrugbankgeneralrefQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankgeneralrefQuery(string query)
		{
			return (DrugbankgeneralrefQuery)DrugbankgeneralrefQuery.SerializeHelper.FromXml(query, typeof(DrugbankgeneralrefQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankgeneralrefQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankgeneralrefMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugBankWID": return this.DrugBankWID;
				case "Cite": return this.Cite;
				case "Link": return this.Link;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugBankWID
		{
			get { return new tgQueryItem(this, DrugbankgeneralrefMetadata.ColumnNames.DrugBankWID, tgSystemType.Int32); }
		}

		public tgQueryItem Cite
		{
			get { return new tgQueryItem(this, DrugbankgeneralrefMetadata.ColumnNames.Cite, tgSystemType.String); }
		}

		public tgQueryItem Link
		{
			get { return new tgQueryItem(this, DrugbankgeneralrefMetadata.ColumnNames.Link, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankgeneralrefMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankgeneralrefMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankgeneralrefMetadata.ColumnNames.DrugBankWID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbankgeneralrefMetadata.PropertyNames.DrugBankWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankgeneralrefMetadata.ColumnNames.Cite, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankgeneralrefMetadata.PropertyNames.Cite;
			c.IsNullable = true;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankgeneralrefMetadata.ColumnNames.Link, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankgeneralrefMetadata.PropertyNames.Link;
			c.IsNullable = true;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankgeneralrefMetadata Meta()
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
			public const string Cite = "Cite";
			public const string Link = "Link";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugBankWID = "DrugBankWID";
			public const string Cite = "Cite";
			public const string Link = "Link";
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
			lock (typeof(DrugbankgeneralrefMetadata))
			{
				if (DrugbankgeneralrefMetadata.mapDelegates == null)
				{
					DrugbankgeneralrefMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankgeneralrefMetadata.meta == null)
				{
					DrugbankgeneralrefMetadata.meta = new DrugbankgeneralrefMetadata();
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
				meta.AddTypeMap("Cite", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Link", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankgeneralref";
				meta.Destination = "drugbankgeneralref";

				meta.spInsert = "proc_DrugbankgeneralrefInsert";
				meta.spUpdate = "proc_DrugbankgeneralrefUpdate";
				meta.spDelete = "proc_DrugbankgeneralrefDelete";
				meta.spLoadAll = "proc_DrugbankgeneralrefLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankgeneralrefLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankgeneralrefMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

