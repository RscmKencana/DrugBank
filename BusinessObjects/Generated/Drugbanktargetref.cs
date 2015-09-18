
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
	[KnownType(typeof(Drugbanktargetref))]
	[XmlType("Drugbanktargetref")]
	public partial class Drugbanktargetref : tgDrugbanktargetref
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbanktargetref();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbanktargetref : tgEntity
	{
		public tgDrugbanktargetref()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbanktargetref.DrugBankTargetWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankTargetWID
		{
			get
			{
				return base.GetSystemInt32(DrugbanktargetrefMetadata.ColumnNames.DrugBankTargetWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbanktargetrefMetadata.ColumnNames.DrugBankTargetWID, value))
				{
					OnPropertyChanged(DrugbanktargetrefMetadata.PropertyNames.DrugBankTargetWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktargetref.Cite
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Cite
		{
			get
			{
				return base.GetSystemString(DrugbanktargetrefMetadata.ColumnNames.Cite);
			}

			set
			{
				if (base.SetSystemString(DrugbanktargetrefMetadata.ColumnNames.Cite, value))
				{
					OnPropertyChanged(DrugbanktargetrefMetadata.PropertyNames.Cite);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbanktargetref.Link
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Link
		{
			get
			{
				return base.GetSystemString(DrugbanktargetrefMetadata.ColumnNames.Link);
			}

			set
			{
				if (base.SetSystemString(DrugbanktargetrefMetadata.ColumnNames.Link, value))
				{
					OnPropertyChanged(DrugbanktargetrefMetadata.PropertyNames.Link);
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
				return DrugbanktargetrefMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbanktargetrefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktargetrefQuery("d9");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktargetrefQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbanktargetrefQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbanktargetrefQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbanktargetrefCollection")]
	public partial class DrugbanktargetrefCollection : tgDrugbanktargetrefCollection, IEnumerable<Drugbanktargetref>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbanktargetref))]
		public class DrugbanktargetrefCollectionWCFPacket : tgCollectionWCFPacket<DrugbanktargetrefCollection>
		{
			public static implicit operator DrugbanktargetrefCollection(DrugbanktargetrefCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbanktargetrefCollectionWCFPacket(DrugbanktargetrefCollection collection)
			{
				return new DrugbanktargetrefCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbanktargetrefCollection : tgEntityCollection<Drugbanktargetref>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktargetrefMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbanktargetrefCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbanktargetrefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbanktargetrefQuery("d9");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbanktargetrefQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbanktargetrefQuery("d9");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbanktargetrefQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbanktargetrefQuery)query);
		}

		#endregion

		private DrugbanktargetrefQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbanktargetrefQuery : tgDrugbanktargetrefQuery
	{
		public DrugbanktargetrefQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbanktargetrefQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbanktargetrefQuery query)
		{
			return DrugbanktargetrefQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbanktargetrefQuery(string query)
		{
			return (DrugbanktargetrefQuery)DrugbanktargetrefQuery.SerializeHelper.FromXml(query, typeof(DrugbanktargetrefQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbanktargetrefQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbanktargetrefMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugBankTargetWID": return this.DrugBankTargetWID;
				case "Cite": return this.Cite;
				case "Link": return this.Link;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugBankTargetWID
		{
			get { return new tgQueryItem(this, DrugbanktargetrefMetadata.ColumnNames.DrugBankTargetWID, tgSystemType.Int32); }
		}

		public tgQueryItem Cite
		{
			get { return new tgQueryItem(this, DrugbanktargetrefMetadata.ColumnNames.Cite, tgSystemType.String); }
		}

		public tgQueryItem Link
		{
			get { return new tgQueryItem(this, DrugbanktargetrefMetadata.ColumnNames.Link, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbanktargetrefMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbanktargetrefMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbanktargetrefMetadata.ColumnNames.DrugBankTargetWID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbanktargetrefMetadata.PropertyNames.DrugBankTargetWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktargetrefMetadata.ColumnNames.Cite, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbanktargetrefMetadata.PropertyNames.Cite;
			c.IsNullable = true;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbanktargetrefMetadata.ColumnNames.Link, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbanktargetrefMetadata.PropertyNames.Link;
			c.IsNullable = true;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbanktargetrefMetadata Meta()
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
			public const string DrugBankTargetWID = "DrugBankTarget_WID";
			public const string Cite = "Cite";
			public const string Link = "Link";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugBankTargetWID = "DrugBankTargetWID";
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
			lock (typeof(DrugbanktargetrefMetadata))
			{
				if (DrugbanktargetrefMetadata.mapDelegates == null)
				{
					DrugbanktargetrefMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbanktargetrefMetadata.meta == null)
				{
					DrugbanktargetrefMetadata.meta = new DrugbanktargetrefMetadata();
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


				meta.AddTypeMap("DrugBankTargetWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Cite", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Link", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbanktargetref";
				meta.Destination = "drugbanktargetref";

				meta.spInsert = "proc_DrugbanktargetrefInsert";
				meta.spUpdate = "proc_DrugbanktargetrefUpdate";
				meta.spDelete = "proc_DrugbanktargetrefDelete";
				meta.spLoadAll = "proc_DrugbanktargetrefLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbanktargetrefLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbanktargetrefMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

