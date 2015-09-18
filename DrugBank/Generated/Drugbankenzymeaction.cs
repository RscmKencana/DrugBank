
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
	[KnownType(typeof(Drugbankenzymeaction))]
	[XmlType("Drugbankenzymeaction")]
	public partial class Drugbankenzymeaction : tgDrugbankenzymeaction
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankenzymeaction();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbankenzymeaction : tgEntity
	{
		public tgDrugbankenzymeaction()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbankenzymeaction.DrugbankenzymeWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankenzymeWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankenzymeactionMetadata.ColumnNames.DrugbankenzymeWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankenzymeactionMetadata.ColumnNames.DrugbankenzymeWid, value))
				{
					OnPropertyChanged(DrugbankenzymeactionMetadata.PropertyNames.DrugbankenzymeWid);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankenzymeaction.Action
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Action
		{
			get
			{
				return base.GetSystemString(DrugbankenzymeactionMetadata.ColumnNames.Action);
			}

			set
			{
				if (base.SetSystemString(DrugbankenzymeactionMetadata.ColumnNames.Action, value))
				{
					OnPropertyChanged(DrugbankenzymeactionMetadata.PropertyNames.Action);
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
				return DrugbankenzymeactionMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankenzymeactionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankenzymeactionQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankenzymeactionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankenzymeactionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankenzymeactionQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankenzymeactionCollection")]
	public partial class DrugbankenzymeactionCollection : tgDrugbankenzymeactionCollection, IEnumerable<Drugbankenzymeaction>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankenzymeaction))]
		public class DrugbankenzymeactionCollectionWCFPacket : tgCollectionWCFPacket<DrugbankenzymeactionCollection>
		{
			public static implicit operator DrugbankenzymeactionCollection(DrugbankenzymeactionCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankenzymeactionCollectionWCFPacket(DrugbankenzymeactionCollection collection)
			{
				return new DrugbankenzymeactionCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankenzymeactionCollection : tgEntityCollection<Drugbankenzymeaction>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankenzymeactionMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankenzymeactionCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankenzymeactionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankenzymeactionQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankenzymeactionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankenzymeactionQuery("");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankenzymeactionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankenzymeactionQuery)query);
		}

		#endregion

		private DrugbankenzymeactionQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankenzymeactionQuery : tgDrugbankenzymeactionQuery
	{
		public DrugbankenzymeactionQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankenzymeactionQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankenzymeactionQuery query)
		{
			return DrugbankenzymeactionQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankenzymeactionQuery(string query)
		{
			return (DrugbankenzymeactionQuery)DrugbankenzymeactionQuery.SerializeHelper.FromXml(query, typeof(DrugbankenzymeactionQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankenzymeactionQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankenzymeactionMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugbankenzymeWid": return this.DrugbankenzymeWid;
				case "Action": return this.Action;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugbankenzymeWid
		{
			get { return new tgQueryItem(this, DrugbankenzymeactionMetadata.ColumnNames.DrugbankenzymeWid, tgSystemType.Int32); }		
		}

		public tgQueryItem Action
		{
			get { return new tgQueryItem(this, DrugbankenzymeactionMetadata.ColumnNames.Action, tgSystemType.String); }		
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankenzymeactionMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankenzymeactionMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankenzymeactionMetadata.ColumnNames.DrugbankenzymeWid, 0, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankenzymeactionMetadata.PropertyNames.DrugbankenzymeWid;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankenzymeactionMetadata.ColumnNames.Action, 1, typeof(System.String), tgSystemType.String);			
			c.PropertyName = DrugbankenzymeactionMetadata.PropertyNames.Action;
			c.IsNullable = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankenzymeactionMetadata Meta()
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
			public const string DrugbankenzymeWid = "DrugBankEnzyme_WID";
			public const string Action = "Action";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugbankenzymeWid = "DrugbankenzymeWid";
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
			lock (typeof(DrugbankenzymeactionMetadata))
			{
				if (DrugbankenzymeactionMetadata.mapDelegates == null)
				{
					DrugbankenzymeactionMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankenzymeactionMetadata.meta == null)
				{
					DrugbankenzymeactionMetadata.meta = new DrugbankenzymeactionMetadata();
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


				meta.AddTypeMap("DrugbankenzymeWid", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Action", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankenzymeaction";
				meta.Destination = "drugbankenzymeaction";

				meta.spInsert = "proc_DrugbankenzymeactionInsert";
				meta.spUpdate = "proc_DrugbankenzymeactionUpdate";
				meta.spDelete = "proc_DrugbankenzymeactionDelete";
				meta.spLoadAll = "proc_DrugbankenzymeactionLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankenzymeactionLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankenzymeactionMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}
