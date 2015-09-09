///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 09 Eylül 2015 Çarşamba 16:20:09
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.LLBL.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>
	/// Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal sealed class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private FieldInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			base.InitClass( (22 + 0));
			InitCategory1EntityInfos();
			InitCategory1PostEntityInfos();
			InitCategory2EntityInfos();
			InitCategory2PostEntityInfos();
			InitMainPageBannerEntityInfos();
			InitPostEntityInfos();
			InitPostAttachmentEntityInfos();
			InitPostTagEntityInfos();
			InitSysLanguageEntityInfos();
			InitSysLogEntityInfos();
			InitSysMltextEntityInfos();
			InitSysMltranslationEntityInfos();
			InitSysSettingEntityInfos();
			InitSysTransactionEntityInfos();
			InitSysUserEntityInfos();
			InitTagEntityInfos();
			InitTeamEntityInfos();
			InitTeamPostEntityInfos();
			InitTextContentEntityInfos();
			InitVideoEntityInfos();
			InitWeeklyProgrammeDayEntityInfos();
			InitWeeklyProgrammeMatchEntityInfos();

			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits Category1Entity's FieldInfo objects</summary>
		private void InitCategory1EntityInfos()
		{
			base.AddElementFieldInfo("Category1Entity", "Category1Id", typeof(System.Int32), true, false, true, false,  (int)Category1FieldIndex.Category1Id, 0, 0, 10);
			base.AddElementFieldInfo("Category1Entity", "Title", typeof(System.String), false, false, false, true,  (int)Category1FieldIndex.Title, 200, 0, 0);
			base.AddElementFieldInfo("Category1Entity", "MenuTitle", typeof(System.String), false, false, false, true,  (int)Category1FieldIndex.MenuTitle, 200, 0, 0);
			base.AddElementFieldInfo("Category1Entity", "Description", typeof(System.String), false, false, false, true,  (int)Category1FieldIndex.Description, 2147483647, 0, 0);
			base.AddElementFieldInfo("Category1Entity", "Slug", typeof(System.String), false, false, false, true,  (int)Category1FieldIndex.Slug, 200, 0, 0);
			base.AddElementFieldInfo("Category1Entity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)Category1FieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("Category1Entity", "IsShownInMainMenu", typeof(System.Boolean), false, false, false, false,  (int)Category1FieldIndex.IsShownInMainMenu, 0, 0, 0);
			base.AddElementFieldInfo("Category1Entity", "OrderNo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)Category1FieldIndex.OrderNo, 0, 0, 10);
		}
		/// <summary>Inits Category1PostEntity's FieldInfo objects</summary>
		private void InitCategory1PostEntityInfos()
		{
			base.AddElementFieldInfo("Category1PostEntity", "Category1PostId", typeof(System.Int32), true, false, true, false,  (int)Category1PostFieldIndex.Category1PostId, 0, 0, 10);
			base.AddElementFieldInfo("Category1PostEntity", "FkPostId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)Category1PostFieldIndex.FkPostId, 0, 0, 10);
			base.AddElementFieldInfo("Category1PostEntity", "FkCategory1Id", typeof(Nullable<System.Int32>), false, true, false, true,  (int)Category1PostFieldIndex.FkCategory1Id, 0, 0, 10);
		}
		/// <summary>Inits Category2Entity's FieldInfo objects</summary>
		private void InitCategory2EntityInfos()
		{
			base.AddElementFieldInfo("Category2Entity", "Category2Id", typeof(System.Int32), true, false, true, false,  (int)Category2FieldIndex.Category2Id, 0, 0, 10);
			base.AddElementFieldInfo("Category2Entity", "Title", typeof(System.String), false, false, false, true,  (int)Category2FieldIndex.Title, 200, 0, 0);
			base.AddElementFieldInfo("Category2Entity", "Description", typeof(System.String), false, false, false, true,  (int)Category2FieldIndex.Description, 2147483647, 0, 0);
			base.AddElementFieldInfo("Category2Entity", "FkCategory1Id", typeof(Nullable<System.Int32>), false, true, false, true,  (int)Category2FieldIndex.FkCategory1Id, 0, 0, 10);
			base.AddElementFieldInfo("Category2Entity", "Slug", typeof(System.String), false, false, false, true,  (int)Category2FieldIndex.Slug, 200, 0, 0);
			base.AddElementFieldInfo("Category2Entity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)Category2FieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("Category2Entity", "OrderNo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)Category2FieldIndex.OrderNo, 0, 0, 10);
		}
		/// <summary>Inits Category2PostEntity's FieldInfo objects</summary>
		private void InitCategory2PostEntityInfos()
		{
			base.AddElementFieldInfo("Category2PostEntity", "Category2PostId", typeof(System.Int32), true, false, true, false,  (int)Category2PostFieldIndex.Category2PostId, 0, 0, 10);
			base.AddElementFieldInfo("Category2PostEntity", "FkCategory2Id", typeof(Nullable<System.Int32>), false, true, false, true,  (int)Category2PostFieldIndex.FkCategory2Id, 0, 0, 10);
			base.AddElementFieldInfo("Category2PostEntity", "FkPostId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)Category2PostFieldIndex.FkPostId, 0, 0, 10);
		}
		/// <summary>Inits MainPageBannerEntity's FieldInfo objects</summary>
		private void InitMainPageBannerEntityInfos()
		{
			base.AddElementFieldInfo("MainPageBannerEntity", "MainPageBannerId", typeof(System.Int32), true, false, true, false,  (int)MainPageBannerFieldIndex.MainPageBannerId, 0, 0, 10);
			base.AddElementFieldInfo("MainPageBannerEntity", "Title", typeof(System.String), false, false, false, true,  (int)MainPageBannerFieldIndex.Title, 500, 0, 0);
			base.AddElementFieldInfo("MainPageBannerEntity", "Description", typeof(System.String), false, false, false, true,  (int)MainPageBannerFieldIndex.Description, 500, 0, 0);
			base.AddElementFieldInfo("MainPageBannerEntity", "FkCategory1Id", typeof(Nullable<System.Int32>), false, true, false, true,  (int)MainPageBannerFieldIndex.FkCategory1Id, 0, 0, 10);
			base.AddElementFieldInfo("MainPageBannerEntity", "ImageFile", typeof(System.String), false, false, false, true,  (int)MainPageBannerFieldIndex.ImageFile, 250, 0, 0);
			base.AddElementFieldInfo("MainPageBannerEntity", "Date", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)MainPageBannerFieldIndex.Date, 0, 0, 0);
			base.AddElementFieldInfo("MainPageBannerEntity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)MainPageBannerFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("MainPageBannerEntity", "OrderNo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)MainPageBannerFieldIndex.OrderNo, 0, 0, 10);
			base.AddElementFieldInfo("MainPageBannerEntity", "Link", typeof(System.String), false, false, false, true,  (int)MainPageBannerFieldIndex.Link, 2147483647, 0, 0);
		}
		/// <summary>Inits PostEntity's FieldInfo objects</summary>
		private void InitPostEntityInfos()
		{
			base.AddElementFieldInfo("PostEntity", "PostId", typeof(System.Int32), true, false, true, false,  (int)PostFieldIndex.PostId, 0, 0, 10);
			base.AddElementFieldInfo("PostEntity", "Title", typeof(System.String), false, false, false, true,  (int)PostFieldIndex.Title, 2147483647, 0, 0);
			base.AddElementFieldInfo("PostEntity", "Description", typeof(System.String), false, false, false, true,  (int)PostFieldIndex.Description, 2147483647, 0, 0);
			base.AddElementFieldInfo("PostEntity", "ImageFile", typeof(System.String), false, false, false, true,  (int)PostFieldIndex.ImageFile, 250, 0, 0);
			base.AddElementFieldInfo("PostEntity", "Slug", typeof(System.String), false, false, false, true,  (int)PostFieldIndex.Slug, 200, 0, 0);
			base.AddElementFieldInfo("PostEntity", "FkAuthorId", typeof(System.Int32), false, true, false, false,  (int)PostFieldIndex.FkAuthorId, 0, 0, 10);
			base.AddElementFieldInfo("PostEntity", "DateCreated", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PostFieldIndex.DateCreated, 0, 0, 0);
			base.AddElementFieldInfo("PostEntity", "CommentStatus", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)PostFieldIndex.CommentStatus, 0, 0, 0);
			base.AddElementFieldInfo("PostEntity", "ReadCount", typeof(System.Int32), false, false, false, false,  (int)PostFieldIndex.ReadCount, 0, 0, 10);
			base.AddElementFieldInfo("PostEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)PostFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("PostEntity", "OrderNo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)PostFieldIndex.OrderNo, 0, 0, 10);
		}
		/// <summary>Inits PostAttachmentEntity's FieldInfo objects</summary>
		private void InitPostAttachmentEntityInfos()
		{
			base.AddElementFieldInfo("PostAttachmentEntity", "PostAttachmentId", typeof(System.Int32), true, false, true, false,  (int)PostAttachmentFieldIndex.PostAttachmentId, 0, 0, 10);
			base.AddElementFieldInfo("PostAttachmentEntity", "CreateDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PostAttachmentFieldIndex.CreateDate, 0, 0, 0);
			base.AddElementFieldInfo("PostAttachmentEntity", "ImageFile", typeof(System.String), false, false, false, true,  (int)PostAttachmentFieldIndex.ImageFile, 2147483647, 0, 0);
			base.AddElementFieldInfo("PostAttachmentEntity", "FkPostId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PostAttachmentFieldIndex.FkPostId, 0, 0, 10);
			base.AddElementFieldInfo("PostAttachmentEntity", "ImageFileUrl", typeof(System.String), false, false, false, true,  (int)PostAttachmentFieldIndex.ImageFileUrl, 255, 0, 0);
			base.AddElementFieldInfo("PostAttachmentEntity", "MimeType", typeof(System.String), false, false, false, true,  (int)PostAttachmentFieldIndex.MimeType, 100, 0, 0);
		}
		/// <summary>Inits PostTagEntity's FieldInfo objects</summary>
		private void InitPostTagEntityInfos()
		{
			base.AddElementFieldInfo("PostTagEntity", "PostTagId", typeof(System.Int32), true, false, true, false,  (int)PostTagFieldIndex.PostTagId, 0, 0, 10);
			base.AddElementFieldInfo("PostTagEntity", "FkPostId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PostTagFieldIndex.FkPostId, 0, 0, 10);
			base.AddElementFieldInfo("PostTagEntity", "FkTagId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PostTagFieldIndex.FkTagId, 0, 0, 10);
		}
		/// <summary>Inits SysLanguageEntity's FieldInfo objects</summary>
		private void InitSysLanguageEntityInfos()
		{
			base.AddElementFieldInfo("SysLanguageEntity", "LanguageId", typeof(System.Int32), true, false, true, false,  (int)SysLanguageFieldIndex.LanguageId, 0, 0, 10);
			base.AddElementFieldInfo("SysLanguageEntity", "Name", typeof(System.String), false, false, false, false,  (int)SysLanguageFieldIndex.Name, 250, 0, 0);
			base.AddElementFieldInfo("SysLanguageEntity", "Code", typeof(System.String), false, false, false, false,  (int)SysLanguageFieldIndex.Code, 10, 0, 0);
			base.AddElementFieldInfo("SysLanguageEntity", "Culture", typeof(System.String), false, false, false, false,  (int)SysLanguageFieldIndex.Culture, 10, 0, 0);
			base.AddElementFieldInfo("SysLanguageEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)SysLanguageFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("SysLanguageEntity", "IsPublishing", typeof(System.Boolean), false, false, false, false,  (int)SysLanguageFieldIndex.IsPublishing, 0, 0, 0);
			base.AddElementFieldInfo("SysLanguageEntity", "OrderNo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SysLanguageFieldIndex.OrderNo, 0, 0, 10);
		}
		/// <summary>Inits SysLogEntity's FieldInfo objects</summary>
		private void InitSysLogEntityInfos()
		{
			base.AddElementFieldInfo("SysLogEntity", "LogId", typeof(System.Int32), true, false, true, false,  (int)SysLogFieldIndex.LogId, 0, 0, 10);
			base.AddElementFieldInfo("SysLogEntity", "LogDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SysLogFieldIndex.LogDate, 0, 0, 0);
			base.AddElementFieldInfo("SysLogEntity", "LogTitle", typeof(System.String), false, false, false, true,  (int)SysLogFieldIndex.LogTitle, 500, 0, 0);
			base.AddElementFieldInfo("SysLogEntity", "Content", typeof(System.String), false, false, false, true,  (int)SysLogFieldIndex.Content, 2147483647, 0, 0);
			base.AddElementFieldInfo("SysLogEntity", "LogLevel", typeof(System.Int32), false, false, false, false,  (int)SysLogFieldIndex.LogLevel, 0, 0, 10);
		}
		/// <summary>Inits SysMltextEntity's FieldInfo objects</summary>
		private void InitSysMltextEntityInfos()
		{
			base.AddElementFieldInfo("SysMltextEntity", "MltextId", typeof(System.Int32), true, false, true, false,  (int)SysMltextFieldIndex.MltextId, 0, 0, 10);
		}
		/// <summary>Inits SysMltranslationEntity's FieldInfo objects</summary>
		private void InitSysMltranslationEntityInfos()
		{
			base.AddElementFieldInfo("SysMltranslationEntity", "MltranslationId", typeof(System.Int32), true, false, true, false,  (int)SysMltranslationFieldIndex.MltranslationId, 0, 0, 10);
			base.AddElementFieldInfo("SysMltranslationEntity", "FkMltextId", typeof(System.Int32), false, false, false, false,  (int)SysMltranslationFieldIndex.FkMltextId, 0, 0, 10);
			base.AddElementFieldInfo("SysMltranslationEntity", "FkLanguageId", typeof(System.Int32), false, false, false, false,  (int)SysMltranslationFieldIndex.FkLanguageId, 0, 0, 10);
			base.AddElementFieldInfo("SysMltranslationEntity", "TranslatedValue", typeof(System.String), false, false, false, true,  (int)SysMltranslationFieldIndex.TranslatedValue, 2147483647, 0, 0);
		}
		/// <summary>Inits SysSettingEntity's FieldInfo objects</summary>
		private void InitSysSettingEntityInfos()
		{
			base.AddElementFieldInfo("SysSettingEntity", "SettingId", typeof(System.Int32), true, false, true, false,  (int)SysSettingFieldIndex.SettingId, 0, 0, 10);
			base.AddElementFieldInfo("SysSettingEntity", "SettingCategory", typeof(System.String), false, false, false, true,  (int)SysSettingFieldIndex.SettingCategory, 250, 0, 0);
			base.AddElementFieldInfo("SysSettingEntity", "SettingKey", typeof(System.String), false, false, false, true,  (int)SysSettingFieldIndex.SettingKey, 250, 0, 0);
			base.AddElementFieldInfo("SysSettingEntity", "SettingValue", typeof(System.String), false, false, false, true,  (int)SysSettingFieldIndex.SettingValue, 2147483647, 0, 0);
			base.AddElementFieldInfo("SysSettingEntity", "Description", typeof(System.String), false, false, false, true,  (int)SysSettingFieldIndex.Description, 250, 0, 0);
		}
		/// <summary>Inits SysTransactionEntity's FieldInfo objects</summary>
		private void InitSysTransactionEntityInfos()
		{
			base.AddElementFieldInfo("SysTransactionEntity", "TransactionId", typeof(System.Int32), true, false, true, false,  (int)SysTransactionFieldIndex.TransactionId, 0, 0, 10);
			base.AddElementFieldInfo("SysTransactionEntity", "TransactionDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SysTransactionFieldIndex.TransactionDate, 0, 0, 0);
			base.AddElementFieldInfo("SysTransactionEntity", "FkUserId", typeof(System.Int32), false, false, false, false,  (int)SysTransactionFieldIndex.FkUserId, 0, 0, 10);
			base.AddElementFieldInfo("SysTransactionEntity", "Username", typeof(System.String), false, false, false, true,  (int)SysTransactionFieldIndex.Username, 250, 0, 0);
			base.AddElementFieldInfo("SysTransactionEntity", "Method", typeof(System.String), false, false, false, true,  (int)SysTransactionFieldIndex.Method, 250, 0, 0);
			base.AddElementFieldInfo("SysTransactionEntity", "EntityName", typeof(System.String), false, false, false, true,  (int)SysTransactionFieldIndex.EntityName, 250, 0, 0);
			base.AddElementFieldInfo("SysTransactionEntity", "EntityId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SysTransactionFieldIndex.EntityId, 0, 0, 10);
			base.AddElementFieldInfo("SysTransactionEntity", "EntityTitle", typeof(System.String), false, false, false, true,  (int)SysTransactionFieldIndex.EntityTitle, 2147483647, 0, 0);
		}
		/// <summary>Inits SysUserEntity's FieldInfo objects</summary>
		private void InitSysUserEntityInfos()
		{
			base.AddElementFieldInfo("SysUserEntity", "UserId", typeof(System.Int32), true, false, true, false,  (int)SysUserFieldIndex.UserId, 0, 0, 10);
			base.AddElementFieldInfo("SysUserEntity", "Username", typeof(System.String), false, false, false, true,  (int)SysUserFieldIndex.Username, 250, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "DisplayName", typeof(System.String), false, false, false, true,  (int)SysUserFieldIndex.DisplayName, 500, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "Password", typeof(System.String), false, false, false, true,  (int)SysUserFieldIndex.Password, 250, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "Roles", typeof(System.String), false, false, false, true,  (int)SysUserFieldIndex.Roles, 2147483647, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "Email", typeof(System.String), false, false, false, true,  (int)SysUserFieldIndex.Email, 500, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "Website", typeof(System.String), false, false, false, true,  (int)SysUserFieldIndex.Website, 2147483647, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "LastLoginDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SysUserFieldIndex.LastLoginDate, 0, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "ImageFile", typeof(System.String), false, false, false, true,  (int)SysUserFieldIndex.ImageFile, 250, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "Description", typeof(System.String), false, false, false, true,  (int)SysUserFieldIndex.Description, 500, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "IsVisibleOnRightMenu", typeof(System.Boolean), false, false, false, false,  (int)SysUserFieldIndex.IsVisibleOnRightMenu, 0, 0, 0);
			base.AddElementFieldInfo("SysUserEntity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)SysUserFieldIndex.IsActive, 0, 0, 0);
		}
		/// <summary>Inits TagEntity's FieldInfo objects</summary>
		private void InitTagEntityInfos()
		{
			base.AddElementFieldInfo("TagEntity", "TagId", typeof(System.Int32), true, false, true, false,  (int)TagFieldIndex.TagId, 0, 0, 10);
			base.AddElementFieldInfo("TagEntity", "Title", typeof(System.String), false, false, false, true,  (int)TagFieldIndex.Title, 200, 0, 0);
			base.AddElementFieldInfo("TagEntity", "Description", typeof(System.String), false, false, false, true,  (int)TagFieldIndex.Description, 2147483647, 0, 0);
			base.AddElementFieldInfo("TagEntity", "Slug", typeof(System.String), false, false, false, true,  (int)TagFieldIndex.Slug, 200, 0, 0);
			base.AddElementFieldInfo("TagEntity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)TagFieldIndex.IsActive, 0, 0, 0);
		}
		/// <summary>Inits TeamEntity's FieldInfo objects</summary>
		private void InitTeamEntityInfos()
		{
			base.AddElementFieldInfo("TeamEntity", "TeamId", typeof(System.Int32), true, false, true, false,  (int)TeamFieldIndex.TeamId, 0, 0, 10);
			base.AddElementFieldInfo("TeamEntity", "Title", typeof(System.String), false, false, false, true,  (int)TeamFieldIndex.Title, 200, 0, 0);
			base.AddElementFieldInfo("TeamEntity", "Slug", typeof(System.String), false, false, false, true,  (int)TeamFieldIndex.Slug, 200, 0, 0);
			base.AddElementFieldInfo("TeamEntity", "ImageFile", typeof(System.String), false, false, false, true,  (int)TeamFieldIndex.ImageFile, 250, 0, 0);
			base.AddElementFieldInfo("TeamEntity", "Points", typeof(System.Int32), false, false, false, false,  (int)TeamFieldIndex.Points, 0, 0, 10);
			base.AddElementFieldInfo("TeamEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)TeamFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("TeamEntity", "OrderNo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TeamFieldIndex.OrderNo, 0, 0, 10);
		}
		/// <summary>Inits TeamPostEntity's FieldInfo objects</summary>
		private void InitTeamPostEntityInfos()
		{
			base.AddElementFieldInfo("TeamPostEntity", "TeamPostId", typeof(System.Int32), true, false, true, false,  (int)TeamPostFieldIndex.TeamPostId, 0, 0, 10);
			base.AddElementFieldInfo("TeamPostEntity", "FkTeamId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)TeamPostFieldIndex.FkTeamId, 0, 0, 10);
			base.AddElementFieldInfo("TeamPostEntity", "FkPostId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)TeamPostFieldIndex.FkPostId, 0, 0, 10);
		}
		/// <summary>Inits TextContentEntity's FieldInfo objects</summary>
		private void InitTextContentEntityInfos()
		{
			base.AddElementFieldInfo("TextContentEntity", "TextContentId", typeof(System.Int32), true, false, true, false,  (int)TextContentFieldIndex.TextContentId, 0, 0, 10);
			base.AddElementFieldInfo("TextContentEntity", "FtTitle", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TextContentFieldIndex.FtTitle, 0, 0, 10);
			base.AddElementFieldInfo("TextContentEntity", "FtMenuTitle", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TextContentFieldIndex.FtMenuTitle, 0, 0, 10);
			base.AddElementFieldInfo("TextContentEntity", "FtDescription", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TextContentFieldIndex.FtDescription, 0, 0, 10);
			base.AddElementFieldInfo("TextContentEntity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)TextContentFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("TextContentEntity", "TextContentKey", typeof(System.String), false, false, false, true,  (int)TextContentFieldIndex.TextContentKey, 250, 0, 0);
			base.AddElementFieldInfo("TextContentEntity", "FtMetaTitle", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TextContentFieldIndex.FtMetaTitle, 0, 0, 10);
			base.AddElementFieldInfo("TextContentEntity", "FtMetaKeywords", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TextContentFieldIndex.FtMetaKeywords, 0, 0, 10);
			base.AddElementFieldInfo("TextContentEntity", "FtMetaDescription", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TextContentFieldIndex.FtMetaDescription, 0, 0, 10);
		}
		/// <summary>Inits VideoEntity's FieldInfo objects</summary>
		private void InitVideoEntityInfos()
		{
			base.AddElementFieldInfo("VideoEntity", "VideoId", typeof(System.Int32), true, false, true, false,  (int)VideoFieldIndex.VideoId, 0, 0, 10);
			base.AddElementFieldInfo("VideoEntity", "Title", typeof(System.String), false, false, false, true,  (int)VideoFieldIndex.Title, 2147483647, 0, 0);
			base.AddElementFieldInfo("VideoEntity", "Link", typeof(System.String), false, false, false, true,  (int)VideoFieldIndex.Link, 2147483647, 0, 0);
			base.AddElementFieldInfo("VideoEntity", "DateCreated", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)VideoFieldIndex.DateCreated, 0, 0, 0);
			base.AddElementFieldInfo("VideoEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)VideoFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("VideoEntity", "OrderNo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)VideoFieldIndex.OrderNo, 0, 0, 10);
			base.AddElementFieldInfo("VideoEntity", "ReadCount", typeof(System.Int32), false, false, false, false,  (int)VideoFieldIndex.ReadCount, 0, 0, 10);
		}
		/// <summary>Inits WeeklyProgrammeDayEntity's FieldInfo objects</summary>
		private void InitWeeklyProgrammeDayEntityInfos()
		{
			base.AddElementFieldInfo("WeeklyProgrammeDayEntity", "WeeklyProgrammeDayId", typeof(System.Int32), true, false, true, false,  (int)WeeklyProgrammeDayFieldIndex.WeeklyProgrammeDayId, 0, 0, 10);
			base.AddElementFieldInfo("WeeklyProgrammeDayEntity", "Title", typeof(System.String), false, false, false, true,  (int)WeeklyProgrammeDayFieldIndex.Title, 100, 0, 0);
			base.AddElementFieldInfo("WeeklyProgrammeDayEntity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)WeeklyProgrammeDayFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("WeeklyProgrammeDayEntity", "OrderNo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)WeeklyProgrammeDayFieldIndex.OrderNo, 0, 0, 10);
		}
		/// <summary>Inits WeeklyProgrammeMatchEntity's FieldInfo objects</summary>
		private void InitWeeklyProgrammeMatchEntityInfos()
		{
			base.AddElementFieldInfo("WeeklyProgrammeMatchEntity", "WeeklyProgrammeMatchId", typeof(System.Int32), true, false, true, false,  (int)WeeklyProgrammeMatchFieldIndex.WeeklyProgrammeMatchId, 0, 0, 10);
			base.AddElementFieldInfo("WeeklyProgrammeMatchEntity", "FkWeeklyProgrammeDayId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)WeeklyProgrammeMatchFieldIndex.FkWeeklyProgrammeDayId, 0, 0, 10);
			base.AddElementFieldInfo("WeeklyProgrammeMatchEntity", "Time", typeof(System.String), false, false, false, true,  (int)WeeklyProgrammeMatchFieldIndex.Time, 50, 0, 0);
			base.AddElementFieldInfo("WeeklyProgrammeMatchEntity", "FkTeam1", typeof(Nullable<System.Int32>), false, true, false, true,  (int)WeeklyProgrammeMatchFieldIndex.FkTeam1, 0, 0, 10);
			base.AddElementFieldInfo("WeeklyProgrammeMatchEntity", "FkTeam2", typeof(Nullable<System.Int32>), false, true, false, true,  (int)WeeklyProgrammeMatchFieldIndex.FkTeam2, 0, 0, 10);
			base.AddElementFieldInfo("WeeklyProgrammeMatchEntity", "OrderNo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)WeeklyProgrammeMatchFieldIndex.OrderNo, 0, 0, 10);
			base.AddElementFieldInfo("WeeklyProgrammeMatchEntity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)WeeklyProgrammeMatchFieldIndex.IsActive, 0, 0, 0);
		}
		
	}
}




