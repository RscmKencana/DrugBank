
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
	[KnownType(typeof(Drugbankgroup))]
	[XmlType("Drugbankgroup")]
	public partial class Drugbankgroup : tgDrugbankgroup
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankgroup();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbankgroup : tgEntity
	{
		public tgDrugbankgroup()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbankgroup.DrugbankWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankgroupMetadata.ColumnNames.DrugbankWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankgroupMetadata.ColumnNames.DrugbankWid, value))
				{
					OnPropertyChanged(DrugbankgroupMetadata.PropertyNames.DrugbankWid);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankgroup.GroupName
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string GroupName
		{
			get
			{
				return base.GetSystemString(DrugbankgroupMetadata.ColumnNames.GroupName);
			}

			set
			{
				if (base.SetSystemString(DrugbankgroupMetadata.ColumnNames.GroupName, value))
				{
					OnPropertyChanged(DrugbankgroupMetadata.PropertyNames.GroupName);
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
				return DrugbankgroupMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankgroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankgroupQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankgroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankgroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankgroupQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankgroupCollection")]
	public partial class DrugbankgroupCollection : tgDrugbankgroupCollection, IEnumerable<Drugbankgroup>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankgroup))]
		public class DrugbankgroupCollectionWCFPacket : tgCollectionWCFPacket<DrugbankgroupCollection>
		{
			public static implicit operator DrugbankgroupCollection(DrugbankgroupCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankgroupCollectionWCFPacket(DrugbankgroupCollection collection)
			{
				return new DrugbankgroupCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankgroupCollection : tgEntityCollection<Drugbankgroup>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankgroupMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankgroupCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankgroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankgroupQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankgroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankgroupQuery("");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankgroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankgroupQuery)query);
		}

		#endregion

		private DrugbankgroupQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankgroupQuery : tgDrugbankgroupQuery
	{
		public DrugbankgroupQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankgroupQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankgroupQuery query)
		{
			return DrugbankgroupQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankgroupQuery(string query)
		{
			return (DrugbankgroupQuery)DrugbankgroupQuery.SerializeHelper.FromXml(query, typeof(DrugbankgroupQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankgroupQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankgroupMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugbankWid": return this.DrugbankWid;
				case "GroupName": return this.GroupName;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugbankWid
		{
			get { return new tgQueryItem(this, DrugbankgroupMetadata.ColumnNames.DrugbankWid, tgSystemType.Int32); }		
		}

		public tgQueryItem GroupName
		{
			get { return new tgQueryItem(this, DrugbankgroupMetadata.ColumnNames.GroupName, tgSystemType.String); }		
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankgroupMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankgroupMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankgroupMetadata.ColumnNames.DrugbankWid, 0, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankgroupMetadata.PropertyNames.DrugbankWid;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankgroupMetadata.ColumnNames.GroupName, 1, typeof(System.String), tgSystemType.String);			
			c.PropertyName = DrugbankgroupMetadata.PropertyNames.GroupName;
			c.IsNullable = true;
			c.CharacterMaxLength = 25;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankgroupMetadata Meta()
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
			public const string GroupName = "GroupName";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugbankWid = "DrugbankWid";
			public const string GroupName = "GroupName";
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
			lock (typeof(DrugbankgroupMetadata))
			{
				if (DrugbankgroupMetadata.mapDelegates == null)
				{
					DrugbankgroupMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankgroupMetadata.meta == null)
				{
					DrugbankgroupMetadata.meta = new DrugbankgroupMetadata();
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
				meta.AddTypeMap("GroupName", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankgroup";
				meta.Destination = "drugbankgroup";

				meta.spInsert = "proc_DrugbankgroupInsert";
				meta.spUpdate = "proc_DrugbankgroupUpdate";
				meta.spDelete = "proc_DrugbankgroupDelete";
				meta.spLoadAll = "proc_DrugbankgroupLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankgroupLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankgroupMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

