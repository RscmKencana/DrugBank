
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
	[KnownType(typeof(Drugbankproteinsequence))]
	[XmlType("Drugbankproteinsequence")]
	public partial class Drugbankproteinsequence : tgDrugbankproteinsequence
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankproteinsequence();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbankproteinsequence : tgEntity
	{
		public tgDrugbankproteinsequence()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbankproteinsequence.DrugBankWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankWID
		{
			get
			{
				return base.GetSystemInt32(DrugbankproteinsequenceMetadata.ColumnNames.DrugBankWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankproteinsequenceMetadata.ColumnNames.DrugBankWID, value))
				{
					OnPropertyChanged(DrugbankproteinsequenceMetadata.PropertyNames.DrugBankWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankproteinsequence.Header
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Header
		{
			get
			{
				return base.GetSystemString(DrugbankproteinsequenceMetadata.ColumnNames.Header);
			}

			set
			{
				if (base.SetSystemString(DrugbankproteinsequenceMetadata.ColumnNames.Header, value))
				{
					OnPropertyChanged(DrugbankproteinsequenceMetadata.PropertyNames.Header);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankproteinsequence.Chain
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Chain
		{
			get
			{
				return base.GetSystemString(DrugbankproteinsequenceMetadata.ColumnNames.Chain);
			}

			set
			{
				if (base.SetSystemString(DrugbankproteinsequenceMetadata.ColumnNames.Chain, value))
				{
					OnPropertyChanged(DrugbankproteinsequenceMetadata.PropertyNames.Chain);
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
				return DrugbankproteinsequenceMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankproteinsequenceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankproteinsequenceQuery("o7");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankproteinsequenceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankproteinsequenceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankproteinsequenceQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankproteinsequenceCollection")]
	public partial class DrugbankproteinsequenceCollection : tgDrugbankproteinsequenceCollection, IEnumerable<Drugbankproteinsequence>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankproteinsequence))]
		public class DrugbankproteinsequenceCollectionWCFPacket : tgCollectionWCFPacket<DrugbankproteinsequenceCollection>
		{
			public static implicit operator DrugbankproteinsequenceCollection(DrugbankproteinsequenceCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankproteinsequenceCollectionWCFPacket(DrugbankproteinsequenceCollection collection)
			{
				return new DrugbankproteinsequenceCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankproteinsequenceCollection : tgEntityCollection<Drugbankproteinsequence>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankproteinsequenceMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankproteinsequenceCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankproteinsequenceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankproteinsequenceQuery("p7");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankproteinsequenceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankproteinsequenceQuery("q7");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankproteinsequenceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankproteinsequenceQuery)query);
		}

		#endregion

		private DrugbankproteinsequenceQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankproteinsequenceQuery : tgDrugbankproteinsequenceQuery
	{
		public DrugbankproteinsequenceQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankproteinsequenceQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankproteinsequenceQuery query)
		{
			return DrugbankproteinsequenceQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankproteinsequenceQuery(string query)
		{
			return (DrugbankproteinsequenceQuery)DrugbankproteinsequenceQuery.SerializeHelper.FromXml(query, typeof(DrugbankproteinsequenceQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankproteinsequenceQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankproteinsequenceMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugBankWID": return this.DrugBankWID;
				case "Header": return this.Header;
				case "Chain": return this.Chain;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugBankWID
		{
			get { return new tgQueryItem(this, DrugbankproteinsequenceMetadata.ColumnNames.DrugBankWID, tgSystemType.Int32); }
		}

		public tgQueryItem Header
		{
			get { return new tgQueryItem(this, DrugbankproteinsequenceMetadata.ColumnNames.Header, tgSystemType.String); }
		}

		public tgQueryItem Chain
		{
			get { return new tgQueryItem(this, DrugbankproteinsequenceMetadata.ColumnNames.Chain, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankproteinsequenceMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankproteinsequenceMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankproteinsequenceMetadata.ColumnNames.DrugBankWID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbankproteinsequenceMetadata.PropertyNames.DrugBankWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankproteinsequenceMetadata.ColumnNames.Header, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankproteinsequenceMetadata.PropertyNames.Header;
			c.IsNullable = true;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankproteinsequenceMetadata.ColumnNames.Chain, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankproteinsequenceMetadata.PropertyNames.Chain;
			c.IsNullable = true;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankproteinsequenceMetadata Meta()
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
			public const string Header = "Header";
			public const string Chain = "Chain";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugBankWID = "DrugBankWID";
			public const string Header = "Header";
			public const string Chain = "Chain";
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
			lock (typeof(DrugbankproteinsequenceMetadata))
			{
				if (DrugbankproteinsequenceMetadata.mapDelegates == null)
				{
					DrugbankproteinsequenceMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankproteinsequenceMetadata.meta == null)
				{
					DrugbankproteinsequenceMetadata.meta = new DrugbankproteinsequenceMetadata();
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
				meta.AddTypeMap("Header", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Chain", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankproteinsequence";
				meta.Destination = "drugbankproteinsequence";

				meta.spInsert = "proc_DrugbankproteinsequenceInsert";
				meta.spUpdate = "proc_DrugbankproteinsequenceUpdate";
				meta.spDelete = "proc_DrugbankproteinsequenceDelete";
				meta.spLoadAll = "proc_DrugbankproteinsequenceLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankproteinsequenceLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankproteinsequenceMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}
