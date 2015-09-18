
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
	[KnownType(typeof(Drugbankcarrieraction))]
	[XmlType("Drugbankcarrieraction")]
	public partial class Drugbankcarrieraction : tgDrugbankcarrieraction
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankcarrieraction();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbankcarrieraction : tgEntity
	{
		public tgDrugbankcarrieraction()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbankcarrieraction.DrugBankCarrierWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankCarrierWID
		{
			get
			{
				return base.GetSystemInt32(DrugbankcarrieractionMetadata.ColumnNames.DrugBankCarrierWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankcarrieractionMetadata.ColumnNames.DrugBankCarrierWID, value))
				{
					OnPropertyChanged(DrugbankcarrieractionMetadata.PropertyNames.DrugBankCarrierWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankcarrieraction.Action
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Action
		{
			get
			{
				return base.GetSystemString(DrugbankcarrieractionMetadata.ColumnNames.Action);
			}

			set
			{
				if (base.SetSystemString(DrugbankcarrieractionMetadata.ColumnNames.Action, value))
				{
					OnPropertyChanged(DrugbankcarrieractionMetadata.PropertyNames.Action);
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
				return DrugbankcarrieractionMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankcarrieractionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankcarrieractionQuery("u3");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankcarrieractionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankcarrieractionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankcarrieractionQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankcarrieractionCollection")]
	public partial class DrugbankcarrieractionCollection : tgDrugbankcarrieractionCollection, IEnumerable<Drugbankcarrieraction>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankcarrieraction))]
		public class DrugbankcarrieractionCollectionWCFPacket : tgCollectionWCFPacket<DrugbankcarrieractionCollection>
		{
			public static implicit operator DrugbankcarrieractionCollection(DrugbankcarrieractionCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankcarrieractionCollectionWCFPacket(DrugbankcarrieractionCollection collection)
			{
				return new DrugbankcarrieractionCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankcarrieractionCollection : tgEntityCollection<Drugbankcarrieraction>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankcarrieractionMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankcarrieractionCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankcarrieractionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankcarrieractionQuery("v3");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankcarrieractionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankcarrieractionQuery("w3");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankcarrieractionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankcarrieractionQuery)query);
		}

		#endregion

		private DrugbankcarrieractionQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankcarrieractionQuery : tgDrugbankcarrieractionQuery
	{
		public DrugbankcarrieractionQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankcarrieractionQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankcarrieractionQuery query)
		{
			return DrugbankcarrieractionQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankcarrieractionQuery(string query)
		{
			return (DrugbankcarrieractionQuery)DrugbankcarrieractionQuery.SerializeHelper.FromXml(query, typeof(DrugbankcarrieractionQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankcarrieractionQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankcarrieractionMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugBankCarrierWID": return this.DrugBankCarrierWID;
				case "Action": return this.Action;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugBankCarrierWID
		{
			get { return new tgQueryItem(this, DrugbankcarrieractionMetadata.ColumnNames.DrugBankCarrierWID, tgSystemType.Int32); }
		}

		public tgQueryItem Action
		{
			get { return new tgQueryItem(this, DrugbankcarrieractionMetadata.ColumnNames.Action, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankcarrieractionMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankcarrieractionMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankcarrieractionMetadata.ColumnNames.DrugBankCarrierWID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbankcarrieractionMetadata.PropertyNames.DrugBankCarrierWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankcarrieractionMetadata.ColumnNames.Action, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankcarrieractionMetadata.PropertyNames.Action;
			c.IsNullable = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankcarrieractionMetadata Meta()
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
			public const string DrugBankCarrierWID = "DrugBankCarrier_WID";
			public const string Action = "Action";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugBankCarrierWID = "DrugBankCarrierWID";
			public const string Action = "Action";
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
			lock (typeof(DrugbankcarrieractionMetadata))
			{
				if (DrugbankcarrieractionMetadata.mapDelegates == null)
				{
					DrugbankcarrieractionMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankcarrieractionMetadata.meta == null)
				{
					DrugbankcarrieractionMetadata.meta = new DrugbankcarrieractionMetadata();
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


				meta.AddTypeMap("DrugBankCarrierWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Action", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankcarrieraction";
				meta.Destination = "drugbankcarrieraction";

				meta.spInsert = "proc_DrugbankcarrieractionInsert";
				meta.spUpdate = "proc_DrugbankcarrieractionUpdate";
				meta.spDelete = "proc_DrugbankcarrieractionDelete";
				meta.spLoadAll = "proc_DrugbankcarrieractionLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankcarrieractionLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankcarrieractionMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

