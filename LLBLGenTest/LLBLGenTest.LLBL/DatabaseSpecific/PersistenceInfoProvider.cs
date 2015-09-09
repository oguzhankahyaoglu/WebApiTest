///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 09 Eylül 2015 Çarşamba 16:20:12
// Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.LLBL.DatabaseSpecific
{
	/// <summary>
	/// Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal sealed class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			base.InitClass((22 + 0));
			InitCategory1EntityMappings();
			InitCategory1PostEntityMappings();
			InitCategory2EntityMappings();
			InitCategory2PostEntityMappings();
			InitMainPageBannerEntityMappings();
			InitPostEntityMappings();
			InitPostAttachmentEntityMappings();
			InitPostTagEntityMappings();
			InitSysLanguageEntityMappings();
			InitSysLogEntityMappings();
			InitSysMltextEntityMappings();
			InitSysMltranslationEntityMappings();
			InitSysSettingEntityMappings();
			InitSysTransactionEntityMappings();
			InitSysUserEntityMappings();
			InitTagEntityMappings();
			InitTeamEntityMappings();
			InitTeamPostEntityMappings();
			InitTextContentEntityMappings();
			InitVideoEntityMappings();
			InitWeeklyProgrammeDayEntityMappings();
			InitWeeklyProgrammeMatchEntityMappings();

		}


		/// <summary>Inits Category1Entity's mappings</summary>
		private void InitCategory1EntityMappings()
		{
			base.AddElementMapping( "Category1Entity", "PremierLigTurkiye", @"dbo", "Category1", 8 );
			base.AddElementFieldMapping( "Category1Entity", "Category1Id", "Category1Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "Category1Entity", "Title", "Title", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "Category1Entity", "MenuTitle", "MenuTitle", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "Category1Entity", "Description", "Description", true, (int)SqlDbType.VarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "Category1Entity", "Slug", "Slug", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "Category1Entity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			base.AddElementFieldMapping( "Category1Entity", "IsShownInMainMenu", "IsShownInMainMenu", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			base.AddElementFieldMapping( "Category1Entity", "OrderNo", "OrderNo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
		}
		/// <summary>Inits Category1PostEntity's mappings</summary>
		private void InitCategory1PostEntityMappings()
		{
			base.AddElementMapping( "Category1PostEntity", "PremierLigTurkiye", @"dbo", "Category1Post", 3 );
			base.AddElementFieldMapping( "Category1PostEntity", "Category1PostId", "Category1PostId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "Category1PostEntity", "FkPostId", "FK_PostID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "Category1PostEntity", "FkCategory1Id", "FK_Category1ID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits Category2Entity's mappings</summary>
		private void InitCategory2EntityMappings()
		{
			base.AddElementMapping( "Category2Entity", "PremierLigTurkiye", @"dbo", "Category2", 7 );
			base.AddElementFieldMapping( "Category2Entity", "Category2Id", "Category2Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "Category2Entity", "Title", "Title", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "Category2Entity", "Description", "Description", true, (int)SqlDbType.VarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "Category2Entity", "FkCategory1Id", "FK_Category1ID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "Category2Entity", "Slug", "Slug", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "Category2Entity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			base.AddElementFieldMapping( "Category2Entity", "OrderNo", "OrderNo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
		}
		/// <summary>Inits Category2PostEntity's mappings</summary>
		private void InitCategory2PostEntityMappings()
		{
			base.AddElementMapping( "Category2PostEntity", "PremierLigTurkiye", @"dbo", "Category2Post", 3 );
			base.AddElementFieldMapping( "Category2PostEntity", "Category2PostId", "Category2PostId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "Category2PostEntity", "FkCategory2Id", "FK_Category2Id", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "Category2PostEntity", "FkPostId", "FK_PostId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits MainPageBannerEntity's mappings</summary>
		private void InitMainPageBannerEntityMappings()
		{
			base.AddElementMapping( "MainPageBannerEntity", "PremierLigTurkiye", @"dbo", "MainPageBanner", 9 );
			base.AddElementFieldMapping( "MainPageBannerEntity", "MainPageBannerId", "MainPageBannerId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "MainPageBannerEntity", "Title", "Title", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "MainPageBannerEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "MainPageBannerEntity", "FkCategory1Id", "FK_Category1ID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "MainPageBannerEntity", "ImageFile", "ImageFile", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "MainPageBannerEntity", "Date", "Date", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "MainPageBannerEntity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			base.AddElementFieldMapping( "MainPageBannerEntity", "OrderNo", "OrderNo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "MainPageBannerEntity", "Link", "Link", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 8 );
		}
		/// <summary>Inits PostEntity's mappings</summary>
		private void InitPostEntityMappings()
		{
			base.AddElementMapping( "PostEntity", "PremierLigTurkiye", @"dbo", "Post", 11 );
			base.AddElementFieldMapping( "PostEntity", "PostId", "PostId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "PostEntity", "Title", "Title", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "PostEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "PostEntity", "ImageFile", "ImageFile", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "PostEntity", "Slug", "Slug", true, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "PostEntity", "FkAuthorId", "FK_AuthorID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "PostEntity", "DateCreated", "DateCreated", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "PostEntity", "CommentStatus", "CommentStatus", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 7 );
			base.AddElementFieldMapping( "PostEntity", "ReadCount", "ReadCount", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "PostEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			base.AddElementFieldMapping( "PostEntity", "OrderNo", "OrderNo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
		}
		/// <summary>Inits PostAttachmentEntity's mappings</summary>
		private void InitPostAttachmentEntityMappings()
		{
			base.AddElementMapping( "PostAttachmentEntity", "PremierLigTurkiye", @"dbo", "PostAttachment", 6 );
			base.AddElementFieldMapping( "PostAttachmentEntity", "PostAttachmentId", "PostAttachmentID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "PostAttachmentEntity", "CreateDate", "CreateDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "PostAttachmentEntity", "ImageFile", "ImageFile", true, (int)SqlDbType.VarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "PostAttachmentEntity", "FkPostId", "FK_PostID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "PostAttachmentEntity", "ImageFileUrl", "ImageFileUrl", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "PostAttachmentEntity", "MimeType", "MimeType", true, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits PostTagEntity's mappings</summary>
		private void InitPostTagEntityMappings()
		{
			base.AddElementMapping( "PostTagEntity", "PremierLigTurkiye", @"dbo", "PostTag", 3 );
			base.AddElementFieldMapping( "PostTagEntity", "PostTagId", "PostTagID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "PostTagEntity", "FkPostId", "FK_PostID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "PostTagEntity", "FkTagId", "FK_TagID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits SysLanguageEntity's mappings</summary>
		private void InitSysLanguageEntityMappings()
		{
			base.AddElementMapping( "SysLanguageEntity", "PremierLigTurkiye", @"dbo", "SYS_Language", 7 );
			base.AddElementFieldMapping( "SysLanguageEntity", "LanguageId", "LanguageID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SysLanguageEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "SysLanguageEntity", "Code", "Code", false, (int)SqlDbType.NVarChar, 10, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "SysLanguageEntity", "Culture", "Culture", false, (int)SqlDbType.NVarChar, 10, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "SysLanguageEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "SysLanguageEntity", "IsPublishing", "IsPublishing", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			base.AddElementFieldMapping( "SysLanguageEntity", "OrderNo", "OrderNo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
		}
		/// <summary>Inits SysLogEntity's mappings</summary>
		private void InitSysLogEntityMappings()
		{
			base.AddElementMapping( "SysLogEntity", "PremierLigTurkiye", @"dbo", "SYS_Log", 5 );
			base.AddElementFieldMapping( "SysLogEntity", "LogId", "LogID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SysLogEntity", "LogDate", "LogDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "SysLogEntity", "LogTitle", "LogTitle", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "SysLogEntity", "Content", "Content", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "SysLogEntity", "LogLevel", "LogLevel", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
		}
		/// <summary>Inits SysMltextEntity's mappings</summary>
		private void InitSysMltextEntityMappings()
		{
			base.AddElementMapping( "SysMltextEntity", "PremierLigTurkiye", @"dbo", "SYS_MLText", 1 );
			base.AddElementFieldMapping( "SysMltextEntity", "MltextId", "MLTextID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
		}
		/// <summary>Inits SysMltranslationEntity's mappings</summary>
		private void InitSysMltranslationEntityMappings()
		{
			base.AddElementMapping( "SysMltranslationEntity", "PremierLigTurkiye", @"dbo", "SYS_MLTranslation", 4 );
			base.AddElementFieldMapping( "SysMltranslationEntity", "MltranslationId", "MLTranslationID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SysMltranslationEntity", "FkMltextId", "FK_MLTextID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "SysMltranslationEntity", "FkLanguageId", "FK_LanguageID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "SysMltranslationEntity", "TranslatedValue", "TranslatedValue", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
		}
		/// <summary>Inits SysSettingEntity's mappings</summary>
		private void InitSysSettingEntityMappings()
		{
			base.AddElementMapping( "SysSettingEntity", "PremierLigTurkiye", @"dbo", "SYS_Setting", 5 );
			base.AddElementFieldMapping( "SysSettingEntity", "SettingId", "SettingID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SysSettingEntity", "SettingCategory", "SettingCategory", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "SysSettingEntity", "SettingKey", "SettingKey", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "SysSettingEntity", "SettingValue", "SettingValue", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "SysSettingEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
		}
		/// <summary>Inits SysTransactionEntity's mappings</summary>
		private void InitSysTransactionEntityMappings()
		{
			base.AddElementMapping( "SysTransactionEntity", "PremierLigTurkiye", @"dbo", "SYS_Transaction", 8 );
			base.AddElementFieldMapping( "SysTransactionEntity", "TransactionId", "TransactionID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SysTransactionEntity", "TransactionDate", "TransactionDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "SysTransactionEntity", "FkUserId", "FK_UserID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "SysTransactionEntity", "Username", "Username", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "SysTransactionEntity", "Method", "Method", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "SysTransactionEntity", "EntityName", "EntityName", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "SysTransactionEntity", "EntityId", "EntityID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "SysTransactionEntity", "EntityTitle", "EntityTitle", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 7 );
		}
		/// <summary>Inits SysUserEntity's mappings</summary>
		private void InitSysUserEntityMappings()
		{
			base.AddElementMapping( "SysUserEntity", "PremierLigTurkiye", @"dbo", "SYS_User", 12 );
			base.AddElementFieldMapping( "SysUserEntity", "UserId", "UserID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SysUserEntity", "Username", "Username", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "SysUserEntity", "DisplayName", "DisplayName", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "SysUserEntity", "Password", "Password", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "SysUserEntity", "Roles", "Roles", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "SysUserEntity", "Email", "Email", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "SysUserEntity", "Website", "Website", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "SysUserEntity", "LastLoginDate", "LastLoginDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "SysUserEntity", "ImageFile", "ImageFile", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "SysUserEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "SysUserEntity", "IsVisibleOnRightMenu", "IsVisibleOnRightMenu", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			base.AddElementFieldMapping( "SysUserEntity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 11 );
		}
		/// <summary>Inits TagEntity's mappings</summary>
		private void InitTagEntityMappings()
		{
			base.AddElementMapping( "TagEntity", "PremierLigTurkiye", @"dbo", "Tag", 5 );
			base.AddElementFieldMapping( "TagEntity", "TagId", "TagID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "TagEntity", "Title", "Title", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "TagEntity", "Description", "Description", true, (int)SqlDbType.VarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "TagEntity", "Slug", "Slug", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "TagEntity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
		}
		/// <summary>Inits TeamEntity's mappings</summary>
		private void InitTeamEntityMappings()
		{
			base.AddElementMapping( "TeamEntity", "PremierLigTurkiye", @"dbo", "Team", 7 );
			base.AddElementFieldMapping( "TeamEntity", "TeamId", "TeamId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "TeamEntity", "Title", "Title", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "TeamEntity", "Slug", "Slug", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "TeamEntity", "ImageFile", "ImageFile", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "TeamEntity", "Points", "Points", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "TeamEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			base.AddElementFieldMapping( "TeamEntity", "OrderNo", "OrderNo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
		}
		/// <summary>Inits TeamPostEntity's mappings</summary>
		private void InitTeamPostEntityMappings()
		{
			base.AddElementMapping( "TeamPostEntity", "PremierLigTurkiye", @"dbo", "TeamPost", 3 );
			base.AddElementFieldMapping( "TeamPostEntity", "TeamPostId", "TeamPostId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "TeamPostEntity", "FkTeamId", "FK_TeamId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "TeamPostEntity", "FkPostId", "FK_PostId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits TextContentEntity's mappings</summary>
		private void InitTextContentEntityMappings()
		{
			base.AddElementMapping( "TextContentEntity", "PremierLigTurkiye", @"dbo", "TextContent", 9 );
			base.AddElementFieldMapping( "TextContentEntity", "TextContentId", "TextContentID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "TextContentEntity", "FtTitle", "FT_Title", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "TextContentEntity", "FtMenuTitle", "FT_MenuTitle", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "TextContentEntity", "FtDescription", "FT_Description", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "TextContentEntity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "TextContentEntity", "TextContentKey", "TextContentKey", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "TextContentEntity", "FtMetaTitle", "FT_MetaTitle", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "TextContentEntity", "FtMetaKeywords", "FT_MetaKeywords", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "TextContentEntity", "FtMetaDescription", "FT_MetaDescription", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
		}
		/// <summary>Inits VideoEntity's mappings</summary>
		private void InitVideoEntityMappings()
		{
			base.AddElementMapping( "VideoEntity", "PremierLigTurkiye", @"dbo", "Video", 7 );
			base.AddElementFieldMapping( "VideoEntity", "VideoId", "VideoID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "VideoEntity", "Title", "Title", true, (int)SqlDbType.VarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "VideoEntity", "Link", "Link", true, (int)SqlDbType.VarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "VideoEntity", "DateCreated", "DateCreated", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "VideoEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "VideoEntity", "OrderNo", "OrderNo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "VideoEntity", "ReadCount", "ReadCount", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
		}
		/// <summary>Inits WeeklyProgrammeDayEntity's mappings</summary>
		private void InitWeeklyProgrammeDayEntityMappings()
		{
			base.AddElementMapping( "WeeklyProgrammeDayEntity", "PremierLigTurkiye", @"dbo", "WeeklyProgrammeDay", 4 );
			base.AddElementFieldMapping( "WeeklyProgrammeDayEntity", "WeeklyProgrammeDayId", "WeeklyProgrammeDayID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "WeeklyProgrammeDayEntity", "Title", "Title", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "WeeklyProgrammeDayEntity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			base.AddElementFieldMapping( "WeeklyProgrammeDayEntity", "OrderNo", "OrderNo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
		}
		/// <summary>Inits WeeklyProgrammeMatchEntity's mappings</summary>
		private void InitWeeklyProgrammeMatchEntityMappings()
		{
			base.AddElementMapping( "WeeklyProgrammeMatchEntity", "PremierLigTurkiye", @"dbo", "WeeklyProgrammeMatch", 7 );
			base.AddElementFieldMapping( "WeeklyProgrammeMatchEntity", "WeeklyProgrammeMatchId", "WeeklyProgrammeMatchID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "WeeklyProgrammeMatchEntity", "FkWeeklyProgrammeDayId", "FK_WeeklyProgrammeDayId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "WeeklyProgrammeMatchEntity", "Time", "Time", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "WeeklyProgrammeMatchEntity", "FkTeam1", "FK_Team1", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "WeeklyProgrammeMatchEntity", "FkTeam2", "FK_Team2", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "WeeklyProgrammeMatchEntity", "OrderNo", "OrderNo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "WeeklyProgrammeMatchEntity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
		}

	}
}













