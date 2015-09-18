
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
	[KnownType(typeof(Nodes))]
	[XmlType("Nodes")]
	public partial class Nodes : tgNodes
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Nodes();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgNodes : tgEntity
	{
		public tgNodes()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Nodes.TaxId
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? TaxId
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.TaxId);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.TaxId, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.TaxId);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.Parent
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? Parent
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.Parent);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.Parent, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.Parent);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.RankName
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string RankName
		{
			get
			{
				return base.GetSystemString(NodesMetadata.ColumnNames.RankName);
			}

			set
			{
				if (base.SetSystemString(NodesMetadata.ColumnNames.RankName, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.RankName);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.Embl
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Embl
		{
			get
			{
				return base.GetSystemString(NodesMetadata.ColumnNames.Embl);
			}

			set
			{
				if (base.SetSystemString(NodesMetadata.ColumnNames.Embl, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.Embl);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.Division
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? Division
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.Division);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.Division, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.Division);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.InheritedDivFlag
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? InheritedDivFlag
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.InheritedDivFlag);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.InheritedDivFlag, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.InheritedDivFlag);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.Genetic
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? Genetic
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.Genetic);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.Genetic, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.Genetic);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.InheritedGC
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? InheritedGC
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.InheritedGC);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.InheritedGC, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.InheritedGC);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.Mitochondrial
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? Mitochondrial
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.Mitochondrial);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.Mitochondrial, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.Mitochondrial);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.InheritedMGC
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? InheritedMGC
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.InheritedMGC);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.InheritedMGC, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.InheritedMGC);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.GenBank
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? GenBank
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.GenBank);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.GenBank, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.GenBank);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.Hidden
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? Hidden
		{
			get
			{
				return base.GetSystemInt32(NodesMetadata.ColumnNames.Hidden);
			}

			set
			{
				if (base.SetSystemInt32(NodesMetadata.ColumnNames.Hidden, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.Hidden);
				}
			}
		}

		/// <summary>
		/// Maps to Nodes.Comment
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Comment
		{
			get
			{
				return base.GetSystemString(NodesMetadata.ColumnNames.Comment);
			}

			set
			{
				if (base.SetSystemString(NodesMetadata.ColumnNames.Comment, value))
				{
					OnPropertyChanged(NodesMetadata.PropertyNames.Comment);
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
				return NodesMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public NodesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new NodesQuery("ar1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(NodesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(NodesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private NodesQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("NodesCollection")]
	public partial class NodesCollection : tgNodesCollection, IEnumerable<Nodes>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Nodes))]
		public class NodesCollectionWCFPacket : tgCollectionWCFPacket<NodesCollection>
		{
			public static implicit operator NodesCollection(NodesCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator NodesCollectionWCFPacket(NodesCollection collection)
			{
				return new NodesCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgNodesCollection : tgEntityCollection<Nodes>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return NodesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "NodesCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public NodesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new NodesQuery("aq1");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(NodesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new NodesQuery("at1");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(NodesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((NodesQuery)query);
		}

		#endregion

		private NodesQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class NodesQuery : tgNodesQuery
	{
		public NodesQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "NodesQuery";
		}

		#region Explicit Casts

		public static explicit operator string(NodesQuery query)
		{
			return NodesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator NodesQuery(string query)
		{
			return (NodesQuery)NodesQuery.SerializeHelper.FromXml(query, typeof(NodesQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgNodesQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return NodesMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "TaxId": return this.TaxId;
				case "Parent": return this.Parent;
				case "RankName": return this.RankName;
				case "Embl": return this.Embl;
				case "Division": return this.Division;
				case "InheritedDivFlag": return this.InheritedDivFlag;
				case "Genetic": return this.Genetic;
				case "InheritedGC": return this.InheritedGC;
				case "Mitochondrial": return this.Mitochondrial;
				case "InheritedMGC": return this.InheritedMGC;
				case "GenBank": return this.GenBank;
				case "Hidden": return this.Hidden;
				case "Comment": return this.Comment;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem TaxId
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.TaxId, tgSystemType.Int32); }
		}

		public tgQueryItem Parent
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.Parent, tgSystemType.Int32); }
		}

		public tgQueryItem RankName
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.RankName, tgSystemType.String); }
		}

		public tgQueryItem Embl
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.Embl, tgSystemType.String); }
		}

		public tgQueryItem Division
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.Division, tgSystemType.Int32); }
		}

		public tgQueryItem InheritedDivFlag
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.InheritedDivFlag, tgSystemType.Int32); }
		}

		public tgQueryItem Genetic
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.Genetic, tgSystemType.Int32); }
		}

		public tgQueryItem InheritedGC
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.InheritedGC, tgSystemType.Int32); }
		}

		public tgQueryItem Mitochondrial
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.Mitochondrial, tgSystemType.Int32); }
		}

		public tgQueryItem InheritedMGC
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.InheritedMGC, tgSystemType.Int32); }
		}

		public tgQueryItem GenBank
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.GenBank, tgSystemType.Int32); }
		}

		public tgQueryItem Hidden
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.Hidden, tgSystemType.Int32); }
		}

		public tgQueryItem Comment
		{
			get { return new tgQueryItem(this, NodesMetadata.ColumnNames.Comment, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class NodesMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected NodesMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.TaxId, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.TaxId;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.Parent, 1, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.Parent;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.RankName, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = NodesMetadata.PropertyNames.RankName;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.Embl, 3, typeof(System.String), tgSystemType.String);
			c.PropertyName = NodesMetadata.PropertyNames.Embl;
			c.IsNullable = true;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.Division, 4, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.Division;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.InheritedDivFlag, 5, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.InheritedDivFlag;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.Genetic, 6, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.Genetic;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.InheritedGC, 7, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.InheritedGC;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.Mitochondrial, 8, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.Mitochondrial;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.InheritedMGC, 9, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.InheritedMGC;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.GenBank, 10, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.GenBank;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.Hidden, 11, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = NodesMetadata.PropertyNames.Hidden;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(NodesMetadata.ColumnNames.Comment, 12, typeof(System.String), tgSystemType.String);
			c.PropertyName = NodesMetadata.PropertyNames.Comment;
			c.IsNullable = true;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
		}
		#endregion

		static public NodesMetadata Meta()
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
			public const string TaxId = "tax_id";
			public const string Parent = "parent";
			public const string RankName = "rank_name";
			public const string Embl = "embl";
			public const string Division = "division";
			public const string InheritedDivFlag = "inherited_div_flag";
			public const string Genetic = "genetic";
			public const string InheritedGC = "inherited_GC";
			public const string Mitochondrial = "mitochondrial";
			public const string InheritedMGC = "inherited_MGC";
			public const string GenBank = "GenBank";
			public const string Hidden = "hidden";
			public const string Comment = "Comment";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string TaxId = "TaxId";
			public const string Parent = "Parent";
			public const string RankName = "RankName";
			public const string Embl = "Embl";
			public const string Division = "Division";
			public const string InheritedDivFlag = "InheritedDivFlag";
			public const string Genetic = "Genetic";
			public const string InheritedGC = "InheritedGC";
			public const string Mitochondrial = "Mitochondrial";
			public const string InheritedMGC = "InheritedMGC";
			public const string GenBank = "GenBank";
			public const string Hidden = "Hidden";
			public const string Comment = "Comment";
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
			lock (typeof(NodesMetadata))
			{
				if (NodesMetadata.mapDelegates == null)
				{
					NodesMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (NodesMetadata.meta == null)
				{
					NodesMetadata.meta = new NodesMetadata();
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


				meta.AddTypeMap("TaxId", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Parent", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("RankName", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Embl", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Division", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("InheritedDivFlag", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Genetic", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("InheritedGC", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Mitochondrial", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("InheritedMGC", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("GenBank", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Hidden", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Comment", new tgTypeMap("text", "System.String"));

				meta.Source = "nodes";
				meta.Destination = "nodes";

				meta.spInsert = "proc_NodesInsert";
				meta.spUpdate = "proc_NodesUpdate";
				meta.spDelete = "proc_NodesDelete";
				meta.spLoadAll = "proc_NodesLoadAll";
				meta.spLoadByPrimaryKey = "proc_NodesLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private NodesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

