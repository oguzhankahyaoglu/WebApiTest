///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 10 Eylül 2015 Perşembe 16:20:14
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

		/// <summary>returns the datasource to use in a Linq query when targeting Category1Entity instances in the database.</summary>
		public DataSource2<Category1Entity> Category1
		{
			get { return new DataSource2<Category1Entity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting Category1PostEntity instances in the database.</summary>
		public DataSource2<Category1PostEntity> Category1Post
		{
			get { return new DataSource2<Category1PostEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting Category2Entity instances in the database.</summary>
		public DataSource2<Category2Entity> Category2
		{
			get { return new DataSource2<Category2Entity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting Category2PostEntity instances in the database.</summary>
		public DataSource2<Category2PostEntity> Category2Post
		{
			get { return new DataSource2<Category2PostEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MainPageBannerEntity instances in the database.</summary>
		public DataSource2<MainPageBannerEntity> MainPageBanner
		{
			get { return new DataSource2<MainPageBannerEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PostEntity instances in the database.</summary>
		public DataSource2<PostEntity> Post
		{
			get { return new DataSource2<PostEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PostAttachmentEntity instances in the database.</summary>
		public DataSource2<PostAttachmentEntity> PostAttachment
		{
			get { return new DataSource2<PostAttachmentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PostTagEntity instances in the database.</summary>
		public DataSource2<PostTagEntity> PostTag
		{
			get { return new DataSource2<PostTagEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SysLanguageEntity instances in the database.</summary>
		public DataSource2<SysLanguageEntity> SysLanguage
		{
			get { return new DataSource2<SysLanguageEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SysLogEntity instances in the database.</summary>
		public DataSource2<SysLogEntity> SysLog
		{
			get { return new DataSource2<SysLogEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SysMltextEntity instances in the database.</summary>
		public DataSource2<SysMltextEntity> SysMltext
		{
			get { return new DataSource2<SysMltextEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SysMltranslationEntity instances in the database.</summary>
		public DataSource2<SysMltranslationEntity> SysMltranslation
		{
			get { return new DataSource2<SysMltranslationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SysSettingEntity instances in the database.</summary>
		public DataSource2<SysSettingEntity> SysSetting
		{
			get { return new DataSource2<SysSettingEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SysTransactionEntity instances in the database.</summary>
		public DataSource2<SysTransactionEntity> SysTransaction
		{
			get { return new DataSource2<SysTransactionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SysUserEntity instances in the database.</summary>
		public DataSource2<SysUserEntity> SysUser
		{
			get { return new DataSource2<SysUserEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TagEntity instances in the database.</summary>
		public DataSource2<TagEntity> Tag
		{
			get { return new DataSource2<TagEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TeamEntity instances in the database.</summary>
		public DataSource2<TeamEntity> Team
		{
			get { return new DataSource2<TeamEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TeamPostEntity instances in the database.</summary>
		public DataSource2<TeamPostEntity> TeamPost
		{
			get { return new DataSource2<TeamPostEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TextContentEntity instances in the database.</summary>
		public DataSource2<TextContentEntity> TextContent
		{
			get { return new DataSource2<TextContentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting VideoEntity instances in the database.</summary>
		public DataSource2<VideoEntity> Video
		{
			get { return new DataSource2<VideoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting WeeklyProgrammeDayEntity instances in the database.</summary>
		public DataSource2<WeeklyProgrammeDayEntity> WeeklyProgrammeDay
		{
			get { return new DataSource2<WeeklyProgrammeDayEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting WeeklyProgrammeMatchEntity instances in the database.</summary>
		public DataSource2<WeeklyProgrammeMatchEntity> WeeklyProgrammeMatch
		{
			get { return new DataSource2<WeeklyProgrammeMatchEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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