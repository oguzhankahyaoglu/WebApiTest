///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 10 Eylül 2015 Perşembe 16:20:14
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

namespace LLBLGenTest.LLBL
{

	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Category1.
	/// </summary>
	public enum Category1FieldIndex:int
	{
		///<summary>Category1Id. </summary>
		Category1Id,
		///<summary>Title. </summary>
		Title,
		///<summary>MenuTitle. </summary>
		MenuTitle,
		///<summary>Description. </summary>
		Description,
		///<summary>Slug. </summary>
		Slug,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>IsShownInMainMenu. </summary>
		IsShownInMainMenu,
		///<summary>OrderNo. </summary>
		OrderNo,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Category1Post.
	/// </summary>
	public enum Category1PostFieldIndex:int
	{
		///<summary>Category1PostId. </summary>
		Category1PostId,
		///<summary>FkPostId. </summary>
		FkPostId,
		///<summary>FkCategory1Id. </summary>
		FkCategory1Id,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Category2.
	/// </summary>
	public enum Category2FieldIndex:int
	{
		///<summary>Category2Id. </summary>
		Category2Id,
		///<summary>Title. </summary>
		Title,
		///<summary>Description. </summary>
		Description,
		///<summary>FkCategory1Id. </summary>
		FkCategory1Id,
		///<summary>Slug. </summary>
		Slug,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>OrderNo. </summary>
		OrderNo,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Category2Post.
	/// </summary>
	public enum Category2PostFieldIndex:int
	{
		///<summary>Category2PostId. </summary>
		Category2PostId,
		///<summary>FkCategory2Id. </summary>
		FkCategory2Id,
		///<summary>FkPostId. </summary>
		FkPostId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MainPageBanner.
	/// </summary>
	public enum MainPageBannerFieldIndex:int
	{
		///<summary>MainPageBannerId. </summary>
		MainPageBannerId,
		///<summary>Title. </summary>
		Title,
		///<summary>Description. </summary>
		Description,
		///<summary>FkCategory1Id. </summary>
		FkCategory1Id,
		///<summary>ImageFile. </summary>
		ImageFile,
		///<summary>Date. </summary>
		Date,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>OrderNo. </summary>
		OrderNo,
		///<summary>Link. </summary>
		Link,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Post.
	/// </summary>
	public enum PostFieldIndex:int
	{
		///<summary>PostId. </summary>
		PostId,
		///<summary>Title. </summary>
		Title,
		///<summary>Description. </summary>
		Description,
		///<summary>ImageFile. </summary>
		ImageFile,
		///<summary>Slug. </summary>
		Slug,
		///<summary>FkAuthorId. </summary>
		FkAuthorId,
		///<summary>DateCreated. </summary>
		DateCreated,
		///<summary>CommentStatus. </summary>
		CommentStatus,
		///<summary>ReadCount. </summary>
		ReadCount,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>OrderNo. </summary>
		OrderNo,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PostAttachment.
	/// </summary>
	public enum PostAttachmentFieldIndex:int
	{
		///<summary>PostAttachmentId. </summary>
		PostAttachmentId,
		///<summary>CreateDate. </summary>
		CreateDate,
		///<summary>ImageFile. </summary>
		ImageFile,
		///<summary>FkPostId. </summary>
		FkPostId,
		///<summary>ImageFileUrl. </summary>
		ImageFileUrl,
		///<summary>MimeType. </summary>
		MimeType,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PostTag.
	/// </summary>
	public enum PostTagFieldIndex:int
	{
		///<summary>PostTagId. </summary>
		PostTagId,
		///<summary>FkPostId. </summary>
		FkPostId,
		///<summary>FkTagId. </summary>
		FkTagId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SysLanguage.
	/// </summary>
	public enum SysLanguageFieldIndex:int
	{
		///<summary>LanguageId. </summary>
		LanguageId,
		///<summary>Name. </summary>
		Name,
		///<summary>Code. </summary>
		Code,
		///<summary>Culture. </summary>
		Culture,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>IsPublishing. </summary>
		IsPublishing,
		///<summary>OrderNo. </summary>
		OrderNo,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SysLog.
	/// </summary>
	public enum SysLogFieldIndex:int
	{
		///<summary>LogId. </summary>
		LogId,
		///<summary>LogDate. </summary>
		LogDate,
		///<summary>LogTitle. </summary>
		LogTitle,
		///<summary>Content. </summary>
		Content,
		///<summary>LogLevel. </summary>
		LogLevel,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SysMltext.
	/// </summary>
	public enum SysMltextFieldIndex:int
	{
		///<summary>MltextId. </summary>
		MltextId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SysMltranslation.
	/// </summary>
	public enum SysMltranslationFieldIndex:int
	{
		///<summary>MltranslationId. </summary>
		MltranslationId,
		///<summary>FkMltextId. </summary>
		FkMltextId,
		///<summary>FkLanguageId. </summary>
		FkLanguageId,
		///<summary>TranslatedValue. </summary>
		TranslatedValue,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SysSetting.
	/// </summary>
	public enum SysSettingFieldIndex:int
	{
		///<summary>SettingId. </summary>
		SettingId,
		///<summary>SettingCategory. </summary>
		SettingCategory,
		///<summary>SettingKey. </summary>
		SettingKey,
		///<summary>SettingValue. </summary>
		SettingValue,
		///<summary>Description. </summary>
		Description,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SysTransaction.
	/// </summary>
	public enum SysTransactionFieldIndex:int
	{
		///<summary>TransactionId. </summary>
		TransactionId,
		///<summary>TransactionDate. </summary>
		TransactionDate,
		///<summary>FkUserId. </summary>
		FkUserId,
		///<summary>Username. </summary>
		Username,
		///<summary>Method. </summary>
		Method,
		///<summary>EntityName. </summary>
		EntityName,
		///<summary>EntityId. </summary>
		EntityId,
		///<summary>EntityTitle. </summary>
		EntityTitle,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SysUser.
	/// </summary>
	public enum SysUserFieldIndex:int
	{
		///<summary>UserId. </summary>
		UserId,
		///<summary>Username. </summary>
		Username,
		///<summary>DisplayName. </summary>
		DisplayName,
		///<summary>Password. </summary>
		Password,
		///<summary>Roles. </summary>
		Roles,
		///<summary>Email. </summary>
		Email,
		///<summary>Website. </summary>
		Website,
		///<summary>LastLoginDate. </summary>
		LastLoginDate,
		///<summary>ImageFile. </summary>
		ImageFile,
		///<summary>Description. </summary>
		Description,
		///<summary>IsVisibleOnRightMenu. </summary>
		IsVisibleOnRightMenu,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Tag.
	/// </summary>
	public enum TagFieldIndex:int
	{
		///<summary>TagId. </summary>
		TagId,
		///<summary>Title. </summary>
		Title,
		///<summary>Description. </summary>
		Description,
		///<summary>Slug. </summary>
		Slug,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Team.
	/// </summary>
	public enum TeamFieldIndex:int
	{
		///<summary>TeamId. </summary>
		TeamId,
		///<summary>Title. </summary>
		Title,
		///<summary>Slug. </summary>
		Slug,
		///<summary>ImageFile. </summary>
		ImageFile,
		///<summary>Points. </summary>
		Points,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>OrderNo. </summary>
		OrderNo,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TeamPost.
	/// </summary>
	public enum TeamPostFieldIndex:int
	{
		///<summary>TeamPostId. </summary>
		TeamPostId,
		///<summary>FkTeamId. </summary>
		FkTeamId,
		///<summary>FkPostId. </summary>
		FkPostId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TextContent.
	/// </summary>
	public enum TextContentFieldIndex:int
	{
		///<summary>TextContentId. </summary>
		TextContentId,
		///<summary>FtTitle. </summary>
		FtTitle,
		///<summary>FtMenuTitle. </summary>
		FtMenuTitle,
		///<summary>FtDescription. </summary>
		FtDescription,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>TextContentKey. </summary>
		TextContentKey,
		///<summary>FtMetaTitle. </summary>
		FtMetaTitle,
		///<summary>FtMetaKeywords. </summary>
		FtMetaKeywords,
		///<summary>FtMetaDescription. </summary>
		FtMetaDescription,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Video.
	/// </summary>
	public enum VideoFieldIndex:int
	{
		///<summary>VideoId. </summary>
		VideoId,
		///<summary>Title. </summary>
		Title,
		///<summary>Link. </summary>
		Link,
		///<summary>DateCreated. </summary>
		DateCreated,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>OrderNo. </summary>
		OrderNo,
		///<summary>ReadCount. </summary>
		ReadCount,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WeeklyProgrammeDay.
	/// </summary>
	public enum WeeklyProgrammeDayFieldIndex:int
	{
		///<summary>WeeklyProgrammeDayId. </summary>
		WeeklyProgrammeDayId,
		///<summary>Title. </summary>
		Title,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>OrderNo. </summary>
		OrderNo,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WeeklyProgrammeMatch.
	/// </summary>
	public enum WeeklyProgrammeMatchFieldIndex:int
	{
		///<summary>WeeklyProgrammeMatchId. </summary>
		WeeklyProgrammeMatchId,
		///<summary>FkWeeklyProgrammeDayId. </summary>
		FkWeeklyProgrammeDayId,
		///<summary>Time. </summary>
		Time,
		///<summary>FkTeam1. </summary>
		FkTeam1,
		///<summary>FkTeam2. </summary>
		FkTeam2,
		///<summary>OrderNo. </summary>
		OrderNo,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}





