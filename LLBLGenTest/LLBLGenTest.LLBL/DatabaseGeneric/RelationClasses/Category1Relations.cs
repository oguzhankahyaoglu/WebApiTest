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
using System.Collections;
using System.Collections.Generic;
using LLBLGenTest.LLBL;
using LLBLGenTest.LLBL.FactoryClasses;
using LLBLGenTest.LLBL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.LLBL.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: Category1. </summary>
	public partial class Category1Relations
	{
		/// <summary>CTor</summary>
		public Category1Relations()
		{
		}

		/// <summary>Gets all relations of the Category1Entity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.Category1PostEntityUsingFkCategory1Id);
			toReturn.Add(this.Category2EntityUsingFkCategory1Id);
			toReturn.Add(this.MainPageBannerEntityUsingFkCategory1Id);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between Category1Entity and Category1PostEntity over the 1:n relation they have, using the relation between the fields:
		/// Category1.Category1Id - Category1Post.FkCategory1Id
		/// </summary>
		public virtual IEntityRelation Category1PostEntityUsingFkCategory1Id
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Category1Post" , true);
				relation.AddEntityFieldPair(Category1Fields.Category1Id, Category1PostFields.FkCategory1Id);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category1Entity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category1PostEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between Category1Entity and Category2Entity over the 1:n relation they have, using the relation between the fields:
		/// Category1.Category1Id - Category2.FkCategory1Id
		/// </summary>
		public virtual IEntityRelation Category2EntityUsingFkCategory1Id
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Category2" , true);
				relation.AddEntityFieldPair(Category1Fields.Category1Id, Category2Fields.FkCategory1Id);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category1Entity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category2Entity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between Category1Entity and MainPageBannerEntity over the 1:n relation they have, using the relation between the fields:
		/// Category1.Category1Id - MainPageBanner.FkCategory1Id
		/// </summary>
		public virtual IEntityRelation MainPageBannerEntityUsingFkCategory1Id
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "MainPageBanner" , true);
				relation.AddEntityFieldPair(Category1Fields.Category1Id, MainPageBannerFields.FkCategory1Id);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category1Entity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MainPageBannerEntity", false);
				return relation;
			}
		}



		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
