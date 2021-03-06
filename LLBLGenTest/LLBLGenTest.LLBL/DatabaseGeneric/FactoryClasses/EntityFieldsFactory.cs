﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Generates IEntityFields2 instances for different kind of Entities.</summary>
	public partial class EntityFieldsFactory
	{
		/// <summary>Private CTor, no instantiation possible.</summary>
		private EntityFieldsFactory()
		{
		}

		/// <summary>General factory entrance method which will return an EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields2 instance requested</returns>
		public static IEntityFields2 CreateEntityFieldsObject(LLBLGenTest.LLBL.EntityType relatedEntityType)
		{
			IEntityFields2 fieldsToReturn=null;
			IInheritanceInfoProvider inheritanceProvider = InheritanceInfoProviderSingleton.GetInstance();
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			switch(relatedEntityType)
			{
				case LLBLGenTest.LLBL.EntityType.Category1Entity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "Category1Entity");
					break;
				case LLBLGenTest.LLBL.EntityType.Category1PostEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "Category1PostEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.Category2Entity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "Category2Entity");
					break;
				case LLBLGenTest.LLBL.EntityType.Category2PostEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "Category2PostEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.MainPageBannerEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "MainPageBannerEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.PostEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "PostEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.PostAttachmentEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "PostAttachmentEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.PostTagEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "PostTagEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.SysLanguageEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SysLanguageEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.SysLogEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SysLogEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.SysMltextEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SysMltextEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.SysMltranslationEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SysMltranslationEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.SysSettingEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SysSettingEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.SysTransactionEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SysTransactionEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.SysUserEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SysUserEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.TagEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "TagEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.TeamEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "TeamEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.TeamPostEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "TeamPostEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.TextContentEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "TextContentEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.VideoEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "VideoEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "WeeklyProgrammeDayEntity");
					break;
				case LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "WeeklyProgrammeMatchEntity");
					break;
			}
			return fieldsToReturn;
		}
		
		/// <summary>General method which will return an array of IEntityFieldCore objects, used by the InheritanceInfoProvider. Only the fields defined in the entity are returned, no inherited fields.</summary>
		/// <param name="entityName">the name of the entity to get the fields for. Example: "CustomerEntity"</param>
		/// <returns>array of IEntityFieldCore fields, defined in the entity with the name specified</returns>
		internal static IEntityFieldCore[] CreateFields(string entityName)
		{
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			return fieldProvider.GetEntityFieldsArray(entityName);
		}
		



		#region Included Code

		#endregion
	}
}