	/// <summary>
	/// Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.
	/// </summary>
	public enum EntityType:int
	{
		///<summary>Category1</summary>
		Category1Entity,
		///<summary>Category1Post</summary>
		Category1PostEntity,
		///<summary>Category2</summary>
		Category2Entity,
		///<summary>Category2Post</summary>
		Category2PostEntity,
		///<summary>MainPageBanner</summary>
		MainPageBannerEntity,
		///<summary>Post</summary>
		PostEntity,
		///<summary>PostAttachment</summary>
		PostAttachmentEntity,
		///<summary>PostTag</summary>
		PostTagEntity,
		///<summary>SysLanguage</summary>
		SysLanguageEntity,
		///<summary>SysLog</summary>
		SysLogEntity,
		///<summary>SysMltext</summary>
		SysMltextEntity,
		///<summary>SysMltranslation</summary>
		SysMltranslationEntity,
		///<summary>SysSetting</summary>
		SysSettingEntity,
		///<summary>SysTransaction</summary>
		SysTransactionEntity,
		///<summary>SysUser</summary>
		SysUserEntity,
		///<summary>Tag</summary>
		TagEntity,
		///<summary>Team</summary>
		TeamEntity,
		///<summary>TeamPost</summary>
		TeamPostEntity,
		///<summary>TextContent</summary>
		TextContentEntity,
		///<summary>Video</summary>
		VideoEntity,
		///<summary>WeeklyProgrammeDay</summary>
		WeeklyProgrammeDayEntity,
		///<summary>WeeklyProgrammeMatch</summary>
		WeeklyProgrammeMatchEntity
	}




	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}


