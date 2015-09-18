
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
	[KnownType(typeof(Drugbanktransporteraction))]
	[XmlType("Drugbanktransporteraction")]
	public partial class Drugbanktransporteraction : tgDrugbanktransporteraction
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbanktransporteraction();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbanktransporteraction : tgEntity
	{
		public tgDrugbanktransporteraction()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbanktransporteraction.DrugBankTransporterWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankTransporterWID
		{
			get
			{
				return base.GetSystemInt32(DrugbanktransporteractionMetadata.ColumnNames.DrugBankTransporterWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbanktransporteractionMetadata.ColumnNames.DrugBankTransporterWID, value))
				{
					OnPropertyChanged(DrugbanktransporteractionMetadata.PropertyNames.DrugBankTransporterWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktransporteraction.Action
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Action
		{
			get
			{
				return base.GetSystemString(DrugbanktransporteractionMetadata.ColumnNames.Action);
			}

			set
			{
				if (base.SetSystemString(DrugbanktransporteractionMetadata.ColumnNames.Action, value))
				{
					OnPropertyChanged(DrugbanktransporteractionMetadata.PropertyNames.Action);
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
				return DrugbanktransporteractionMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbanktransporteractionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktransporteractionQuery("ab1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktransporteractionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbanktransporteractionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbanktransporteractionQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbanktransporteractionCollection")]
	public partial class DrugbanktransporteractionCollection : tgDrugbanktransporteractionCollection, IEnumerable<Drugbanktransporteraction>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbanktransporteraction))]
		public class DrugbanktransporteractionCollectionWCFPacket : tgCollectionWCFPacket<DrugbanktransporteractionCollection>
		{
			public static implicit operator DrugbanktransporteractionCollection(DrugbanktransporteractionCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbanktransporteractionCollectionWCFPacket(DrugbanktransporteractionCollection collection)
			{
				return new DrugbanktransporteractionCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbanktransporteractionCollection : tgEntityCollection<Drugbanktransporteraction>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktransporteractionMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbanktransporteractionCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbanktransporteractionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktransporteractionQuery("ac1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktransporteractionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbanktransporteractionQuery("ad1");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbanktransporteractionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbanktransporteractionQuery)query);
		}

		#endregion

		private DrugbanktransporteractionQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbanktransporteractionQuery : tgDrugbanktransporteractionQuery
	{
		public DrugbanktransporteractionQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbanktransporteractionQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbanktransporteractionQuery query)
		{
			return DrugbanktransporteractionQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbanktransporteractionQuery(string query)
		{
			return (DrugbanktransporteractionQuery)DrugbanktransporteractionQuery.SerializeHelper.FromXml(query, typeof(DrugbanktransporteractionQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbanktransporteractionQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktransporteractionMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugBankTransporterWID": return this.DrugBankTransporterWID;
				case "Action": return this.Action;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugBankTransporterWID
		{
			get { return new tgQueryItem(this, DrugbanktransporteractionMetadata.ColumnNames.DrugBankTransporterWID, tgSystemType.Int32); }
		}

		public tgQueryItem Action
		{
			get { return new tgQueryItem(this, DrugbanktransporteractionMetadata.ColumnNames.Action, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbanktransporteractionMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbanktransporteractionMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbanktransporteractionMetadata.ColumnNames.DrugBankTransporterWID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbanktransporteractionMetadata.PropertyNames.DrugBankTransporterWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktransporteractionMetadata.ColumnNames.Action, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbanktransporteractionMetadata.PropertyNames.Action;
			c.IsNullable = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbanktransporteractionMetadata Meta()
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
			public const string Action = "Action";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugBankTransporterWID = "DrugBankTransporterWID";
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
			lock (typeof(DrugbanktransporteractionMetadata))
			{
				if (DrugbanktransporteractionMetadata.mapDelegates == null)
				{
					DrugbanktransporteractionMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbanktransporteractionMetadata.meta == null)
				{
					DrugbanktransporteractionMetadata.meta = new DrugbanktransporteractionMetadata();
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
				meta.AddTypeMap("Action", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbanktransporteraction";
				meta.Destination = "drugbanktransporteraction";

				meta.spInsert = "proc_DrugbanktransporteractionInsert";
				meta.spUpdate = "proc_DrugbanktransporteractionUpdate";
				meta.spDelete = "proc_DrugbanktransporteractionDelete";
				meta.spLoadAll = "proc_DrugbanktransporteractionLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbanktransporteractionLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbanktransporteractionMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}
