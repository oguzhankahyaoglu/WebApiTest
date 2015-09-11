///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 10 Eylül 2015 Perşembe 16:20:16
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

using LLBLGenTest.LLBL;
using LLBLGenTest.LLBL.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.LLBL.FactoryClasses
{
	/// <summary>
	/// Factory class for IEntityField2 instances, used in IEntityFields2 instances.
	/// </summary>
	public partial class EntityFieldFactory
	{
		/// <summary> Private CTor, no instantiation possible.</summary>
		private EntityFieldFactory()
		{
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the Category1Entity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(Category1FieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("Category1Entity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the Category1PostEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(Category1PostFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("Category1PostEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the Category2Entity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(Category2FieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("Category2Entity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the Category2PostEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(Category2PostFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("Category2PostEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the MainPageBannerEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(MainPageBannerFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MainPageBannerEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the PostEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(PostFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("PostEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the PostAttachmentEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(PostAttachmentFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("PostAttachmentEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the PostTagEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(PostTagFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("PostTagEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the SysLanguageEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(SysLanguageFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SysLanguageEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the SysLogEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(SysLogFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SysLogEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the SysMltextEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(SysMltextFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SysMltextEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the SysMltranslationEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(SysMltranslationFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SysMltranslationEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the SysSettingEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(SysSettingFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SysSettingEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the SysTransactionEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(SysTransactionFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SysTransactionEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the SysUserEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(SysUserFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SysUserEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the TagEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(TagFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("TagEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the TeamEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(TeamFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("TeamEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the TeamPostEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(TeamPostFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("TeamPostEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the TextContentEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(TextContentFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("TextContentEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the VideoEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(VideoFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("VideoEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the WeeklyProgrammeDayEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(WeeklyProgrammeDayFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("WeeklyProgrammeDayEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the WeeklyProgrammeMatchEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(WeeklyProgrammeMatchFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("WeeklyProgrammeMatchEntity", (int)fieldIndex));
		}


		/// <summary>Creates a new IEntityField2 instance, which represents the field objectName.fieldName</summary>
		/// <param name="objectName">the name of the object the field belongs to, like CustomerEntity or OrdersTypedView</param>
		/// <param name="fieldName">the name of the field to create</param>
		public static IEntityField2 Create(string objectName, string fieldName)
        {
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(objectName, fieldName));
        }

		#region Included Code

		#endregion
	}
}
