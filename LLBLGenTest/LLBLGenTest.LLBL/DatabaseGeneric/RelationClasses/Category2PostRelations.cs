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
	/// <summary>Implements the static Relations variant for the entity: Category2Post. </summary>
	public partial class Category2PostRelations
	{
		/// <summary>CTor</summary>
		public Category2PostRelations()
		{
		}

		/// <summary>Gets all relations of the Category2PostEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.Category2EntityUsingFkCategory2Id);
			toReturn.Add(this.PostEntityUsingFkPostId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between Category2PostEntity and Category2Entity over the m:1 relation they have, using the relation between the fields:
		/// Category2Post.FkCategory2Id - Category2.Category2Id
		/// </summary>
		public virtual IEntityRelation Category2EntityUsingFkCategory2Id
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Category2", false);
				relation.AddEntityFieldPair(Category2Fields.Category2Id, Category2PostFields.FkCategory2Id);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category2Entity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category2PostEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between Category2PostEntity and PostEntity over the m:1 relation they have, using the relation between the fields:
		/// Category2Post.FkPostId - Post.PostId
		/// </summary>
		public virtual IEntityRelation PostEntityUsingFkPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Post", false);
				relation.AddEntityFieldPair(PostFields.PostId, Category2PostFields.FkPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category2PostEntity", true);
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
