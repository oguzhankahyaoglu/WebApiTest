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
using System.Collections;
using System.Collections.Generic;
using LLBLGenTest.LLBL;
using LLBLGenTest.LLBL.FactoryClasses;
using LLBLGenTest.LLBL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.LLBL.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: Category2. </summary>
	public partial class Category2Relations
	{
		/// <summary>CTor</summary>
		public Category2Relations()
		{
		}

		/// <summary>Gets all relations of the Category2Entity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.Category2PostEntityUsingFkCategory2Id);

			toReturn.Add(this.Category1EntityUsingFkCategory1Id);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between Category2Entity and Category2PostEntity over the 1:n relation they have, using the relation between the fields:
		/// Category2.Category2Id - Category2Post.FkCategory2Id
		/// </summary>
		public virtual IEntityRelation Category2PostEntityUsingFkCategory2Id
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Category2Post" , true);
				relation.AddEntityFieldPair(Category2Fields.Category2Id, Category2PostFields.FkCategory2Id);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category2Entity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category2PostEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between Category2Entity and Category1Entity over the m:1 relation they have, using the relation between the fields:
		/// Category2.FkCategory1Id - Category1.Category1Id
		/// </summary>
		public virtual IEntityRelation Category1EntityUsingFkCategory1Id
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Category1", false);
				relation.AddEntityFieldPair(Category1Fields.Category1Id, Category2Fields.FkCategory1Id);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category1Entity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category2Entity", true);
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
