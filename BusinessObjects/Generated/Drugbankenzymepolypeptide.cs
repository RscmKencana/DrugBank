
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
	[KnownType(typeof(Drugbankenzymepolypeptide))]
	[XmlType("Drugbankenzymepolypeptide")]
	public partial class Drugbankenzymepolypeptide : tgDrugbankenzymepolypeptide
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankenzymepolypeptide();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbankenzymepolypeptide : tgEntity
	{
		public tgDrugbankenzymepolypeptide()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbankenzymepolypeptide.DrugBankEnzymeWID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugBankEnzymeWID
		{
			get
			{
				return base.GetSystemInt32(DrugbankenzymepolypeptideMetadata.ColumnNames.DrugBankEnzymeWID);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankenzymepolypeptideMetadata.ColumnNames.DrugBankEnzymeWID, value))
				{
					OnPropertyChanged(DrugbankenzymepolypeptideMetadata.PropertyNames.DrugBankEnzymeWID);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankenzymepolypeptide.Id
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Id
		{
			get
			{
				return base.GetSystemString(DrugbankenzymepolypeptideMetadata.ColumnNames.Id);
			}

			set
			{
				if (base.SetSystemString(DrugbankenzymepolypeptideMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(DrugbankenzymepolypeptideMetadata.PropertyNames.Id);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankenzymepolypeptide.Name
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Name
		{
			get
			{
				return base.GetSystemString(DrugbankenzymepolypeptideMetadata.ColumnNames.Name);
			}

			set
			{
				if (base.SetSystemString(DrugbankenzymepolypeptideMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(DrugbankenzymepolypeptideMetadata.PropertyNames.Name);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankenzymepolypeptide.Source
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Source
		{
			get
			{
				return base.GetSystemString(DrugbankenzymepolypeptideMetadata.ColumnNames.Source);
			}

			set
			{
				if (base.SetSystemString(DrugbankenzymepolypeptideMetadata.ColumnNames.Source, value))
				{
					OnPropertyChanged(DrugbankenzymepolypeptideMetadata.PropertyNames.Source);
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
				return DrugbankenzymepolypeptideMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankenzymepolypeptideQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankenzymepolypeptideQuery("a5");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankenzymepolypeptideQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankenzymepolypeptideQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankenzymepolypeptideQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankenzymepolypeptideCollection")]
	public partial class DrugbankenzymepolypeptideCollection : tgDrugbankenzymepolypeptideCollection, IEnumerable<Drugbankenzymepolypeptide>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankenzymepolypeptide))]
		public class DrugbankenzymepolypeptideCollectionWCFPacket : tgCollectionWCFPacket<DrugbankenzymepolypeptideCollection>
		{
			public static implicit operator DrugbankenzymepolypeptideCollection(DrugbankenzymepolypeptideCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankenzymepolypeptideCollectionWCFPacket(DrugbankenzymepolypeptideCollection collection)
			{
				return new DrugbankenzymepolypeptideCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankenzymepolypeptideCollection : tgEntityCollection<Drugbankenzymepolypeptide>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankenzymepolypeptideMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankenzymepolypeptideCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankenzymepolypeptideQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankenzymepolypeptideQuery("b5");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankenzymepolypeptideQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankenzymepolypeptideQuery("c5");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankenzymepolypeptideQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankenzymepolypeptideQuery)query);
		}

		#endregion

		private DrugbankenzymepolypeptideQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankenzymepolypeptideQuery : tgDrugbankenzymepolypeptideQuery
	{
		public DrugbankenzymepolypeptideQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankenzymepolypeptideQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankenzymepolypeptideQuery query)
		{
			return DrugbankenzymepolypeptideQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankenzymepolypeptideQuery(string query)
		{
			return (DrugbankenzymepolypeptideQuery)DrugbankenzymepolypeptideQuery.SerializeHelper.FromXml(query, typeof(DrugbankenzymepolypeptideQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankenzymepolypeptideQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankenzymepolypeptideMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugBankEnzymeWID": return this.DrugBankEnzymeWID;
				case "Id": return this.Id;
				case "Name": return this.Name;
				case "Source": return this.Source;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugBankEnzymeWID
		{
			get { return new tgQueryItem(this, DrugbankenzymepolypeptideMetadata.ColumnNames.DrugBankEnzymeWID, tgSystemType.Int32); }
		}

		public tgQueryItem Id
		{
			get { return new tgQueryItem(this, DrugbankenzymepolypeptideMetadata.ColumnNames.Id, tgSystemType.String); }
		}

		public tgQueryItem Name
		{
			get { return new tgQueryItem(this, DrugbankenzymepolypeptideMetadata.ColumnNames.Name, tgSystemType.String); }
		}

		public tgQueryItem Source
		{
			get { return new tgQueryItem(this, DrugbankenzymepolypeptideMetadata.ColumnNames.Source, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankenzymepolypeptideMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankenzymepolypeptideMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankenzymepolypeptideMetadata.ColumnNames.DrugBankEnzymeWID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DrugbankenzymepolypeptideMetadata.PropertyNames.DrugBankEnzymeWID;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankenzymepolypeptideMetadata.ColumnNames.Id, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankenzymepolypeptideMetadata.PropertyNames.Id;
			c.CharacterMaxLength = 25;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankenzymepolypeptideMetadata.ColumnNames.Name, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankenzymepolypeptideMetadata.PropertyNames.Name;
			c.IsNullable = true;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankenzymepolypeptideMetadata.ColumnNames.Source, 3, typeof(System.String), tgSystemType.String);
			c.PropertyName = DrugbankenzymepolypeptideMetadata.PropertyNames.Source;
			c.IsNullable = true;
			c.CharacterMaxLength = 45;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankenzymepolypeptideMetadata Meta()
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
			public const string DrugBankEnzymeWID = "DrugBankEnzyme_WID";
			public const string Id = "Id";
			public const string Name = "Name";
			public const string Source = "Source";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugBankEnzymeWID = "DrugBankEnzymeWID";
			public const string Id = "Id";
			public const string Name = "Name";
			public const string Source = "Source";
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
			lock (typeof(DrugbankenzymepolypeptideMetadata))
			{
				if (DrugbankenzymepolypeptideMetadata.mapDelegates == null)
				{
					DrugbankenzymepolypeptideMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankenzymepolypeptideMetadata.meta == null)
				{
					DrugbankenzymepolypeptideMetadata.meta = new DrugbankenzymepolypeptideMetadata();
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


				meta.AddTypeMap("DrugBankEnzymeWID", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Id", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Name", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Source", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankenzymepolypeptide";
				meta.Destination = "drugbankenzymepolypeptide";

				meta.spInsert = "proc_DrugbankenzymepolypeptideInsert";
				meta.spUpdate = "proc_DrugbankenzymepolypeptideUpdate";
				meta.spDelete = "proc_DrugbankenzymepolypeptideDelete";
				meta.spLoadAll = "proc_DrugbankenzymepolypeptideLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankenzymepolypeptideLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankenzymepolypeptideMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

