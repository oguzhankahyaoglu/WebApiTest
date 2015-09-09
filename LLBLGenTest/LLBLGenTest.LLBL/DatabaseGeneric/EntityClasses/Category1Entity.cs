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
	/// Entity class which represents the entity 'Category1'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class Category1Entity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<Category1PostEntity> _category1Post;
		private EntityCollection<Category2Entity> _category2;
		private EntityCollection<MainPageBannerEntity> _mainPageBanner;
		private EntityCollection<PostEntity> _postCollectionViaCategory1Post;


		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name Category1Post</summary>
			public static readonly string Category1Post = "Category1Post";
			/// <summary>Member name Category2</summary>
			public static readonly string Category2 = "Category2";
			/// <summary>Member name MainPageBanner</summary>
			public static readonly string MainPageBanner = "MainPageBanner";
			/// <summary>Member name PostCollectionViaCategory1Post</summary>
			public static readonly string PostCollectionViaCategory1Post = "PostCollectionViaCategory1Post";

		}
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static Category1Entity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public Category1Entity():base("Category1Entity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public Category1Entity(IEntityFields2 fields):base("Category1Entity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this Category1Entity</param>
		public Category1Entity(IValidator validator):base("Category1Entity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="category1Id">PK value for Category1 which data should be fetched into this Category1 object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public Category1Entity(System.Int32 category1Id):base("Category1Entity")
		{
			InitClassEmpty(null, CreateFields());
			this.Category1Id = category1Id;
		}

		/// <summary> CTor</summary>
		/// <param name="category1Id">PK value for Category1 which data should be fetched into this Category1 object</param>
		/// <param name="validator">The custom validator object for this Category1Entity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public Category1Entity(System.Int32 category1Id, IValidator validator):base("Category1Entity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Category1Id = category1Id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected Category1Entity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_category1Post = (EntityCollection<Category1PostEntity>)info.GetValue("_category1Post", typeof(EntityCollection<Category1PostEntity>));
				_category2 = (EntityCollection<Category2Entity>)info.GetValue("_category2", typeof(EntityCollection<Category2Entity>));
				_mainPageBanner = (EntityCollection<MainPageBannerEntity>)info.GetValue("_mainPageBanner", typeof(EntityCollection<MainPageBannerEntity>));
				_postCollectionViaCategory1Post = (EntityCollection<PostEntity>)info.GetValue("_postCollectionViaCategory1Post", typeof(EntityCollection<PostEntity>));


				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((Category1FieldIndex)fieldIndex)
			{
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

				case "Category1Post":
					this.Category1Post.Add((Category1PostEntity)entity);
					break;
				case "Category2":
					this.Category2.Add((Category2Entity)entity);
					break;
				case "MainPageBanner":
					this.MainPageBanner.Add((MainPageBannerEntity)entity);
					break;
				case "PostCollectionViaCategory1Post":
					this.PostCollectionViaCategory1Post.IsReadOnly = false;
					this.PostCollectionViaCategory1Post.Add((PostEntity)entity);
					this.PostCollectionViaCategory1Post.IsReadOnly = true;
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
			return Category1Entity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "Category1Post":
					toReturn.Add(Category1Entity.Relations.Category1PostEntityUsingFkCategory1Id);
					break;
				case "Category2":
					toReturn.Add(Category1Entity.Relations.Category2EntityUsingFkCategory1Id);
					break;
				case "MainPageBanner":
					toReturn.Add(Category1Entity.Relations.MainPageBannerEntityUsingFkCategory1Id);
					break;
				case "PostCollectionViaCategory1Post":
					toReturn.Add(Category1Entity.Relations.Category1PostEntityUsingFkCategory1Id, "Category1Entity__", "Category1Post_", JoinHint.None);
					toReturn.Add(Category1PostEntity.Relations.PostEntityUsingFkPostId, "Category1Post_", string.Empty, JoinHint.None);
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

				case "Category1Post":
					this.Category1Post.Add((Category1PostEntity)relatedEntity);
					break;
				case "Category2":
					this.Category2.Add((Category2Entity)relatedEntity);
					break;
				case "MainPageBanner":
					this.MainPageBanner.Add((MainPageBannerEntity)relatedEntity);
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

				case "Category1Post":
					base.PerformRelatedEntityRemoval(this.Category1Post, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Category2":
					base.PerformRelatedEntityRemoval(this.Category2, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "MainPageBanner":
					base.PerformRelatedEntityRemoval(this.MainPageBanner, relatedEntity, signalRelatedEntityManyToOne);
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


			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Category1Post);
			toReturn.Add(this.Category2);
			toReturn.Add(this.MainPageBanner);

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
				info.AddValue("_category2", ((_category2!=null) && (_category2.Count>0) && !this.MarkedForDeletion)?_category2:null);
				info.AddValue("_mainPageBanner", ((_mainPageBanner!=null) && (_mainPageBanner.Count>0) && !this.MarkedForDeletion)?_mainPageBanner:null);
				info.AddValue("_postCollectionViaCategory1Post", ((_postCollectionViaCategory1Post!=null) && (_postCollectionViaCategory1Post.Count>0) && !this.MarkedForDeletion)?_postCollectionViaCategory1Post:null);


			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(Category1FieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(Category1FieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new Category1Relations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Category1Post' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory1Post()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(Category1PostFields.FkCategory1Id, null, ComparisonOperator.Equal, this.Category1Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Category2' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory2()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(Category2Fields.FkCategory1Id, null, ComparisonOperator.Equal, this.Category1Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'MainPageBanner' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoMainPageBanner()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(MainPageBannerFields.FkCategory1Id, null, ComparisonOperator.Equal, this.Category1Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Post' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPostCollectionViaCategory1Post()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("PostCollectionViaCategory1Post"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(Category1Fields.Category1Id, null, ComparisonOperator.Equal, this.Category1Id, "Category1Entity__"));
			return bucket;
		}


	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(LLBLGenTest.LLBL.EntityType.Category1Entity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(Category1EntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._category1Post);
			collectionsQueue.Enqueue(this._category2);
			collectionsQueue.Enqueue(this._mainPageBanner);
			collectionsQueue.Enqueue(this._postCollectionViaCategory1Post);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._category1Post = (EntityCollection<Category1PostEntity>) collectionsQueue.Dequeue();
			this._category2 = (EntityCollection<Category2Entity>) collectionsQueue.Dequeue();
			this._mainPageBanner = (EntityCollection<MainPageBannerEntity>) collectionsQueue.Dequeue();
			this._postCollectionViaCategory1Post = (EntityCollection<PostEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._category1Post != null)
			{
				return true;
			}
			if (this._category2 != null)
			{
				return true;
			}
			if (this._mainPageBanner != null)
			{
				return true;
			}
			if (this._postCollectionViaCategory1Post != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<Category2Entity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2EntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<MainPageBannerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(MainPageBannerEntityFactory))) : null);
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

			toReturn.Add("Category1Post", _category1Post);
			toReturn.Add("Category2", _category2);
			toReturn.Add("MainPageBanner", _mainPageBanner);
			toReturn.Add("PostCollectionViaCategory1Post", _postCollectionViaCategory1Post);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_category1Post!=null)
			{
				_category1Post.ActiveContext = base.ActiveContext;
			}
			if(_category2!=null)
			{
				_category2.ActiveContext = base.ActiveContext;
			}
			if(_mainPageBanner!=null)
			{
				_mainPageBanner.ActiveContext = base.ActiveContext;
			}
			if(_postCollectionViaCategory1Post!=null)
			{
				_postCollectionViaCategory1Post.ActiveContext = base.ActiveContext;
			}


		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_category1Post = null;
			_category2 = null;
			_mainPageBanner = null;
			_postCollectionViaCategory1Post = null;


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

			_fieldsCustomProperties.Add("Category1Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MenuTitle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Slug", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsShownInMainMenu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OrderNo", fieldHashtable);
		}
		#endregion



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this Category1Entity</param>
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
		public  static Category1Relations Relations
		{
			get	{ return new Category1Relations(); }
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
					(IEntityRelation)GetRelationsForField("Category1Post")[0], (int)LLBLGenTest.LLBL.EntityType.Category1Entity, (int)LLBLGenTest.LLBL.EntityType.Category1PostEntity, 0, null, null, null, null, "Category1Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category2' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory2
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<Category2Entity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2EntityFactory))),
					(IEntityRelation)GetRelationsForField("Category2")[0], (int)LLBLGenTest.LLBL.EntityType.Category1Entity, (int)LLBLGenTest.LLBL.EntityType.Category2Entity, 0, null, null, null, null, "Category2", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'MainPageBanner' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathMainPageBanner
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<MainPageBannerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(MainPageBannerEntityFactory))),
					(IEntityRelation)GetRelationsForField("MainPageBanner")[0], (int)LLBLGenTest.LLBL.EntityType.Category1Entity, (int)LLBLGenTest.LLBL.EntityType.MainPageBannerEntity, 0, null, null, null, null, "MainPageBanner", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPostCollectionViaCategory1Post
		{
			get
			{
				IEntityRelation intermediateRelation = Category1Entity.Relations.Category1PostEntityUsingFkCategory1Id;
				intermediateRelation.SetAliases(string.Empty, "Category1Post_");
				return new PrefetchPathElement2(new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory))), intermediateRelation,
					(int)LLBLGenTest.LLBL.EntityType.Category1Entity, (int)LLBLGenTest.LLBL.EntityType.PostEntity, 0, null, null, GetRelationsForField("PostCollectionViaCategory1Post"), null, "PostCollectionViaCategory1Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return Category1Entity.CustomProperties;}
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
			get { return Category1Entity.FieldsCustomProperties;}
		}

		/// <summary> The Category1Id property of the Entity Category1<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category1"."Category1Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Category1Id
		{
			get { return (System.Int32)GetValue((int)Category1FieldIndex.Category1Id, true); }
			set	{ SetValue((int)Category1FieldIndex.Category1Id, value); }
		}

		/// <summary> The Title property of the Entity Category1<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category1"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)Category1FieldIndex.Title, true); }
			set	{ SetValue((int)Category1FieldIndex.Title, value); }
		}

		/// <summary> The MenuTitle property of the Entity Category1<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category1"."MenuTitle"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MenuTitle
		{
			get { return (System.String)GetValue((int)Category1FieldIndex.MenuTitle, true); }
			set	{ SetValue((int)Category1FieldIndex.MenuTitle, value); }
		}

		/// <summary> The Description property of the Entity Category1<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category1"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)Category1FieldIndex.Description, true); }
			set	{ SetValue((int)Category1FieldIndex.Description, value); }
		}

		/// <summary> The Slug property of the Entity Category1<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category1"."Slug"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Slug
		{
			get { return (System.String)GetValue((int)Category1FieldIndex.Slug, true); }
			set	{ SetValue((int)Category1FieldIndex.Slug, value); }
		}

		/// <summary> The IsActive property of the Entity Category1<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category1"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsActive
		{
			get { return (Nullable<System.Boolean>)GetValue((int)Category1FieldIndex.IsActive, false); }
			set	{ SetValue((int)Category1FieldIndex.IsActive, value); }
		}

		/// <summary> The IsShownInMainMenu property of the Entity Category1<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category1"."IsShownInMainMenu"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsShownInMainMenu
		{
			get { return (System.Boolean)GetValue((int)Category1FieldIndex.IsShownInMainMenu, true); }
			set	{ SetValue((int)Category1FieldIndex.IsShownInMainMenu, value); }
		}

		/// <summary> The OrderNo property of the Entity Category1<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Category1"."OrderNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> OrderNo
		{
			get { return (Nullable<System.Int32>)GetValue((int)Category1FieldIndex.OrderNo, false); }
			set	{ SetValue((int)Category1FieldIndex.OrderNo, value); }
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
					_category1Post.SetContainingEntityInfo(this, "Category1");
				}
				return _category1Post;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'Category2Entity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(Category2Entity))]
		public virtual EntityCollection<Category2Entity> Category2
		{
			get
			{
				if(_category2==null)
				{
					_category2 = new EntityCollection<Category2Entity>(EntityFactoryCache2.GetEntityFactory(typeof(Category2EntityFactory)));
					_category2.SetContainingEntityInfo(this, "Category1");
				}
				return _category2;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'MainPageBannerEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(MainPageBannerEntity))]
		public virtual EntityCollection<MainPageBannerEntity> MainPageBanner
		{
			get
			{
				if(_mainPageBanner==null)
				{
					_mainPageBanner = new EntityCollection<MainPageBannerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(MainPageBannerEntityFactory)));
					_mainPageBanner.SetContainingEntityInfo(this, "Category1");
				}
				return _mainPageBanner;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PostEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(PostEntity))]
		public virtual EntityCollection<PostEntity> PostCollectionViaCategory1Post
		{
			get
			{
				if(_postCollectionViaCategory1Post==null)
				{
					_postCollectionViaCategory1Post = new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory)));
					_postCollectionViaCategory1Post.IsReadOnly=true;
				}
				return _postCollectionViaCategory1Post;
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
			get { return (int)LLBLGenTest.LLBL.EntityType.Category1Entity; }
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
