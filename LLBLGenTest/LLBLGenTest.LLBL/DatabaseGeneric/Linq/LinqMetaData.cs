///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 09 Eylül 2015 Çarşamba 16:20:11
// Code is generated using templates: SD.TemplateBindings.Linq
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using LLBLGenTest.LLBL;
using LLBLGenTest.LLBL.EntityClasses;
using LLBLGenTest.LLBL.FactoryClasses;
using LLBLGenTest.LLBL.HelperClasses;
using LLBLGenTest.LLBL.RelationClasses;

namespace LLBLGenTest.LLBL.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((LLBLGenTest.LLBL.EntityType)typeOfEntity)
			{
				case LLBLGenTest.LLBL.EntityType.Category1Entity:
					toReturn = this.Category1;
					break;
				case LLBLGenTest.LLBL.EntityType.Category1PostEntity:
					toReturn = this.Category1Post;
					break;
				case LLBLGenTest.LLBL.EntityType.Category2Entity:
					toReturn = this.Category2;
					break;
				case LLBLGenTest.LLBL.EntityType.Category2PostEntity:
					toReturn = this.Category2Post;
					break;
				case LLBLGenTest.LLBL.EntityType.MainPageBannerEntity:
					toReturn = this.MainPageBanner;
					break;
				case LLBLGenTest.LLBL.EntityType.PostEntity:
					toReturn = this.Post;
					break;
				case LLBLGenTest.LLBL.EntityType.PostAttachmentEntity:
					toReturn = this.PostAttachment;
					break;
				case LLBLGenTest.LLBL.EntityType.PostTagEntity:
					toReturn = this.PostTag;
					break;
				case LLBLGenTest.LLBL.EntityType.SysLanguageEntity:
					toReturn = this.SysLanguage;
					break;
				case LLBLGenTest.LLBL.EntityType.SysLogEntity:
					toReturn = this.SysLog;
					break;
				case LLBLGenTest.LLBL.EntityType.SysMltextEntity:
					toReturn = this.SysMltext;
					break;
				case LLBLGenTest.LLBL.EntityType.SysMltranslationEntity:
					toReturn = this.SysMltranslation;
					break;
				case LLBLGenTest.LLBL.EntityType.SysSettingEntity:
					toReturn = this.SysSetting;
					break;
				case LLBLGenTest.LLBL.EntityType.SysTransactionEntity:
					toReturn = this.SysTransaction;
					break;
				case LLBLGenTest.LLBL.EntityType.SysUserEntity:
					toReturn = this.SysUser;
					break;
				case LLBLGenTest.LLBL.EntityType.TagEntity:
					toReturn = this.Tag;
					break;
				case LLBLGenTest.LLBL.EntityType.TeamEntity:
					toReturn = this.Team;
					break;
				case LLBLGenTest.LLBL.EntityType.TeamPostEntity:
					toReturn = this.TeamPost;
					break;
				case LLBLGenTest.LLBL.EntityType.TextContentEntity:
					toReturn = this.TextContent;
					break;
				case LLBLGenTest.LLBL.EntityType.VideoEntity:
					toReturn = this.Video;
					break;
				case LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity:
					toReturn = this.WeeklyProgrammeDay;
					break;
				case LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity:
					toReturn = this.WeeklyProgrammeMatch;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting MyCategory1Entity instances in the database.</summary>
		public DataSource2<MyCategory1Entity> Category1
		{
			get { return new DataSource2<MyCategory1Entity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyCategory1PostEntity instances in the database.</summary>
		public DataSource2<MyCategory1PostEntity> Category1Post
		{
			get { return new DataSource2<MyCategory1PostEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyCategory2Entity instances in the database.</summary>
		public DataSource2<MyCategory2Entity> Category2
		{
			get { return new DataSource2<MyCategory2Entity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyCategory2PostEntity instances in the database.</summary>
		public DataSource2<MyCategory2PostEntity> Category2Post
		{
			get { return new DataSource2<MyCategory2PostEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyMainPageBannerEntity instances in the database.</summary>
		public DataSource2<MyMainPageBannerEntity> MainPageBanner
		{
			get { return new DataSource2<MyMainPageBannerEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyPostEntity instances in the database.</summary>
		public DataSource2<MyPostEntity> Post
		{
			get { return new DataSource2<MyPostEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyPostAttachmentEntity instances in the database.</summary>
		public DataSource2<MyPostAttachmentEntity> PostAttachment
		{
			get { return new DataSource2<MyPostAttachmentEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyPostTagEntity instances in the database.</summary>
		public DataSource2<MyPostTagEntity> PostTag
		{
			get { return new DataSource2<MyPostTagEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MySysLanguageEntity instances in the database.</summary>
		public DataSource2<MySysLanguageEntity> SysLanguage
		{
			get { return new DataSource2<MySysLanguageEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MySysLogEntity instances in the database.</summary>
		public DataSource2<MySysLogEntity> SysLog
		{
			get { return new DataSource2<MySysLogEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MySysMltextEntity instances in the database.</summary>
		public DataSource2<MySysMltextEntity> SysMltext
		{
			get { return new DataSource2<MySysMltextEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MySysMltranslationEntity instances in the database.</summary>
		public DataSource2<MySysMltranslationEntity> SysMltranslation
		{
			get { return new DataSource2<MySysMltranslationEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MySysSettingEntity instances in the database.</summary>
		public DataSource2<MySysSettingEntity> SysSetting
		{
			get { return new DataSource2<MySysSettingEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MySysTransactionEntity instances in the database.</summary>
		public DataSource2<MySysTransactionEntity> SysTransaction
		{
			get { return new DataSource2<MySysTransactionEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MySysUserEntity instances in the database.</summary>
		public DataSource2<MySysUserEntity> SysUser
		{
			get { return new DataSource2<MySysUserEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyTagEntity instances in the database.</summary>
		public DataSource2<MyTagEntity> Tag
		{
			get { return new DataSource2<MyTagEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyTeamEntity instances in the database.</summary>
		public DataSource2<MyTeamEntity> Team
		{
			get { return new DataSource2<MyTeamEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyTeamPostEntity instances in the database.</summary>
		public DataSource2<MyTeamPostEntity> TeamPost
		{
			get { return new DataSource2<MyTeamPostEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyTextContentEntity instances in the database.</summary>
		public DataSource2<MyTextContentEntity> TextContent
		{
			get { return new DataSource2<MyTextContentEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyVideoEntity instances in the database.</summary>
		public DataSource2<MyVideoEntity> Video
		{
			get { return new DataSource2<MyVideoEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyWeeklyProgrammeDayEntity instances in the database.</summary>
		public DataSource2<MyWeeklyProgrammeDayEntity> WeeklyProgrammeDay
		{
			get { return new DataSource2<MyWeeklyProgrammeDayEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MyWeeklyProgrammeMatchEntity instances in the database.</summary>
		public DataSource2<MyWeeklyProgrammeMatchEntity> WeeklyProgrammeMatch
		{
			get { return new DataSource2<MyWeeklyProgrammeMatchEntity>(_adapterToUse, new MyElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		
		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}