
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
	[KnownType(typeof(Divisiontemp))]
	[XmlType("Divisiontemp")]
	public partial class Divisiontemp : tgDivisiontemp
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Divisiontemp();
		}

	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgDivisiontemp : tgEntity
	{
		public tgDivisiontemp()
		{

		}


		#region Properties

		/// <summary>
		/// Maps to Divisiontemp.Id
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? Id
		{
			get
			{
				return base.GetSystemInt32(DivisiontempMetadata.ColumnNames.Id);
			}

			set
			{
				if (base.SetSystemInt32(DivisiontempMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(DivisiontempMetadata.PropertyNames.Id);
				}
			}
		}

		/// <summary>
		/// Maps to Divisiontemp.Code
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Code
		{
			get
			{
				return base.GetSystemString(DivisiontempMetadata.ColumnNames.Code);
			}

			set
			{
				if (base.SetSystemString(DivisiontempMetadata.ColumnNames.Code, value))
				{
					OnPropertyChanged(DivisiontempMetadata.PropertyNames.Code);
				}
			}
		}

		/// <summary>
		/// Maps to Divisiontemp.Name
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Name
		{
			get
			{
				return base.GetSystemString(DivisiontempMetadata.ColumnNames.Name);
			}

			set
			{
				if (base.SetSystemString(DivisiontempMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(DivisiontempMetadata.PropertyNames.Name);
				}
			}
		}

		/// <summary>
		/// Maps to Divisiontemp.Comment
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Comment
		{
			get
			{
				return base.GetSystemString(DivisiontempMetadata.ColumnNames.Comment);
			}

			set
			{
				if (base.SetSystemString(DivisiontempMetadata.ColumnNames.Comment, value))
				{
					OnPropertyChanged(DivisiontempMetadata.PropertyNames.Comment);
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
				return DivisiontempMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public DivisiontempQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DivisiontempQuery("t2");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DivisiontempQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(DivisiontempQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private DivisiontempQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("DivisiontempCollection")]
	public partial class DivisiontempCollection : tgDivisiontempCollection, IEnumerable<Divisiontemp>
	{

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Divisiontemp))]
		public class DivisiontempCollectionWCFPacket : tgCollectionWCFPacket<DivisiontempCollection>
		{
			public static implicit operator DivisiontempCollection(DivisiontempCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DivisiontempCollectionWCFPacket(DivisiontempCollection collection)
			{
				return new DivisiontempCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgDivisiontempCollection : tgEntityCollection<Divisiontemp>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DivisiontempMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DivisiontempCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public DivisiontempQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DivisiontempQuery("v2");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DivisiontempQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DivisiontempQuery("w2");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DivisiontempQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((DivisiontempQuery)query);
		}

		#endregion

		private DivisiontempQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	public partial class DivisiontempQuery : tgDivisiontempQuery
	{
		public DivisiontempQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "DivisiontempQuery";
		}

		#region Explicit Casts

		public static explicit operator string(DivisiontempQuery query)
		{
			return DivisiontempQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DivisiontempQuery(string query)
		{
			return (DivisiontempQuery)DivisiontempQuery.SerializeHelper.FromXml(query, typeof(DivisiontempQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	abstract public partial class tgDivisiontempQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DivisiontempMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "Id": return this.Id;
				case "Code": return this.Code;
				case "Name": return this.Name;
				case "Comment": return this.Comment;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem Id
		{
			get { return new tgQueryItem(this, DivisiontempMetadata.ColumnNames.Id, tgSystemType.Int32); }
		}

		public tgQueryItem Code
		{
			get { return new tgQueryItem(this, DivisiontempMetadata.ColumnNames.Code, tgSystemType.String); }
		}

		public tgQueryItem Name
		{
			get { return new tgQueryItem(this, DivisiontempMetadata.ColumnNames.Name, tgSystemType.String); }
		}

		public tgQueryItem Comment
		{
			get { return new tgQueryItem(this, DivisiontempMetadata.ColumnNames.Comment, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class DivisiontempMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected DivisiontempMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(DivisiontempMetadata.ColumnNames.Id, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = DivisiontempMetadata.PropertyNames.Id;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);

			c = new tgColumnMetadata(DivisiontempMetadata.ColumnNames.Code, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = DivisiontempMetadata.PropertyNames.Code;
			c.CharacterMaxLength = 4;
			m_columns.Add(c);

			c = new tgColumnMetadata(DivisiontempMetadata.ColumnNames.Name, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = DivisiontempMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 25;
			m_columns.Add(c);

			c = new tgColumnMetadata(DivisiontempMetadata.ColumnNames.Comment, 3, typeof(System.String), tgSystemType.String);
			c.PropertyName = DivisiontempMetadata.PropertyNames.Comment;
			c.IsNullable = true;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
		}
		#endregion

		static public DivisiontempMetadata Meta()
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
			public const string Id = "id";
			public const string Code = "Code";
			public const string Name = "Name";
			public const string Comment = "Comment";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string Id = "Id";
			public const string Code = "Code";
			public const string Name = "Name";
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
			lock (typeof(DivisiontempMetadata))
			{
				if (DivisiontempMetadata.mapDelegates == null)
				{
					DivisiontempMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (DivisiontempMetadata.meta == null)
				{
					DivisiontempMetadata.meta = new DivisiontempMetadata();
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


				meta.AddTypeMap("Id", new tgTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("Code", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Name", new tgTypeMap("text", "System.String"));
				meta.AddTypeMap("Comment", new tgTypeMap("text", "System.String"));

				meta.Source = "divisiontemp";
				meta.Destination = "divisiontemp";

				meta.spInsert = "proc_DivisiontempInsert";
				meta.spUpdate = "proc_DivisiontempUpdate";
				meta.spDelete = "proc_DivisiontempDelete";
				meta.spLoadAll = "proc_DivisiontempLoadAll";
				meta.spLoadByPrimaryKey = "proc_DivisiontempLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private DivisiontempMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

