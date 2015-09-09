///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 09 Eylül 2015 Çarşamba 16:20:10
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using LLBLGenTest.LLBL;
using LLBLGenTest.LLBL.HelperClasses;
using LLBLGenTest.LLBL.FactoryClasses;
using LLBLGenTest.LLBL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.LLBL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'Post'.
	/// </summary>
	[Serializable]
	public partial class MyPostEntity : PostEntity, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		/// <summary> CTor</summary>
		public MyPostEntity()
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MyPostEntity(IEntityFields2 fields):base(fields)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PostEntity</param>
		public MyPostEntity(IValidator validator):base(validator)
		{
			InitClass();
		}
				

		/// <summary> CTor</summary>
		/// <param name="postId">PK value for Post which data should be fetched into this Post object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyPostEntity(System.Int32 postId):base(postId)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="postId">PK value for Post which data should be fetched into this Post object</param>
		/// <param name="validator">The custom validator object for this PostEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyPostEntity(System.Int32 postId, IValidator validator):base(postId, validator)
		{
			InitClass();
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MyPostEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			InitClass();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new MyPostEntityFactory();
		}
		
		/// <summary>Initialization routine for class</summary>
		private void InitClass()
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		#region Class Property Declarations

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category1Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathCategory1Post
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyCategory1PostEntityFactory()),
					PostEntity.Relations.Category1PostEntityUsingFkPostId, 
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.Category1PostEntity, 0, null, null, null, null, "Category1Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category2Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathCategory2Post
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyCategory2PostEntityFactory()),
					PostEntity.Relations.Category2PostEntityUsingFkPostId, 
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.Category2PostEntity, 0, null, null, null, null, "Category2Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PostAttachment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathPostAttachment
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyPostAttachmentEntityFactory()),
					PostEntity.Relations.PostAttachmentEntityUsingFkPostId, 
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.PostAttachmentEntity, 0, null, null, null, null, "PostAttachment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PostTag' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathPostTag
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyPostTagEntityFactory()),
					PostEntity.Relations.PostTagEntityUsingFkPostId, 
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.PostTagEntity, 0, null, null, null, null, "PostTag", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TeamPost' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathTeamPost
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyTeamPostEntityFactory()),
					PostEntity.Relations.TeamPostEntityUsingFkPostId, 
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.TeamPostEntity, 0, null, null, null, null, "TeamPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category1' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathCategory1CollectionViaCategory1Post
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = PostEntity.Relations.Category1PostEntityUsingFkPostId;
				intermediateRelation.SetAliases(string.Empty, "Category1Post_");
				relations.Add(PostEntity.Relations.Category1PostEntityUsingFkPostId, "PostEntity__", "Category1Post_", JoinHint.None);
				relations.Add(Category1PostEntity.Relations.Category1EntityUsingFkCategory1Id, "Category1Post_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyCategory1EntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.Category1Entity, 0, null, null, relations, null, "Category1CollectionViaCategory1Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category2' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathCategory2CollectionViaCategory2Post
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = PostEntity.Relations.Category2PostEntityUsingFkPostId;
				intermediateRelation.SetAliases(string.Empty, "Category2Post_");
				relations.Add(PostEntity.Relations.Category2PostEntityUsingFkPostId, "PostEntity__", "Category2Post_", JoinHint.None);
				relations.Add(Category2PostEntity.Relations.Category2EntityUsingFkCategory2Id, "Category2Post_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyCategory2EntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.Category2Entity, 0, null, null, relations, null, "Category2CollectionViaCategory2Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Tag' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathTagCollectionViaPostTag
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = PostEntity.Relations.PostTagEntityUsingFkPostId;
				intermediateRelation.SetAliases(string.Empty, "PostTag_");
				relations.Add(PostEntity.Relations.PostTagEntityUsingFkPostId, "PostEntity__", "PostTag_", JoinHint.None);
				relations.Add(PostTagEntity.Relations.TagEntityUsingFkTagId, "PostTag_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyTagEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.TagEntity, 0, null, null, relations, null, "TagCollectionViaPostTag", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathTeamCollectionViaTeamPost
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = PostEntity.Relations.TeamPostEntityUsingFkPostId;
				intermediateRelation.SetAliases(string.Empty, "TeamPost_");
				relations.Add(PostEntity.Relations.TeamPostEntityUsingFkPostId, "PostEntity__", "TeamPost_", JoinHint.None);
				relations.Add(TeamPostEntity.Relations.TeamEntityUsingFkTeamId, "TeamPost_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyTeamEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, 0, null, null, relations, null, "TeamCollectionViaTeamPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SysUser' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathSysUser
		{
			get
			{
				return new PrefetchPathElement2(
					new EntityCollection(new MySysUserEntityFactory()),
					PostEntity.Relations.SysUserEntityUsingFkAuthorId, 
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.SysUserEntity, 0, null, null, null, null, "SysUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyCategory1PostEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyCategory1PostEntity))]
		public override EntityCollection<Category1PostEntity> Category1Post
		{
			get
			{
				EntityCollection<Category1PostEntity> toReturn = base.Category1Post;
				toReturn.EntityFactoryToUse = new MyCategory1PostEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyCategory2PostEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyCategory2PostEntity))]
		public override EntityCollection<Category2PostEntity> Category2Post
		{
			get
			{
				EntityCollection<Category2PostEntity> toReturn = base.Category2Post;
				toReturn.EntityFactoryToUse = new MyCategory2PostEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyPostAttachmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyPostAttachmentEntity))]
		public override EntityCollection<PostAttachmentEntity> PostAttachment
		{
			get
			{
				EntityCollection<PostAttachmentEntity> toReturn = base.PostAttachment;
				toReturn.EntityFactoryToUse = new MyPostAttachmentEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyPostTagEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyPostTagEntity))]
		public override EntityCollection<PostTagEntity> PostTag
		{
			get
			{
				EntityCollection<PostTagEntity> toReturn = base.PostTag;
				toReturn.EntityFactoryToUse = new MyPostTagEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyTeamPostEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyTeamPostEntity))]
		public override EntityCollection<TeamPostEntity> TeamPost
		{
			get
			{
				EntityCollection<TeamPostEntity> toReturn = base.TeamPost;
				toReturn.EntityFactoryToUse = new MyTeamPostEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyCategory1Entity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyCategory1Entity))]
		public override EntityCollection<Category1Entity> Category1CollectionViaCategory1Post
		{
			get
			{
				EntityCollection<Category1Entity> toReturn = base.Category1CollectionViaCategory1Post;
				toReturn.EntityFactoryToUse = new MyCategory1EntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyCategory2Entity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyCategory2Entity))]
		public override EntityCollection<Category2Entity> Category2CollectionViaCategory2Post
		{
			get
			{
				EntityCollection<Category2Entity> toReturn = base.Category2CollectionViaCategory2Post;
				toReturn.EntityFactoryToUse = new MyCategory2EntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyTagEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyTagEntity))]
		public override EntityCollection<TagEntity> TagCollectionViaPostTag
		{
			get
			{
				EntityCollection<TagEntity> toReturn = base.TagCollectionViaPostTag;
				toReturn.EntityFactoryToUse = new MyTagEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyTeamEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyTeamEntity))]
		public override EntityCollection<TeamEntity> TeamCollectionViaTeamPost
		{
			get
			{
				EntityCollection<TeamEntity> toReturn = base.TeamCollectionViaTeamPost;
				toReturn.EntityFactoryToUse = new MyTeamEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets / sets related entity of type 'MySysUserEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned.
		/// This property is not visible in databinded grids.
		/// </summary>
		[Browsable(false)]
		public new virtual MySysUserEntity SysUser
		{
			get	{ return (MySysUserEntity)base.SysUser; }
			set	{ base.SysUser = value;	}
		}

		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
	}
}
