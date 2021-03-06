
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
	[KnownType(typeof(Drugbankaffectedorganism))]
	[XmlType("Drugbankaffectedorganism")]
	public partial class Drugbankaffectedorganism : tgDrugbankaffectedorganism
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Drugbankaffectedorganism();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDrugbankaffectedorganism : tgEntity
	{
		public tgDrugbankaffectedorganism()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Drugbankaffectedorganism.DrugbankWid
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? DrugbankWid
		{
			get
			{
				return base.GetSystemInt32(DrugbankaffectedorganismMetadata.ColumnNames.DrugbankWid);
			}

			set
			{
				if (base.SetSystemInt32(DrugbankaffectedorganismMetadata.ColumnNames.DrugbankWid, value))
				{
					OnPropertyChanged(DrugbankaffectedorganismMetadata.PropertyNames.DrugbankWid);
				}
			}
		}

		/// <summary>
		/// Maps to Drugbankaffectedorganism.AffectedOrganisms
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string AffectedOrganisms
		{
			get
			{
				return base.GetSystemString(DrugbankaffectedorganismMetadata.ColumnNames.AffectedOrganisms);
			}

			set
			{
				if (base.SetSystemString(DrugbankaffectedorganismMetadata.ColumnNames.AffectedOrganisms, value))
				{
					OnPropertyChanged(DrugbankaffectedorganismMetadata.PropertyNames.AffectedOrganisms);
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
				return DrugbankaffectedorganismMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DrugbankaffectedorganismQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankaffectedorganismQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankaffectedorganismQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DrugbankaffectedorganismQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DrugbankaffectedorganismQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DrugbankaffectedorganismCollection")]
	public partial class DrugbankaffectedorganismCollection : tgDrugbankaffectedorganismCollection, IEnumerable<Drugbankaffectedorganism>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Drugbankaffectedorganism))]
		public class DrugbankaffectedorganismCollectionWCFPacket : tgCollectionWCFPacket<DrugbankaffectedorganismCollection>
		{
			public static implicit operator DrugbankaffectedorganismCollection(DrugbankaffectedorganismCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DrugbankaffectedorganismCollectionWCFPacket(DrugbankaffectedorganismCollection collection)
			{
				return new DrugbankaffectedorganismCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDrugbankaffectedorganismCollection : tgEntityCollection<Drugbankaffectedorganism>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankaffectedorganismMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DrugbankaffectedorganismCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DrugbankaffectedorganismQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DrugbankaffectedorganismQuery("");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DrugbankaffectedorganismQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DrugbankaffectedorganismQuery("");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DrugbankaffectedorganismQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DrugbankaffectedorganismQuery)query);
		}

		#endregion

		private DrugbankaffectedorganismQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DrugbankaffectedorganismQuery : tgDrugbankaffectedorganismQuery
	{
		public DrugbankaffectedorganismQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DrugbankaffectedorganismQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DrugbankaffectedorganismQuery query)
		{
			return DrugbankaffectedorganismQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DrugbankaffectedorganismQuery(string query)
		{
			return (DrugbankaffectedorganismQuery)DrugbankaffectedorganismQuery.SerializeHelper.FromXml(query, typeof(DrugbankaffectedorganismQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDrugbankaffectedorganismQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DrugbankaffectedorganismMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "DrugbankWid": return this.DrugbankWid;
				case "AffectedOrganisms": return this.AffectedOrganisms;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem DrugbankWid
		{
			get { return new tgQueryItem(this, DrugbankaffectedorganismMetadata.ColumnNames.DrugbankWid, tgSystemType.Int32); }		
		}

		public tgQueryItem AffectedOrganisms
		{
			get { return new tgQueryItem(this, DrugbankaffectedorganismMetadata.ColumnNames.AffectedOrganisms, tgSystemType.String); }		
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DrugbankaffectedorganismMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DrugbankaffectedorganismMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DrugbankaffectedorganismMetadata.ColumnNames.DrugbankWid, 0, typeof(System.Int32), tgSystemType.Int32);			
			c.PropertyName = DrugbankaffectedorganismMetadata.PropertyNames.DrugbankWid;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(DrugbankaffectedorganismMetadata.ColumnNames.AffectedOrganisms, 1, typeof(System.String), tgSystemType.String);			
			c.PropertyName = DrugbankaffectedorganismMetadata.PropertyNames.AffectedOrganisms;
			c.IsNullable = true;
			m_columns.Add(c);
		}
		#endregion

		static public DrugbankaffectedorganismMetadata Meta()
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
			public const string AffectedOrganisms = "AffectedOrganisms";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string DrugbankWid = "DrugbankWid";
			public const string AffectedOrganisms = "AffectedOrganisms";
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
			lock (typeof(DrugbankaffectedorganismMetadata))
			{
				if (DrugbankaffectedorganismMetadata.mapDelegates == null)
				{
					DrugbankaffectedorganismMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DrugbankaffectedorganismMetadata.meta == null)
				{
					DrugbankaffectedorganismMetadata.meta = new DrugbankaffectedorganismMetadata();
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
				meta.AddTypeMap("AffectedOrganisms", new tgTypeMap("text", "System.String"));

				meta.Source = "drugbankaffectedorganism";
				meta.Destination = "drugbankaffectedorganism";

				meta.spInsert = "proc_DrugbankaffectedorganismInsert";
				meta.spUpdate = "proc_DrugbankaffectedorganismUpdate";
				meta.spDelete = "proc_DrugbankaffectedorganismDelete";
				meta.spLoadAll = "proc_DrugbankaffectedorganismLoadAll";
				meta.spLoadByPrimaryKey = "proc_DrugbankaffectedorganismLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DrugbankaffectedorganismMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

