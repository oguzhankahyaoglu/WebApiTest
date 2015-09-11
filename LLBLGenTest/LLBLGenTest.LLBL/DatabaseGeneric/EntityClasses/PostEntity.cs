///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 10 Eylül 2015 Perşembe 16:20:15
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
	/// Entity class which represents the entity 'Post'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class PostEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<Category1PostEntity> _category1Post;
		private EntityCollection<Category2PostEntity> _category2Post;
		private EntityCollection<PostAttachmentEntity> _postAttachment;
		private EntityCollection<PostTagEntity> _postTag;
		private EntityCollection<TeamPostEntity> _teamPost;
		private EntityCollection<Category1Entity> _category1CollectionViaCategory1Post;
		private EntityCollection<Category2Entity> _category2CollectionViaCategory2Post;
		private EntityCollection<TagEntity> _tagCollectionViaPostTag;
		private EntityCollection<TeamEntity> _teamCollectionViaTeamPost;
		private SysUserEntity _sysUser;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SysUser</summary>
			public static readonly string SysUser = "SysUser";
			/// <summary>Member name Category1Post</summary>
			public static readonly string Category1Post = "Category1Post";
			/// <summary>Member name Category2Post</summary>
			public static readonly string Category2Post = "Category2Post";
			/// <summary>Member name PostAttachment</summary>
			public static readonly string PostAttachment = "PostAttachment";
			/// <summary>Member name PostTag</summary>
			public static readonly string PostTag = "PostTag";
			/// <summary>Member name TeamPost</summary>
			public static readonly string TeamPost = "TeamPost";
			/// <summary>Member name Category1CollectionViaCategory1Post</summary>
			public static readonly string Category1CollectionViaCategory1Post = "Category1CollectionViaCategory1Post";
			/// <summary>Member name Category2CollectionViaCategory2Post</summary>
			public static readonly string Category2CollectionViaCategory2Post = "Category2CollectionViaCategory2Post";
			/// <summary>Member name TagCollectionViaPostTag</summary>
			public static readonly string TagCollectionViaPostTag = "TagCollectionViaPostTag";
			/// <summary>Member name TeamCollectionViaTeamPost</summary>
			public static readonly string TeamCollectionViaTeamPost = "TeamCollectionViaTeamPost";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PostEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public PostEntity():base("PostEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PostEntity(IEntityFields2 fields):base("PostEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PostEntity</param>
		public PostEntity(IValidator validator):base("PostEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="postId">PK value for Post which data should be fetched into this Post object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PostEntity(System.Int32 postId):base("PostEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.PostId = postId;
		}

		/// <summary> CTor</summary>
		/// <param name="postId">PK value for Post which data should be fetched into this Post object</param>
		/// <param name="validator">The custom validator object for this PostEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PostEntity(System.Int32 postId, IValidator validator):base("PostEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.PostId = postId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PostEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_category1Post = (EntityCollection<Category1PostEntity>)info.GetValue("_category1Post", typeof(EntityCollection<Category1PostEntity>));
				_category2Post = (EntityCollection<Category2PostEntity>)info.GetValue("_category2Post", typeof(EntityCollection<Category2PostEntity>));
				_postAttachment = (EntityCollection<PostAttachmentEntity>)info.GetValue("_postAttachment", typeof(EntityCollection<PostAttachmentEntity>));
				_postTag = (EntityCollection<PostTagEntity>)info.GetValue("_postTag", typeof(EntityCollection<PostTagEntity>));
				_teamPost = (EntityCollection<TeamPostEntity>)info.GetValue("_teamPost", typeof(EntityCollection<TeamPostEntity>));
				_category1CollectionViaCategory1Post = (EntityCollection<Category1Entity>)info.GetValue("_category1CollectionViaCategory1Post", typeof(EntityCollection<Category1Entity>));
				_category2CollectionViaCategory2Post = (EntityCollection<Category2Entity>)info.GetValue("_category2CollectionViaCategory2Post", typeof(EntityCollection<Category2Entity>));
				_tagCollectionViaPostTag = (EntityCollection<TagEntity>)info.GetValue("_tagCollectionViaPostTag", typeof(EntityCollection<TagEntity>));
				_teamCollectionViaTeamPost = (EntityCollection<TeamEntity>)info.GetValue("_teamCollectionViaTeamPost", typeof(EntityCollection<TeamEntity>));
				_sysUser = (SysUserEntity)info.GetValue("_sysUser", typeof(SysUserEntity));
				if(_sysUser!=null)
				{
					_sysUser.AfterSave+=new EventHandler(OnEntityAfterSave);
				}

				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((PostFieldIndex)fieldIndex)
			{
				case PostFieldIndex.FkAuthorId:
					DesetupSyncSysUser(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
				
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{
				case "SysUser":
					this.SysUser = (SysUserEntity)entity;
					break;
				case "Category1Post":
					this.Category1Post.Add((Category1PostEntity)entity);
					break;
				case "Category2Post":
					this.Category2Post.Add((Category2PostEntity)entity);
					break;
				case "PostAttachment":
					this.PostAttachment.Add((PostAttachmentEntity)entity);
					break;
				case "PostTag":
					this.PostTag.Add((PostTagEntity)entity);
					break;
				case "TeamPost":
					this.TeamPost.Add((TeamPostEntity)entity);
					break;
				case "Category1CollectionViaCategory1Post":
					this.Category1CollectionViaCategory1Post.IsReadOnly = false;
					this.Category1CollectionViaCategory1Post.Add((Category1Entity)entity);
					this.Category1CollectionViaCategory1Post.IsReadOnly = true;
					break;
				case "Category2CollectionViaCategory2Post":
					this.Category2CollectionViaCategory2Post.IsReadOnly = false;
					this.Category2CollectionViaCategory2Post.Add((Category2Entity)entity);
					this.Category2CollectionViaCategory2Post.IsReadOnly = true;
					break;
				case "TagCollectionViaPostTag":
					this.TagCollectionViaPostTag.IsReadOnly = false;
					this.TagCollectionViaPostTag.Add((TagEntity)entity);
					this.TagCollectionViaPostTag.IsReadOnly = true;
					break;
				case "TeamCollectionViaTeamPost":
					this.TeamCollectionViaTeamPost.IsReadOnly = false;
					this.TeamCollectionViaTeamPost.Add((TeamEntity)entity);
					this.TeamCollectionViaTeamPost.IsReadOnly = true;
					break;

				default:
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return PostEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "SysUser":
					toReturn.Add(PostEntity.Relations.SysUserEntityUsingFkAuthorId);
					break;
				case "Category1Post":
					toReturn.Add(PostEntity.Relations.Category1PostEntityUsingFkPostId);
					break;
				case "Category2Post":
					toReturn.Add(PostEntity.Relations.Category2PostEntityUsingFkPostId);
					break;
				case "PostAttachment":
					toReturn.Add(PostEntity.Relations.PostAttachmentEntityUsingFkPostId);
					break;
				case "PostTag":
					toReturn.Add(PostEntity.Relations.PostTagEntityUsingFkPostId);
					break;
				case "TeamPost":
					toReturn.Add(PostEntity.Relations.TeamPostEntityUsingFkPostId);
					break;
				case "Category1CollectionViaCategory1Post":
					toReturn.Add(PostEntity.Relations.Category1PostEntityUsingFkPostId, "PostEntity__", "Category1Post_", JoinHint.None);
					toReturn.Add(Category1PostEntity.Relations.Category1EntityUsingFkCategory1Id, "Category1Post_", string.Empty, JoinHint.None);
					break;
				case "Category2CollectionViaCategory2Post":
					toReturn.Add(PostEntity.Relations.Category2PostEntityUsingFkPostId, "PostEntity__", "Category2Post_", JoinHint.None);
					toReturn.Add(Category2PostEntity.Relations.Category2EntityUsingFkCategory2Id, "Category2Post_", string.Empty, JoinHint.None);
					break;
				case "TagCollectionViaPostTag":
					toReturn.Add(PostEntity.Relations.PostTagEntityUsingFkPostId, "PostEntity__", "PostTag_", JoinHint.None);
					toReturn.Add(PostTagEntity.Relations.TagEntityUsingFkTagId, "PostTag_", string.Empty, JoinHint.None);
					break;
				case "TeamCollectionViaTeamPost":
					toReturn.Add(PostEntity.Relations.TeamPostEntityUsingFkPostId, "PostEntity__", "TeamPost_", JoinHint.None);
					toReturn.Add(TeamPostEntity.Relations.TeamEntityUsingFkTeamId, "TeamPost_", string.Empty, JoinHint.None);
					break;

				default:

					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it
		/// will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckOneWayRelations(string propertyName)
		{
			// use template trick to calculate the # of single-sided / oneway relations
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));


				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "SysUser":
					SetupSyncSysUser(relatedEntity);
					break;
				case "Category1Post":
					this.Category1Post.Add((Category1PostEntity)relatedEntity);
					break;
				case "Category2Post":
					this.Category2Post.Add((Category2PostEntity)relatedEntity);
					break;
				case "PostAttachment":
					this.PostAttachment.Add((PostAttachmentEntity)relatedEntity);
					break;
				case "PostTag":
					this.PostTag.Add((PostTagEntity)relatedEntity);
					break;
				case "TeamPost":
					this.TeamPost.Add((TeamPostEntity)relatedEntity);
					break;

				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "SysUser":
					DesetupSyncSysUser(false, true);
					break;
				case "Category1Post":
					base.PerformRelatedEntityRemoval(this.Category1Post, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Category2Post":
					base.PerformRelatedEntityRemoval(this.Category2Post, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PostAttachment":
					base.PerformRelatedEntityRemoval(this.PostAttachment, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PostTag":
					base.PerformRelatedEntityRemoval(this.PostTag, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "TeamPost":
					base.PerformRelatedEntityRemoval(this.TeamPost, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_sysUser!=null)
			{
				toReturn.Add(_sysUser);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Category1Post);
			toReturn.Add(this.Category2Post);
			toReturn.Add(this.PostAttachment);
			toReturn.Add(this.PostTag);
			toReturn.Add(this.TeamPost);

			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_category1Post", ((_category1Post!=null) && (_category1Post.Count>0) && !this.MarkedForDeletion)?_category1Post:null);
				info.AddValue("_category2Post", ((_category2Post!=null) && (_category2Post.Count>0) && !this.MarkedForDeletion)?_category2Post:null);
				info.AddValue("_postAttachment", ((_postAttachment!=null) && (_postAttachment.Count>0) && !this.MarkedForDeletion)?_postAttachment:null);
				info.AddValue("_postTag", ((_postTag!=null) && (_postTag.Count>0) && !this.MarkedForDeletion)?_postTag:null);
				info.AddValue("_teamPost", ((_teamPost!=null) && (_teamPost.Count>0) && !this.MarkedForDeletion)?_teamPost:null);
				info.AddValue("_category1CollectionViaCategory1Post", ((_category1CollectionViaCategory1Post!=null) && (_category1CollectionViaCategory1Post.Count>0) && !this.MarkedForDeletion)?_category1CollectionViaCategory1Post:null);
				info.AddValue("_category2CollectionViaCategory2Post", ((_category2CollectionViaCategory2Post!=null) && (_category2CollectionViaCategory2Post.Count>0) && !this.MarkedForDeletion)?_category2CollectionViaCategory2Post:null);
				info.AddValue("_tagCollectionViaPostTag", ((_tagCollectionViaPostTag!=null) && (_tagCollectionViaPostTag.Count>0) && !this.MarkedForDeletion)?_tagCollectionViaPostTag:null);
				info.AddValue("_teamCollectionViaTeamPost", ((_teamCollectionViaTeamPost!=null) && (_teamCollectionViaTeamPost.Count>0) && !this.MarkedForDeletion)?_teamCollectionViaTeamPost:null);
				info.AddValue("_sysUser", (!this.MarkedForDeletion?_sysUser:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(PostFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(PostFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new PostRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Category1Post' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory1Post()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(Category1PostFields.FkPostId, null, ComparisonOperator.Equal, this.PostId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Category2Post' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory2Post()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(Category2PostFields.FkPostId, null, ComparisonOperator.Equal, this.PostId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'PostAttachment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPostAttachment()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PostAttachmentFields.FkPostId, null, ComparisonOperator.Equal, this.PostId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'PostTag' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPostTag()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PostTagFields.FkPostId, null, ComparisonOperator.Equal, this.PostId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'TeamPost' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTeamPost()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TeamPostFields.FkPostId, null, ComparisonOperator.Equal, this.PostId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Category1' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory1CollectionViaCategory1Post()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("Category1CollectionViaCategory1Post"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PostFields.PostId, null, ComparisonOperator.Equal, this.PostId, "PostEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Category2' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory2CollectionViaCategory2Post()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("Category2CollectionViaCategory2Post"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PostFields.PostId, null, ComparisonOperator.Equal, this.PostId, "PostEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Tag' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTagCollectionViaPostTag()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("TagCollectionViaPostTag"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PostFields.PostId, null, ComparisonOperator.Equal, this.PostId, "PostEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Team' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTeamCollectionViaTeamPost()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("TeamCollectionViaTeamPost"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PostFields.PostId, null, ComparisonOperator.Equal, this.PostId, "PostEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'SysUser' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSysUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SysUserFields.UserId, null, ComparisonOperator.Equal, this.FkAuthorId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(LLBLGenTest.LLBL.EntityType.PostEntity);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._category1Post);
			collectionsQueue.Enqueue(this._category2Post);
			collectionsQueue.Enqueue(this._postAttachment);
			collectionsQueue.Enqueue(this._postTag);
			collectionsQueue.Enqueue(this._teamPost);
			collectionsQueue.Enqueue(this._category1CollectionViaCategory1Post);
			collectionsQueue.Enqueue(this._category2CollectionViaCategory2Post);
			collectionsQueue.Enqueue(this._tagCollectionViaPostTag);
			collectionsQueue.Enqueue(this._teamCollectionViaTeamPost);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._category1Post = (EntityCollection<Category1PostEntity>) collectionsQueue.Dequeue();
			this._category2Post = (EntityCollection<Category2PostEntity>) collectionsQueue.Dequeue();
			this._postAttachment = (EntityCollection<PostAttachmentEntity>) collectionsQueue.Dequeue();
			this._postTag = (EntityCollection<PostTagEntity>) collectionsQueue.Dequeue();
			this._teamPost = (EntityCollection<TeamPostEntity>) collectionsQueue.Dequeue();
			this._category1CollectionViaCategory1Post = (EntityCollection<Category1Entity>) collectionsQueue.Dequeue();
			this._category2CollectionViaCategory2Post = (EntityCollection<Category2Entity>) collectionsQueue.Dequeue();
			this._tagCollectionViaPostTag = (EntityCollection<TagEntity>) collectionsQueue.Dequeue();
			this._teamCollectionViaTeamPost = (EntityCollection<TeamEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._category1Post != null)
			{
				return true;
			}
			if (this._category2Post != null)
			{
				return true;
			}
			if (this._postAttachment != null)
			{
				return true;
			}
			if (this._postTag != null)
			{
				return true;
			}
			if (this._teamPost != null)
			{
				return true;
			}
			if (this._category1CollectionViaCategory1Post != null)
			{
				return true;
			}
			if (this._category2CollectionViaCategory2Post != null)
			{
				return true;
			}
			if (this._tagCollectionViaPostTag != null)
			{
				return true;
			}
			if (this._teamCollectionViaTeamPost != null)
			{
				return true;
			}
			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<Category1PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(Category1PostEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<Category2PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2PostEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PostAttachmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostAttachmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PostTagEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostTagEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TeamPostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TeamPostEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<Category1Entity>(EntityFactoryCache2.GetEntityFactory(typeof(Category1EntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<Category2Entity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2EntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TagEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TagEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TeamEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TeamEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("SysUser", _sysUser);
			toReturn.Add("Category1Post", _category1Post);
			toReturn.Add("Category2Post", _category2Post);
			toReturn.Add("PostAttachment", _postAttachment);
			toReturn.Add("PostTag", _postTag);
			toReturn.Add("TeamPost", _teamPost);
			toReturn.Add("Category1CollectionViaCategory1Post", _category1CollectionViaCategory1Post);
			toReturn.Add("Category2CollectionViaCategory2Post", _category2CollectionViaCategory2Post);
			toReturn.Add("TagCollectionViaPostTag", _tagCollectionViaPostTag);
			toReturn.Add("TeamCollectionViaTeamPost", _teamCollectionViaTeamPost);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_category1Post!=null)
			{
				_category1Post.ActiveContext = base.ActiveContext;
			}
			if(_category2Post!=null)
			{
				_category2Post.ActiveContext = base.ActiveContext;
			}
			if(_postAttachment!=null)
			{
				_postAttachment.ActiveContext = base.ActiveContext;
			}
			if(_postTag!=null)
			{
				_postTag.ActiveContext = base.ActiveContext;
			}
			if(_teamPost!=null)
			{
				_teamPost.ActiveContext = base.ActiveContext;
			}
			if(_category1CollectionViaCategory1Post!=null)
			{
				_category1CollectionViaCategory1Post.ActiveContext = base.ActiveContext;
			}
			if(_category2CollectionViaCategory2Post!=null)
			{
				_category2CollectionViaCategory2Post.ActiveContext = base.ActiveContext;
			}
			if(_tagCollectionViaPostTag!=null)
			{
				_tagCollectionViaPostTag.ActiveContext = base.ActiveContext;
			}
			if(_teamCollectionViaTeamPost!=null)
			{
				_teamCollectionViaTeamPost.ActiveContext = base.ActiveContext;
			}
			if(_sysUser!=null)
			{
				_sysUser.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_category1Post = null;
			_category2Post = null;
			_postAttachment = null;
			_postTag = null;
			_teamPost = null;
			_category1CollectionViaCategory1Post = null;
			_category2CollectionViaCategory2Post = null;
			_tagCollectionViaPostTag = null;
			_teamCollectionViaTeamPost = null;
			_sysUser = null;

			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("PostId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ImageFile", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Slug", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FkAuthorId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CommentStatus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ReadCount", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OrderNo", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _sysUser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSysUser(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _sysUser, new PropertyChangedEventHandler( OnSysUserPropertyChanged ), "SysUser", PostEntity.Relations.SysUserEntityUsingFkAuthorId, true, signalRelatedEntity, "Post", resetFKFields, new int[] { (int)PostFieldIndex.FkAuthorId } );		
			_sysUser = null;
		}

		/// <summary> setups the sync logic for member _sysUser</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSysUser(IEntity2 relatedEntity)
		{
			if(_sysUser!=relatedEntity)
			{
				DesetupSyncSysUser(true, true);
				_sysUser = (SysUserEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _sysUser, new PropertyChangedEventHandler( OnSysUserPropertyChanged ), "SysUser", PostEntity.Relations.SysUserEntityUsingFkAuthorId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSysUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PostEntity</param>
		/// <param name="fields">Fields of this entity</param>
		protected virtual void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			base.Fields = fields;
			base.IsNew=true;
			base.Validator = validator;
			InitClassMembers();

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static PostRelations Relations
		{
			get	{ return new PostRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category1Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory1Post
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<Category1PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(Category1PostEntityFactory))),
					(IEntityRelation)GetRelationsForField("Category1Post")[0], (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.Category1PostEntity, 0, null, null, null, null, "Category1Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category2Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory2Post
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<Category2PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2PostEntityFactory))),
					(IEntityRelation)GetRelationsForField("Category2Post")[0], (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.Category2PostEntity, 0, null, null, null, null, "Category2Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PostAttachment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPostAttachment
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<PostAttachmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostAttachmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("PostAttachment")[0], (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.PostAttachmentEntity, 0, null, null, null, null, "PostAttachment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PostTag' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPostTag
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<PostTagEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostTagEntityFactory))),
					(IEntityRelation)GetRelationsForField("PostTag")[0], (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.PostTagEntity, 0, null, null, null, null, "PostTag", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TeamPost' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTeamPost
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<TeamPostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TeamPostEntityFactory))),
					(IEntityRelation)GetRelationsForField("TeamPost")[0], (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.TeamPostEntity, 0, null, null, null, null, "TeamPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category1' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory1CollectionViaCategory1Post
		{
			get
			{
				IEntityRelation intermediateRelation = PostEntity.Relations.Category1PostEntityUsingFkPostId;
				intermediateRelation.SetAliases(string.Empty, "Category1Post_");
				return new PrefetchPathElement2(new EntityCollection<Category1Entity>(EntityFactoryCache2.GetEntityFactory(typeof(Category1EntityFactory))), intermediateRelation,
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.Category1Entity, 0, null, null, GetRelationsForField("Category1CollectionViaCategory1Post"), null, "Category1CollectionViaCategory1Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category2' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory2CollectionViaCategory2Post
		{
			get
			{
				IEntityRelation intermediateRelation = PostEntity.Relations.Category2PostEntityUsingFkPostId;
				intermediateRelation.SetAliases(string.Empty, "Category2Post_");
				return new PrefetchPathElement2(new EntityCollection<Category2Entity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2EntityFactory))), intermediateRelation,
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.Category2Entity, 0, null, null, GetRelationsForField("Category2CollectionViaCategory2Post"), null, "Category2CollectionViaCategory2Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Tag' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTagCollectionViaPostTag
		{
			get
			{
				IEntityRelation intermediateRelation = PostEntity.Relations.PostTagEntityUsingFkPostId;
				intermediateRelation.SetAliases(string.Empty, "PostTag_");
				return new PrefetchPathElement2(new EntityCollection<TagEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TagEntityFactory))), intermediateRelation,
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.TagEntity, 0, null, null, GetRelationsForField("TagCollectionViaPostTag"), null, "TagCollectionViaPostTag", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTeamCollectionViaTeamPost
		{
			get
			{
				IEntityRelation intermediateRelation = PostEntity.Relations.TeamPostEntityUsingFkPostId;
				intermediateRelation.SetAliases(string.Empty, "TeamPost_");
				return new PrefetchPathElement2(new EntityCollection<TeamEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TeamEntityFactory))), intermediateRelation,
					(int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, 0, null, null, GetRelationsForField("TeamCollectionViaTeamPost"), null, "TeamCollectionViaTeamPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SysUser' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSysUser
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SysUserEntityFactory))),
					(IEntityRelation)GetRelationsForField("SysUser")[0], (int)LLBLGenTest.LLBL.EntityType.PostEntity, (int)LLBLGenTest.LLBL.EntityType.SysUserEntity, 0, null, null, null, null, "SysUser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return PostEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return PostEntity.FieldsCustomProperties;}
		}

		/// <summary> The PostId property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."PostId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 PostId
		{
			get { return (System.Int32)GetValue((int)PostFieldIndex.PostId, true); }
			set	{ SetValue((int)PostFieldIndex.PostId, value); }
		}

		/// <summary> The Title property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)PostFieldIndex.Title, true); }
			set	{ SetValue((int)PostFieldIndex.Title, value); }
		}

		/// <summary> The Description property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)PostFieldIndex.Description, true); }
			set	{ SetValue((int)PostFieldIndex.Description, value); }
		}

		/// <summary> The ImageFile property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."ImageFile"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ImageFile
		{
			get { return (System.String)GetValue((int)PostFieldIndex.ImageFile, true); }
			set	{ SetValue((int)PostFieldIndex.ImageFile, value); }
		}

		/// <summary> The Slug property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."Slug"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Slug
		{
			get { return (System.String)GetValue((int)PostFieldIndex.Slug, true); }
			set	{ SetValue((int)PostFieldIndex.Slug, value); }
		}

		/// <summary> The FkAuthorId property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."FK_AuthorID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 FkAuthorId
		{
			get { return (System.Int32)GetValue((int)PostFieldIndex.FkAuthorId, true); }
			set	{ SetValue((int)PostFieldIndex.FkAuthorId, value); }
		}

		/// <summary> The DateCreated property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateCreated
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PostFieldIndex.DateCreated, false); }
			set	{ SetValue((int)PostFieldIndex.DateCreated, value); }
		}

		/// <summary> The CommentStatus property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."CommentStatus"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> CommentStatus
		{
			get { return (Nullable<System.Boolean>)GetValue((int)PostFieldIndex.CommentStatus, false); }
			set	{ SetValue((int)PostFieldIndex.CommentStatus, value); }
		}

		/// <summary> The ReadCount property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."ReadCount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ReadCount
		{
			get { return (System.Int32)GetValue((int)PostFieldIndex.ReadCount, true); }
			set	{ SetValue((int)PostFieldIndex.ReadCount, value); }
		}

		/// <summary> The IsActive property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)PostFieldIndex.IsActive, true); }
			set	{ SetValue((int)PostFieldIndex.IsActive, value); }
		}

		/// <summary> The OrderNo property of the Entity Post<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Post"."OrderNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> OrderNo
		{
			get { return (Nullable<System.Int32>)GetValue((int)PostFieldIndex.OrderNo, false); }
			set	{ SetValue((int)PostFieldIndex.OrderNo, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'Category1PostEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(Category1PostEntity))]
		public virtual EntityCollection<Category1PostEntity> Category1Post
		{
			get
			{
				if(_category1Post==null)
				{
					_category1Post = new EntityCollection<Category1PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(Category1PostEntityFactory)));
					_category1Post.SetContainingEntityInfo(this, "Post");
				}
				return _category1Post;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'Category2PostEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(Category2PostEntity))]
		public virtual EntityCollection<Category2PostEntity> Category2Post
		{
			get
			{
				if(_category2Post==null)
				{
					_category2Post = new EntityCollection<Category2PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2PostEntityFactory)));
					_category2Post.SetContainingEntityInfo(this, "Post");
				}
				return _category2Post;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PostAttachmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(PostAttachmentEntity))]
		public virtual EntityCollection<PostAttachmentEntity> PostAttachment
		{
			get
			{
				if(_postAttachment==null)
				{
					_postAttachment = new EntityCollection<PostAttachmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostAttachmentEntityFactory)));
					_postAttachment.SetContainingEntityInfo(this, "Post");
				}
				return _postAttachment;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PostTagEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(PostTagEntity))]
		public virtual EntityCollection<PostTagEntity> PostTag
		{
			get
			{
				if(_postTag==null)
				{
					_postTag = new EntityCollection<PostTagEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostTagEntityFactory)));
					_postTag.SetContainingEntityInfo(this, "Post");
				}
				return _postTag;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'TeamPostEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(TeamPostEntity))]
		public virtual EntityCollection<TeamPostEntity> TeamPost
		{
			get
			{
				if(_teamPost==null)
				{
					_teamPost = new EntityCollection<TeamPostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TeamPostEntityFactory)));
					_teamPost.SetContainingEntityInfo(this, "Post");
				}
				return _teamPost;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'Category1Entity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(Category1Entity))]
		public virtual EntityCollection<Category1Entity> Category1CollectionViaCategory1Post
		{
			get
			{
				if(_category1CollectionViaCategory1Post==null)
				{
					_category1CollectionViaCategory1Post = new EntityCollection<Category1Entity>(EntityFactoryCache2.GetEntityFactory(typeof(Category1EntityFactory)));
					_category1CollectionViaCategory1Post.IsReadOnly=true;
				}
				return _category1CollectionViaCategory1Post;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'Category2Entity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(Category2Entity))]
		public virtual EntityCollection<Category2Entity> Category2CollectionViaCategory2Post
		{
			get
			{
				if(_category2CollectionViaCategory2Post==null)
				{
					_category2CollectionViaCategory2Post = new EntityCollection<Category2Entity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2EntityFactory)));
					_category2CollectionViaCategory2Post.IsReadOnly=true;
				}
				return _category2CollectionViaCategory2Post;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'TagEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(TagEntity))]
		public virtual EntityCollection<TagEntity> TagCollectionViaPostTag
		{
			get
			{
				if(_tagCollectionViaPostTag==null)
				{
					_tagCollectionViaPostTag = new EntityCollection<TagEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TagEntityFactory)));
					_tagCollectionViaPostTag.IsReadOnly=true;
				}
				return _tagCollectionViaPostTag;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'TeamEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(TeamEntity))]
		public virtual EntityCollection<TeamEntity> TeamCollectionViaTeamPost
		{
			get
			{
				if(_teamCollectionViaTeamPost==null)
				{
					_teamCollectionViaTeamPost = new EntityCollection<TeamEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TeamEntityFactory)));
					_teamCollectionViaTeamPost.IsReadOnly=true;
				}
				return _teamCollectionViaTeamPost;
			}
		}

		/// <summary> Gets / sets related entity of type 'SysUserEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual SysUserEntity SysUser
		{
			get
			{
				return _sysUser;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSysUser(value);
				}
				else
				{
					if(value==null)
					{
						if(_sysUser != null)
						{
							_sysUser.UnsetRelatedEntity(this, "Post");
						}
					}
					else
					{
						if(_sysUser!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "Post");
						}
					}
				}
			}
		}

	
		
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the LLBLGenTest.LLBL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)LLBLGenTest.LLBL.EntityType.PostEntity; }
		}
		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
