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
	/// <summary>Implements the static Relations variant for the entity: Post. </summary>
	public partial class PostRelations
	{
		/// <summary>CTor</summary>
		public PostRelations()
		{
		}

		/// <summary>Gets all relations of the PostEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.Category1PostEntityUsingFkPostId);
			toReturn.Add(this.Category2PostEntityUsingFkPostId);
			toReturn.Add(this.PostAttachmentEntityUsingFkPostId);
			toReturn.Add(this.PostTagEntityUsingFkPostId);
			toReturn.Add(this.TeamPostEntityUsingFkPostId);

			toReturn.Add(this.SysUserEntityUsingFkAuthorId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PostEntity and Category1PostEntity over the 1:n relation they have, using the relation between the fields:
		/// Post.PostId - Category1Post.FkPostId
		/// </summary>
		public virtual IEntityRelation Category1PostEntityUsingFkPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Category1Post" , true);
				relation.AddEntityFieldPair(PostFields.PostId, Category1PostFields.FkPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category1PostEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PostEntity and Category2PostEntity over the 1:n relation they have, using the relation between the fields:
		/// Post.PostId - Category2Post.FkPostId
		/// </summary>
		public virtual IEntityRelation Category2PostEntityUsingFkPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Category2Post" , true);
				relation.AddEntityFieldPair(PostFields.PostId, Category2PostFields.FkPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("Category2PostEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PostEntity and PostAttachmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Post.PostId - PostAttachment.FkPostId
		/// </summary>
		public virtual IEntityRelation PostAttachmentEntityUsingFkPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PostAttachment" , true);
				relation.AddEntityFieldPair(PostFields.PostId, PostAttachmentFields.FkPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostAttachmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PostEntity and PostTagEntity over the 1:n relation they have, using the relation between the fields:
		/// Post.PostId - PostTag.FkPostId
		/// </summary>
		public virtual IEntityRelation PostTagEntityUsingFkPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PostTag" , true);
				relation.AddEntityFieldPair(PostFields.PostId, PostTagFields.FkPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostTagEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PostEntity and TeamPostEntity over the 1:n relation they have, using the relation between the fields:
		/// Post.PostId - TeamPost.FkPostId
		/// </summary>
		public virtual IEntityRelation TeamPostEntityUsingFkPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "TeamPost" , true);
				relation.AddEntityFieldPair(PostFields.PostId, TeamPostFields.FkPostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TeamPostEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PostEntity and SysUserEntity over the m:1 relation they have, using the relation between the fields:
		/// Post.FkAuthorId - SysUser.UserId
		/// </summary>
		public virtual IEntityRelation SysUserEntityUsingFkAuthorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SysUser", false);
				relation.AddEntityFieldPair(SysUserFields.UserId, PostFields.FkAuthorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SysUserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", true);
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
