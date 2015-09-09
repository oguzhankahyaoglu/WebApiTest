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
	/// Entity class which represents the entity 'Category2'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class Category2Entity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<Category2PostEntity> _category2Post;
		private EntityCollection<PostEntity> _postCollectionViaCategory2Post;
		private Category1Entity _category1;

		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Category1</summary>
			public static readonly string Category1 = "Category1";
			/// <summary>Member name Category2Post</summary>
			public static readonly string Category2Post = "Category2Post";
			/// <summary>Member name PostCollectionViaCategory2Post</summary>
			public static readonly string PostCollectionViaCategory2Post = "PostCollectionViaCategory2Post";

		}
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static Category2Entity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public Category2Entity():base("Category2Entity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public Category2Entity(IEntityFields2 fields):base("Category2Entity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this Category2Entity</param>
		public Category2Entity(IValidator validator):base("Category2Entity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="category2Id">PK value for Category2 which data should be fetched into this Category2 object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public Category2Entity(System.Int32 category2Id):base("Category2Entity")
		{
			InitClassEmpty(null, CreateFields());
			this.Category2Id = category2Id;
		}

		/// <summary> CTor</summary>
		/// <param name="category2Id">PK value for Category2 which data should be fetched into this Category2 object</param>
		/// <param name="validator">The custom validator object for this Category2Entity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public Category2Entity(System.Int32 category2Id, IValidator validator):base("Category2Entity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Category2Id = category2Id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected Category2Entity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_category2Post = (EntityCollection<Category2PostEntity>)info.GetValue("_category2Post", typeof(EntityCollection<Category2PostEntity>));
				_postCollectionViaCategory2Post = (EntityCollection<PostEntity>)info.GetValue("_postCollectionViaCategory2Post", typeof(EntityCollection<PostEntity>));
				_category1 = (Category1Entity)info.GetValue("_category1", typeof(Category1Entity));
				if(_category1!=null)
				{
					_category1.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((Category2FieldIndex)fieldIndex)
			{
				case Category2FieldIndex.FkCategory1Id:
					DesetupSyncCategory1(true, false);
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
				case "Category1":
					this.Category1 = (Category1Entity)entity;
					break;
				case "Category2Post":
					this.Category2Post.Add((Category2PostEntity)entity);
					break;
				case "PostCollectionViaCategory2Post":
					this.PostCollectionViaCategory2Post.IsReadOnly = false;
					this.PostCollectionViaCategory2Post.Add((PostEntity)entity);
					this.PostCollectionViaCategory2Post.IsReadOnly = true;
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
			return Category2Entity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Category1":
					toReturn.Add(Category2Entity.Relations.Category1EntityUsingFkCategory1Id);
					break;
				case "Category2Post":
					toReturn.Add(Category2Entity.Relations.Category2PostEntityUsingFkCategory2Id);
					break;
				case "PostCollectionViaCategory2Post":
					toReturn.Add(Category2Entity.Relations.Category2PostEntityUsingFkCategory2Id, "Category2Entity__", "Category2Post_", JoinHint.None);
					toReturn.Add(Category2PostEntity.Relations.PostEntityUsingFkPostId, "Category2Post_", string.Empty, JoinHint.None);
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
				case "Category1":
					SetupSyncCategory1(relatedEntity);
					break;
				case "Category2Post":
					this.Category2Post.Add((Category2PostEntity)relatedEntity);
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
				case "Category1":
					DesetupSyncCategory1(false, true);
					break;
				case "Category2Post":
					base.PerformRelatedEntityRemoval(this.Category2Post, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_category1!=null)
			{
				toReturn.Add(_category1);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Category2Post);

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
				info.AddValue("_category2Post", ((_category2Post!=null) && (_category2Post.Count>0) && !this.MarkedForDeletion)?_category2Post:null);
				info.AddValue("_postCollectionViaCategory2Post", ((_postCollectionViaCategory2Post!=null) && (_postCollectionViaCategory2Post.Count>0) && !this.MarkedForDeletion)?_postCollectionViaCategory2Post:null);
				info.AddValue("_category1", (!this.MarkedForDeletion?_category1:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(Category2FieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(Category2FieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new Category2Relations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Category2Post' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory2Post()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(Category2PostFields.FkCategory2Id, null, ComparisonOperator.Equal, this.Category2Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Post' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPostCollectionViaCategory2Post()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("PostCollectionViaCategory2Post"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(Category2Fields.Category2Id, null, ComparisonOperator.Equal, this.Category2Id, "Category2Entity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Category1' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(Category1Fields.Category1Id, null, ComparisonOperator.Equal, this.FkCategory1Id));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(LLBLGenTest.LLBL.EntityType.Category2Entity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(Category2EntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._category2Post);
			collectionsQueue.Enqueue(this._postCollectionViaCategory2Post);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._category2Post = (EntityCollection<Category2PostEntity>) collectionsQueue.Dequeue();
			this._postCollectionViaCategory2Post = (EntityCollection<PostEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._category2Post != null)
			{
				return true;
			}
			if (this._postCollectionViaCategory2Post != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<Category2PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2PostEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Category1", _category1);
			toReturn.Add("Category2Post", _category2Post);
			toReturn.Add("PostCollectionViaCategory2Post", _postCollectionViaCategory2Post);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_category2Post!=null)
			{
				_category2Post.ActiveContext = base.ActiveContext;
			}
			if(_postCollectionViaCategory2Post!=null)
			{
				_postCollectionViaCategory2Post.ActiveContext = base.ActiveContext;
			}
			if(_category1!=null)
			{
				_category1.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_category2Post = null;
			_postCollectionViaCategory2Post = null;
			_category1 = null;

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

			_fieldsCustomProperties.Add("Category2Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FkCategory1Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Slug", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OrderNo", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _category1</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCategory1(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _category1, new PropertyChangedEventHandler( OnCategory1PropertyChanged ), "Category1", Category2Entity.Relations.Category1EntityUsingFkCategory1Id, true, signalRelatedEntity, "Category2", resetFKFields, new int[] { (int)Category2FieldIndex.FkCategory1Id } );		
			_category1 = null;
		}

		/// <summary> setups the sync logic for member _category1</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCategory1(IEntity2 relatedEntity)
		{
			if(_category1!=relatedEntity)
			{
				DesetupSyncCategory1(true, true);
				_category1 = (Category1Entity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _category1, new PropertyChangedEventHandler( OnCategory1PropertyChanged ), "Category1", Category2Entity.Relations.Category1EntityUsingFkCategory1Id, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCategory1PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this Category2Entity</param>
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
		public  static Category2Relations Relations
		{
			get	{ return new Category2Relations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category2Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory2Post
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<Category2PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2PostEntityFactory))),
					(IEntityRelation)GetRelationsForField("Category2Post")[0], (int)LLBLGenTest.LLBL.EntityType.Category2Entity, (int)LLBLGenTest.LLBL.EntityType.Category2PostEntity, 0, null, null, null, null, "Category2Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPostCollectionViaCategory2Post
		{
			get
			{
				IEntityRelation intermediateRelation = Category2Entity.Relations.Category2PostEntityUsingFkCategory2Id;
				intermediateRelation.SetAliases(string.Empty, "Category2Post_");
				return new PrefetchPathElement2(new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory))), intermediateRelation,
					(int)LLBLGenTest.LLBL.EntityType.Category2Entity, (int)LLBLGenTest.LLBL.EntityType.PostEntity, 0, null, null, GetRelationsForField("PostCollectionViaCategory2Post"), null, "PostCollectionViaCategory2Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category1' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory1
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(Category1EntityFactory))),
					(IEntityRelation)GetRelationsForField("Category1")[0], (int)LLBLGenTest.LLBL.EntityType.Category2Entity, (int)LLBLGenTest.LLBL.EntityType.Category1Entity, 0, null, null, null, null, "Category1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return Category2Entity.CustomProperties;}
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
			get { return Category2Entity.FieldsCustomProperties;}
		}

		/// <summary> The Category2Id property of the Entity Category2<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category2"."Category2Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Category2Id
		{
			get { return (System.Int32)GetValue((int)Category2FieldIndex.Category2Id, true); }
			set	{ SetValue((int)Category2FieldIndex.Category2Id, value); }
		}

		/// <summary> The Title property of the Entity Category2<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category2"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)Category2FieldIndex.Title, true); }
			set	{ SetValue((int)Category2FieldIndex.Title, value); }
		}

		/// <summary> The Description property of the Entity Category2<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category2"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)Category2FieldIndex.Description, true); }
			set	{ SetValue((int)Category2FieldIndex.Description, value); }
		}

		/// <summary> The FkCategory1Id property of the Entity Category2<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category2"."FK_Category1ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> FkCategory1Id
		{
			get { return (Nullable<System.Int32>)GetValue((int)Category2FieldIndex.FkCategory1Id, false); }
			set	{ SetValue((int)Category2FieldIndex.FkCategory1Id, value); }
		}

		/// <summary> The Slug property of the Entity Category2<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category2"."Slug"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Slug
		{
			get { return (System.String)GetValue((int)Category2FieldIndex.Slug, true); }
			set	{ SetValue((int)Category2FieldIndex.Slug, value); }
		}

		/// <summary> The IsActive property of the Entity Category2<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category2"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsActive
		{
			get { return (Nullable<System.Boolean>)GetValue((int)Category2FieldIndex.IsActive, false); }
			set	{ SetValue((int)Category2FieldIndex.IsActive, value); }
		}

		/// <summary> The OrderNo property of the Entity Category2<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category2"."OrderNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> OrderNo
		{
			get { return (Nullable<System.Int32>)GetValue((int)Category2FieldIndex.OrderNo, false); }
			set	{ SetValue((int)Category2FieldIndex.OrderNo, value); }
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
					_category2Post.SetContainingEntityInfo(this, "Category2");
				}
				return _category2Post;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PostEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(PostEntity))]
		public virtual EntityCollection<PostEntity> PostCollectionViaCategory2Post
		{
			get
			{
				if(_postCollectionViaCategory2Post==null)
				{
					_postCollectionViaCategory2Post = new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory)));
					_postCollectionViaCategory2Post.IsReadOnly=true;
				}
				return _postCollectionViaCategory2Post;
			}
		}

		/// <summary> Gets / sets related entity of type 'Category1Entity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual Category1Entity Category1
		{
			get
			{
				return _category1;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCategory1(value);
				}
				else
				{
					if(value==null)
					{
						if(_category1 != null)
						{
							_category1.UnsetRelatedEntity(this, "Category2");
						}
					}
					else
					{
						if(_category1!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "Category2");
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
			get { return (int)LLBLGenTest.LLBL.EntityType.Category2Entity; }
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
