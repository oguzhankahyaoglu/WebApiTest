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
	/// <summary>Implements the static Relations variant for the entity: Category1Post. </summary>
	public partial class Category1PostRelations
	{
		/// <summary>CTor</summary>
		public Category1PostRelations()
		{
		}

		/// <summary>Gets all relations of the Category1PostEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.Category1EntityUsingFkCategory1Id);
			toReturn.Add(this.PostEntityUsingFkPostId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between Category1PostEntity and Category1Entity over the m:1 relation they have, using the relation between the fields:
		/// Category1Post.FkCategory1Id - Category1.Category1Id
		/// </summary>
		public virtual IEntityRelation Category1EntityUsingFkCategory1Id
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Category1", false);
				relation.AddEntityFieldPair(Category1Fields.Category1Id, Category1PostFields.FkCategory1Id);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category1Entity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category1PostEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between Category1PostEntity and PostEntity over the m:1 relation they have, using the relation between the fields:
		/// Category1Post.FkPostId - Post.PostId
		/// </summary>
		public virtual IEntityRelation PostEntityUsingFkPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Post", false);
				relation.AddEntityFieldPair(PostFields.PostId, Category1PostFields.FkPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category1PostEntity", true);
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
