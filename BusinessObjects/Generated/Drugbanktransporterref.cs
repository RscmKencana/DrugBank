
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
	[KnownType(typeof(Drugbanktransporterref))]
	[XmlType("Drugbanktransporterref")]
	public partial class Drugbanktransporterref : tgDrugbanktransporterref
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbanktransporterref();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbanktransporterref : tgEntity
	{
		public tgDrugbanktransporterref()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbanktransporterref.DrugBankTransporterWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankTransporterWID
		{
			get
			{
				return base.GetSystemInt32(DrugbanktransporterrefMetadata.ColumnNames.DrugBankTransporterWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbanktransporterrefMetadata.ColumnNames.DrugBankTransporterWID, value))
				{
					OnPropertyChanged(DrugbanktransporterrefMetadata.PropertyNames.DrugBankTransporterWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktransporterref.Cite
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Cite
		{
			get
			{
				return base.GetSystemString(DrugbanktransporterrefMetadata.ColumnNames.Cite);
			}

			set
			{
				if (base.SetSystemString(DrugbanktransporterrefMetadata.ColumnNames.Cite, value))
				{
					OnPropertyChanged(DrugbanktransporterrefMetadata.PropertyNames.Cite);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktransporterref.Link
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Link
		{
			get
			{
				return base.GetSystemString(DrugbanktransporterrefMetadata.ColumnNames.Link);
			}

			set
			{
				if (base.SetSystemString(DrugbanktransporterrefMetadata.ColumnNames.Link, value))
				{
					OnPropertyChanged(DrugbanktransporterrefMetadata.PropertyNames.Link);
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
				return DrugbanktransporterrefMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbanktransporterrefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktransporterrefQuery("aj1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktransporterrefQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbanktransporterrefQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbanktransporterrefQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbanktransporterrefCollection")]
	public partial class DrugbanktransporterrefCollection : tgDrugbanktransporterrefCollection, IEnumerable<Drugbanktransporterref>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbanktransporterref))]
		public class DrugbanktransporterrefCollectionWCFPacket : tgCollectionWCFPacket<DrugbanktransporterrefCollection>
		{
			public static implicit operator DrugbanktransporterrefCollection(DrugbanktransporterrefCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbanktransporterrefCollectionWCFPacket(DrugbanktransporterrefCollection collection)
			{
				return new DrugbanktransporterrefCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbanktransporterrefCollection : tgEntityCollection<Drugbanktransporterref>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktransporterrefMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbanktransporterrefCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbanktransporterrefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktransporterrefQuery("ai1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktransporterrefQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbanktransporterrefQuery("ah1");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbanktransporterrefQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbanktransporterrefQuery)query);
		}

		#endregion

		private DrugbanktransporterrefQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbanktransporterrefQuery : tgDrugbanktransporterrefQuery
	{
		public DrugbanktransporterrefQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbanktransporterrefQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbanktransporterrefQuery query)
		{
			return DrugbanktransporterrefQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbanktransporterrefQuery(string query)
		{
			return (DrugbanktransporterrefQuery)DrugbanktransporterrefQuery.SerializeHelper.FromXml(query, typeof(DrugbanktransporterrefQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbanktransporterrefQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktransporterrefMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugBankTransporterWID": return this.DrugBankTransporterWID;
				case "Cite": return this.Cite;
				case "Link": return this.Link;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugBankTransporterWID
		{
			get { return new tgQueryItem(this, DrugbanktransporterrefMetadata.ColumnNames.DrugBankTransporterWID, tgSystemType.Int32); }
		}

		public tgQueryItem Cite
		{
			get { return new tgQueryItem(this, DrugbanktransporterrefMetadata.ColumnNames.Cite, tgSystemType.String); }
		}

		public tgQueryItem Link
		{
			get { return new tgQueryItem(this, DrugbanktransporterrefMetadata.ColumnNames.Link, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbanktransporterrefMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbanktransporterrefMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbanktransporterrefMetadata.ColumnNames.DrugBankTransporterWID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbanktransporterrefMetadata.PropertyNames.DrugBankTransporterWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktransporterrefMetadata.ColumnNames.Cite, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbanktransporterrefMetadata.PropertyNames.Cite;
			c.IsNullable = true;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktransporterrefMetadata.ColumnNames.Link, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbanktransporterrefMetadata.PropertyNames.Link;
			c.IsNullable = true;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbanktransporterrefMetadata Meta()
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
			public const string DrugBankTransporterWID = "DrugBankTransporter_WID";
			public const string Cite = "Cite";
			public const string Link = "Link";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugBankTransporterWID = "DrugBankTransporterWID";
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
			lock (typeof(DrugbanktransporterrefMetadata))
			{
				if (DrugbanktransporterrefMetadata.mapDelegates == null)
				{
					DrugbanktransporterrefMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbanktransporterrefMetadata.meta == null)
				{
					DrugbanktransporterrefMetadata.meta = new DrugbanktransporterrefMetadata();
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


				meta.AddTypeMap("DrugBankTransporterWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Cite", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Link", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbanktransporterref";
				meta.Destination = "drugbanktransporterref";

				meta.spInsert = "proc_DrugbanktransporterrefInsert";
				meta.spUpdate = "proc_DrugbanktransporterrefUpdate";
				meta.spDelete = "proc_DrugbanktransporterrefDelete";
				meta.spLoadAll = "proc_DrugbanktransporterrefLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbanktransporterrefLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbanktransporterrefMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}
