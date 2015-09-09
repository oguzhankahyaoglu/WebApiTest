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
	/// Entity class which represents the entity 'Team'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class TeamEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<TeamPostEntity> _teamPost;
		private EntityCollection<WeeklyProgrammeMatchEntity> _weeklyProgrammeMatch_;
		private EntityCollection<WeeklyProgrammeMatchEntity> _weeklyProgrammeMatch;
		private EntityCollection<PostEntity> _postCollectionViaTeamPost;
		private EntityCollection<WeeklyProgrammeDayEntity> _weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_;
		private EntityCollection<WeeklyProgrammeDayEntity> _weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch;


		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name TeamPost</summary>
			public static readonly string TeamPost = "TeamPost";
			/// <summary>Member name WeeklyProgrammeMatch_</summary>
			public static readonly string WeeklyProgrammeMatch_ = "WeeklyProgrammeMatch_";
			/// <summary>Member name WeeklyProgrammeMatch</summary>
			public static readonly string WeeklyProgrammeMatch = "WeeklyProgrammeMatch";
			/// <summary>Member name PostCollectionViaTeamPost</summary>
			public static readonly string PostCollectionViaTeamPost = "PostCollectionViaTeamPost";
			/// <summary>Member name WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_</summary>
			public static readonly string WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_ = "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_";
			/// <summary>Member name WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch</summary>
			public static readonly string WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch = "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch";

		}
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static TeamEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public TeamEntity():base("TeamEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TeamEntity(IEntityFields2 fields):base("TeamEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TeamEntity</param>
		public TeamEntity(IValidator validator):base("TeamEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="teamId">PK value for Team which data should be fetched into this Team object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public TeamEntity(System.Int32 teamId):base("TeamEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.TeamId = teamId;
		}

		/// <summary> CTor</summary>
		/// <param name="teamId">PK value for Team which data should be fetched into this Team object</param>
		/// <param name="validator">The custom validator object for this TeamEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public TeamEntity(System.Int32 teamId, IValidator validator):base("TeamEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.TeamId = teamId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TeamEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_teamPost = (EntityCollection<TeamPostEntity>)info.GetValue("_teamPost", typeof(EntityCollection<TeamPostEntity>));
				_weeklyProgrammeMatch_ = (EntityCollection<WeeklyProgrammeMatchEntity>)info.GetValue("_weeklyProgrammeMatch_", typeof(EntityCollection<WeeklyProgrammeMatchEntity>));
				_weeklyProgrammeMatch = (EntityCollection<WeeklyProgrammeMatchEntity>)info.GetValue("_weeklyProgrammeMatch", typeof(EntityCollection<WeeklyProgrammeMatchEntity>));
				_postCollectionViaTeamPost = (EntityCollection<PostEntity>)info.GetValue("_postCollectionViaTeamPost", typeof(EntityCollection<PostEntity>));
				_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_ = (EntityCollection<WeeklyProgrammeDayEntity>)info.GetValue("_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_", typeof(EntityCollection<WeeklyProgrammeDayEntity>));
				_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch = (EntityCollection<WeeklyProgrammeDayEntity>)info.GetValue("_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch", typeof(EntityCollection<WeeklyProgrammeDayEntity>));


				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((TeamFieldIndex)fieldIndex)
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

				case "TeamPost":
					this.TeamPost.Add((TeamPostEntity)entity);
					break;
				case "WeeklyProgrammeMatch_":
					this.WeeklyProgrammeMatch_.Add((WeeklyProgrammeMatchEntity)entity);
					break;
				case "WeeklyProgrammeMatch":
					this.WeeklyProgrammeMatch.Add((WeeklyProgrammeMatchEntity)entity);
					break;
				case "PostCollectionViaTeamPost":
					this.PostCollectionViaTeamPost.IsReadOnly = false;
					this.PostCollectionViaTeamPost.Add((PostEntity)entity);
					this.PostCollectionViaTeamPost.IsReadOnly = true;
					break;
				case "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_":
					this.WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_.IsReadOnly = false;
					this.WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_.Add((WeeklyProgrammeDayEntity)entity);
					this.WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_.IsReadOnly = true;
					break;
				case "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch":
					this.WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch.IsReadOnly = false;
					this.WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch.Add((WeeklyProgrammeDayEntity)entity);
					this.WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch.IsReadOnly = true;
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
			return TeamEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "TeamPost":
					toReturn.Add(TeamEntity.Relations.TeamPostEntityUsingFkTeamId);
					break;
				case "WeeklyProgrammeMatch_":
					toReturn.Add(TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam2);
					break;
				case "WeeklyProgrammeMatch":
					toReturn.Add(TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam1);
					break;
				case "PostCollectionViaTeamPost":
					toReturn.Add(TeamEntity.Relations.TeamPostEntityUsingFkTeamId, "TeamEntity__", "TeamPost_", JoinHint.None);
					toReturn.Add(TeamPostEntity.Relations.PostEntityUsingFkPostId, "TeamPost_", string.Empty, JoinHint.None);
					break;
				case "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_":
					toReturn.Add(TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam2, "TeamEntity__", "WeeklyProgrammeMatch_", JoinHint.None);
					toReturn.Add(WeeklyProgrammeMatchEntity.Relations.WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId, "WeeklyProgrammeMatch_", string.Empty, JoinHint.None);
					break;
				case "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch":
					toReturn.Add(TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam1, "TeamEntity__", "WeeklyProgrammeMatch_", JoinHint.None);
					toReturn.Add(WeeklyProgrammeMatchEntity.Relations.WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId, "WeeklyProgrammeMatch_", string.Empty, JoinHint.None);
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

				case "TeamPost":
					this.TeamPost.Add((TeamPostEntity)relatedEntity);
					break;
				case "WeeklyProgrammeMatch_":
					this.WeeklyProgrammeMatch_.Add((WeeklyProgrammeMatchEntity)relatedEntity);
					break;
				case "WeeklyProgrammeMatch":
					this.WeeklyProgrammeMatch.Add((WeeklyProgrammeMatchEntity)relatedEntity);
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

				case "TeamPost":
					base.PerformRelatedEntityRemoval(this.TeamPost, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WeeklyProgrammeMatch_":
					base.PerformRelatedEntityRemoval(this.WeeklyProgrammeMatch_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WeeklyProgrammeMatch":
					base.PerformRelatedEntityRemoval(this.WeeklyProgrammeMatch, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.TeamPost);
			toReturn.Add(this.WeeklyProgrammeMatch_);
			toReturn.Add(this.WeeklyProgrammeMatch);

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
				info.AddValue("_teamPost", ((_teamPost!=null) && (_teamPost.Count>0) && !this.MarkedForDeletion)?_teamPost:null);
				info.AddValue("_weeklyProgrammeMatch_", ((_weeklyProgrammeMatch_!=null) && (_weeklyProgrammeMatch_.Count>0) && !this.MarkedForDeletion)?_weeklyProgrammeMatch_:null);
				info.AddValue("_weeklyProgrammeMatch", ((_weeklyProgrammeMatch!=null) && (_weeklyProgrammeMatch.Count>0) && !this.MarkedForDeletion)?_weeklyProgrammeMatch:null);
				info.AddValue("_postCollectionViaTeamPost", ((_postCollectionViaTeamPost!=null) && (_postCollectionViaTeamPost.Count>0) && !this.MarkedForDeletion)?_postCollectionViaTeamPost:null);
				info.AddValue("_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_", ((_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_!=null) && (_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_.Count>0) && !this.MarkedForDeletion)?_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_:null);
				info.AddValue("_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch", ((_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch!=null) && (_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch.Count>0) && !this.MarkedForDeletion)?_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch:null);


			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(TeamFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(TeamFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new TeamRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'TeamPost' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTeamPost()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TeamPostFields.FkTeamId, null, ComparisonOperator.Equal, this.TeamId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WeeklyProgrammeMatch' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWeeklyProgrammeMatch_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WeeklyProgrammeMatchFields.FkTeam2, null, ComparisonOperator.Equal, this.TeamId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WeeklyProgrammeMatch' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWeeklyProgrammeMatch()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WeeklyProgrammeMatchFields.FkTeam1, null, ComparisonOperator.Equal, this.TeamId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Post' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPostCollectionViaTeamPost()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("PostCollectionViaTeamPost"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TeamFields.TeamId, null, ComparisonOperator.Equal, this.TeamId, "TeamEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WeeklyProgrammeDay' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TeamFields.TeamId, null, ComparisonOperator.Equal, this.TeamId, "TeamEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WeeklyProgrammeDay' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TeamFields.TeamId, null, ComparisonOperator.Equal, this.TeamId, "TeamEntity__"));
			return bucket;
		}


	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(LLBLGenTest.LLBL.EntityType.TeamEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(TeamEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._teamPost);
			collectionsQueue.Enqueue(this._weeklyProgrammeMatch_);
			collectionsQueue.Enqueue(this._weeklyProgrammeMatch);
			collectionsQueue.Enqueue(this._postCollectionViaTeamPost);
			collectionsQueue.Enqueue(this._weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_);
			collectionsQueue.Enqueue(this._weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._teamPost = (EntityCollection<TeamPostEntity>) collectionsQueue.Dequeue();
			this._weeklyProgrammeMatch_ = (EntityCollection<WeeklyProgrammeMatchEntity>) collectionsQueue.Dequeue();
			this._weeklyProgrammeMatch = (EntityCollection<WeeklyProgrammeMatchEntity>) collectionsQueue.Dequeue();
			this._postCollectionViaTeamPost = (EntityCollection<PostEntity>) collectionsQueue.Dequeue();
			this._weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_ = (EntityCollection<WeeklyProgrammeDayEntity>) collectionsQueue.Dequeue();
			this._weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch = (EntityCollection<WeeklyProgrammeDayEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._teamPost != null)
			{
				return true;
			}
			if (this._weeklyProgrammeMatch_ != null)
			{
				return true;
			}
			if (this._weeklyProgrammeMatch != null)
			{
				return true;
			}
			if (this._postCollectionViaTeamPost != null)
			{
				return true;
			}
			if (this._weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_ != null)
			{
				return true;
			}
			if (this._weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TeamPostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TeamPostEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WeeklyProgrammeMatchEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeMatchEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WeeklyProgrammeMatchEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeMatchEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WeeklyProgrammeDayEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeDayEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WeeklyProgrammeDayEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeDayEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();

			toReturn.Add("TeamPost", _teamPost);
			toReturn.Add("WeeklyProgrammeMatch_", _weeklyProgrammeMatch_);
			toReturn.Add("WeeklyProgrammeMatch", _weeklyProgrammeMatch);
			toReturn.Add("PostCollectionViaTeamPost", _postCollectionViaTeamPost);
			toReturn.Add("WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_", _weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_);
			toReturn.Add("WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch", _weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_teamPost!=null)
			{
				_teamPost.ActiveContext = base.ActiveContext;
			}
			if(_weeklyProgrammeMatch_!=null)
			{
				_weeklyProgrammeMatch_.ActiveContext = base.ActiveContext;
			}
			if(_weeklyProgrammeMatch!=null)
			{
				_weeklyProgrammeMatch.ActiveContext = base.ActiveContext;
			}
			if(_postCollectionViaTeamPost!=null)
			{
				_postCollectionViaTeamPost.ActiveContext = base.ActiveContext;
			}
			if(_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_!=null)
			{
				_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_.ActiveContext = base.ActiveContext;
			}
			if(_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch!=null)
			{
				_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch.ActiveContext = base.ActiveContext;
			}


		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_teamPost = null;
			_weeklyProgrammeMatch_ = null;
			_weeklyProgrammeMatch = null;
			_postCollectionViaTeamPost = null;
			_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_ = null;
			_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch = null;


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

			_fieldsCustomProperties.Add("TeamId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Slug", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ImageFile", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Points", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OrderNo", fieldHashtable);
		}
		#endregion



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this TeamEntity</param>
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
		public  static TeamRelations Relations
		{
			get	{ return new TeamRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TeamPost' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTeamPost
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<TeamPostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TeamPostEntityFactory))),
					(IEntityRelation)GetRelationsForField("TeamPost")[0], (int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.TeamPostEntity, 0, null, null, null, null, "TeamPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeMatch' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeMatch_
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<WeeklyProgrammeMatchEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeMatchEntityFactory))),
					(IEntityRelation)GetRelationsForField("WeeklyProgrammeMatch_")[0], (int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, 0, null, null, null, null, "WeeklyProgrammeMatch_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeMatch' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeMatch
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<WeeklyProgrammeMatchEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeMatchEntityFactory))),
					(IEntityRelation)GetRelationsForField("WeeklyProgrammeMatch")[0], (int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, 0, null, null, null, null, "WeeklyProgrammeMatch", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPostCollectionViaTeamPost
		{
			get
			{
				IEntityRelation intermediateRelation = TeamEntity.Relations.TeamPostEntityUsingFkTeamId;
				intermediateRelation.SetAliases(string.Empty, "TeamPost_");
				return new PrefetchPathElement2(new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory))), intermediateRelation,
					(int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.PostEntity, 0, null, null, GetRelationsForField("PostCollectionViaTeamPost"), null, "PostCollectionViaTeamPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeDay' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_
		{
			get
			{
				IEntityRelation intermediateRelation = TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam2;
				intermediateRelation.SetAliases(string.Empty, "WeeklyProgrammeMatch_");
				return new PrefetchPathElement2(new EntityCollection<WeeklyProgrammeDayEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeDayEntityFactory))), intermediateRelation,
					(int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity, 0, null, null, GetRelationsForField("WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_"), null, "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeDay' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch
		{
			get
			{
				IEntityRelation intermediateRelation = TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam1;
				intermediateRelation.SetAliases(string.Empty, "WeeklyProgrammeMatch_");
				return new PrefetchPathElement2(new EntityCollection<WeeklyProgrammeDayEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeDayEntityFactory))), intermediateRelation,
					(int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity, 0, null, null, GetRelationsForField("WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch"), null, "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return TeamEntity.CustomProperties;}
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
			get { return TeamEntity.FieldsCustomProperties;}
		}

		/// <summary> The TeamId property of the Entity Team<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Team"."TeamId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 TeamId
		{
			get { return (System.Int32)GetValue((int)TeamFieldIndex.TeamId, true); }
			set	{ SetValue((int)TeamFieldIndex.TeamId, value); }
		}

		/// <summary> The Title property of the Entity Team<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Team"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)TeamFieldIndex.Title, true); }
			set	{ SetValue((int)TeamFieldIndex.Title, value); }
		}

		/// <summary> The Slug property of the Entity Team<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Team"."Slug"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Slug
		{
			get { return (System.String)GetValue((int)TeamFieldIndex.Slug, true); }
			set	{ SetValue((int)TeamFieldIndex.Slug, value); }
		}

		/// <summary> The ImageFile property of the Entity Team<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Team"."ImageFile"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ImageFile
		{
			get { return (System.String)GetValue((int)TeamFieldIndex.ImageFile, true); }
			set	{ SetValue((int)TeamFieldIndex.ImageFile, value); }
		}

		/// <summary> The Points property of the Entity Team<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Team"."Points"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Points
		{
			get { return (System.Int32)GetValue((int)TeamFieldIndex.Points, true); }
			set	{ SetValue((int)TeamFieldIndex.Points, value); }
		}

		/// <summary> The IsActive property of the Entity Team<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Team"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)TeamFieldIndex.IsActive, true); }
			set	{ SetValue((int)TeamFieldIndex.IsActive, value); }
		}

		/// <summary> The OrderNo property of the Entity Team<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Team"."OrderNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> OrderNo
		{
			get { return (Nullable<System.Int32>)GetValue((int)TeamFieldIndex.OrderNo, false); }
			set	{ SetValue((int)TeamFieldIndex.OrderNo, value); }
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
					_teamPost.SetContainingEntityInfo(this, "Team");
				}
				return _teamPost;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WeeklyProgrammeMatchEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WeeklyProgrammeMatchEntity))]
		public virtual EntityCollection<WeeklyProgrammeMatchEntity> WeeklyProgrammeMatch_
		{
			get
			{
				if(_weeklyProgrammeMatch_==null)
				{
					_weeklyProgrammeMatch_ = new EntityCollection<WeeklyProgrammeMatchEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeMatchEntityFactory)));
					_weeklyProgrammeMatch_.SetContainingEntityInfo(this, "Team_");
				}
				return _weeklyProgrammeMatch_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WeeklyProgrammeMatchEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WeeklyProgrammeMatchEntity))]
		public virtual EntityCollection<WeeklyProgrammeMatchEntity> WeeklyProgrammeMatch
		{
			get
			{
				if(_weeklyProgrammeMatch==null)
				{
					_weeklyProgrammeMatch = new EntityCollection<WeeklyProgrammeMatchEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeMatchEntityFactory)));
					_weeklyProgrammeMatch.SetContainingEntityInfo(this, "Team");
				}
				return _weeklyProgrammeMatch;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PostEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(PostEntity))]
		public virtual EntityCollection<PostEntity> PostCollectionViaTeamPost
		{
			get
			{
				if(_postCollectionViaTeamPost==null)
				{
					_postCollectionViaTeamPost = new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory)));
					_postCollectionViaTeamPost.IsReadOnly=true;
				}
				return _postCollectionViaTeamPost;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WeeklyProgrammeDayEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WeeklyProgrammeDayEntity))]
		public virtual EntityCollection<WeeklyProgrammeDayEntity> WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_
		{
			get
			{
				if(_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_==null)
				{
					_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_ = new EntityCollection<WeeklyProgrammeDayEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeDayEntityFactory)));
					_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_.IsReadOnly=true;
				}
				return _weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WeeklyProgrammeDayEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WeeklyProgrammeDayEntity))]
		public virtual EntityCollection<WeeklyProgrammeDayEntity> WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch
		{
			get
			{
				if(_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch==null)
				{
					_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch = new EntityCollection<WeeklyProgrammeDayEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeDayEntityFactory)));
					_weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch.IsReadOnly=true;
				}
				return _weeklyProgrammeDayCollectionViaWeeklyProgrammeMatch;
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
			get { return (int)LLBLGenTest.LLBL.EntityType.TeamEntity; }
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
