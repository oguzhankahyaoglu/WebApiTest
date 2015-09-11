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
	/// Entity class which represents the entity 'WeeklyProgrammeMatch'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class WeeklyProgrammeMatchEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private TeamEntity _team_;
		private TeamEntity _team;
		private WeeklyProgrammeDayEntity _weeklyProgrammeDay;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Team_</summary>
			public static readonly string Team_ = "Team_";
			/// <summary>Member name Team</summary>
			public static readonly string Team = "Team";
			/// <summary>Member name WeeklyProgrammeDay</summary>
			public static readonly string WeeklyProgrammeDay = "WeeklyProgrammeDay";



		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static WeeklyProgrammeMatchEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public WeeklyProgrammeMatchEntity():base("WeeklyProgrammeMatchEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public WeeklyProgrammeMatchEntity(IEntityFields2 fields):base("WeeklyProgrammeMatchEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this WeeklyProgrammeMatchEntity</param>
		public WeeklyProgrammeMatchEntity(IValidator validator):base("WeeklyProgrammeMatchEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="weeklyProgrammeMatchId">PK value for WeeklyProgrammeMatch which data should be fetched into this WeeklyProgrammeMatch object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public WeeklyProgrammeMatchEntity(System.Int32 weeklyProgrammeMatchId):base("WeeklyProgrammeMatchEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.WeeklyProgrammeMatchId = weeklyProgrammeMatchId;
		}

		/// <summary> CTor</summary>
		/// <param name="weeklyProgrammeMatchId">PK value for WeeklyProgrammeMatch which data should be fetched into this WeeklyProgrammeMatch object</param>
		/// <param name="validator">The custom validator object for this WeeklyProgrammeMatchEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public WeeklyProgrammeMatchEntity(System.Int32 weeklyProgrammeMatchId, IValidator validator):base("WeeklyProgrammeMatchEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.WeeklyProgrammeMatchId = weeklyProgrammeMatchId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected WeeklyProgrammeMatchEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				_team_ = (TeamEntity)info.GetValue("_team_", typeof(TeamEntity));
				if(_team_!=null)
				{
					_team_.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_team = (TeamEntity)info.GetValue("_team", typeof(TeamEntity));
				if(_team!=null)
				{
					_team.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_weeklyProgrammeDay = (WeeklyProgrammeDayEntity)info.GetValue("_weeklyProgrammeDay", typeof(WeeklyProgrammeDayEntity));
				if(_weeklyProgrammeDay!=null)
				{
					_weeklyProgrammeDay.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((WeeklyProgrammeMatchFieldIndex)fieldIndex)
			{
				case WeeklyProgrammeMatchFieldIndex.FkWeeklyProgrammeDayId:
					DesetupSyncWeeklyProgrammeDay(true, false);
					break;
				case WeeklyProgrammeMatchFieldIndex.FkTeam1:
					DesetupSyncTeam(true, false);
					break;
				case WeeklyProgrammeMatchFieldIndex.FkTeam2:
					DesetupSyncTeam_(true, false);
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
				case "Team_":
					this.Team_ = (TeamEntity)entity;
					break;
				case "Team":
					this.Team = (TeamEntity)entity;
					break;
				case "WeeklyProgrammeDay":
					this.WeeklyProgrammeDay = (WeeklyProgrammeDayEntity)entity;
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
			return WeeklyProgrammeMatchEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Team_":
					toReturn.Add(WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam2);
					break;
				case "Team":
					toReturn.Add(WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam1);
					break;
				case "WeeklyProgrammeDay":
					toReturn.Add(WeeklyProgrammeMatchEntity.Relations.WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId);
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
				case "Team_":
					SetupSyncTeam_(relatedEntity);
					break;
				case "Team":
					SetupSyncTeam(relatedEntity);
					break;
				case "WeeklyProgrammeDay":
					SetupSyncWeeklyProgrammeDay(relatedEntity);
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
				case "Team_":
					DesetupSyncTeam_(false, true);
					break;
				case "Team":
					DesetupSyncTeam(false, true);
					break;
				case "WeeklyProgrammeDay":
					DesetupSyncWeeklyProgrammeDay(false, true);
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
			if(_team_!=null)
			{
				toReturn.Add(_team_);
			}
			if(_team!=null)
			{
				toReturn.Add(_team);
			}
			if(_weeklyProgrammeDay!=null)
			{
				toReturn.Add(_weeklyProgrammeDay);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();


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


				info.AddValue("_team_", (!this.MarkedForDeletion?_team_:null));
				info.AddValue("_team", (!this.MarkedForDeletion?_team:null));
				info.AddValue("_weeklyProgrammeDay", (!this.MarkedForDeletion?_weeklyProgrammeDay:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(WeeklyProgrammeMatchFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(WeeklyProgrammeMatchFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new WeeklyProgrammeMatchRelations().GetAllRelations();
		}
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Team' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTeam_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TeamFields.TeamId, null, ComparisonOperator.Equal, this.FkTeam2));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Team' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTeam()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TeamFields.TeamId, null, ComparisonOperator.Equal, this.FkTeam1));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'WeeklyProgrammeDay' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWeeklyProgrammeDay()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WeeklyProgrammeDayFields.WeeklyProgrammeDayId, null, ComparisonOperator.Equal, this.FkWeeklyProgrammeDayId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeMatchEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);


		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);


		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{


			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);


		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Team_", _team_);
			toReturn.Add("Team", _team);
			toReturn.Add("WeeklyProgrammeDay", _weeklyProgrammeDay);



			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_team_!=null)
			{
				_team_.ActiveContext = base.ActiveContext;
			}
			if(_team!=null)
			{
				_team.ActiveContext = base.ActiveContext;
			}
			if(_weeklyProgrammeDay!=null)
			{
				_weeklyProgrammeDay.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_team_ = null;
			_team = null;
			_weeklyProgrammeDay = null;

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

			_fieldsCustomProperties.Add("WeeklyProgrammeMatchId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FkWeeklyProgrammeDayId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Time", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FkTeam1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FkTeam2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OrderNo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _team_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncTeam_(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _team_, new PropertyChangedEventHandler( OnTeam_PropertyChanged ), "Team_", WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam2, true, signalRelatedEntity, "WeeklyProgrammeMatch_", resetFKFields, new int[] { (int)WeeklyProgrammeMatchFieldIndex.FkTeam2 } );		
			_team_ = null;
		}

		/// <summary> setups the sync logic for member _team_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncTeam_(IEntity2 relatedEntity)
		{
			if(_team_!=relatedEntity)
			{
				DesetupSyncTeam_(true, true);
				_team_ = (TeamEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _team_, new PropertyChangedEventHandler( OnTeam_PropertyChanged ), "Team_", WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam2, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTeam_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _team</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncTeam(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _team, new PropertyChangedEventHandler( OnTeamPropertyChanged ), "Team", WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam1, true, signalRelatedEntity, "WeeklyProgrammeMatch", resetFKFields, new int[] { (int)WeeklyProgrammeMatchFieldIndex.FkTeam1 } );		
			_team = null;
		}

		/// <summary> setups the sync logic for member _team</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncTeam(IEntity2 relatedEntity)
		{
			if(_team!=relatedEntity)
			{
				DesetupSyncTeam(true, true);
				_team = (TeamEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _team, new PropertyChangedEventHandler( OnTeamPropertyChanged ), "Team", WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam1, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTeamPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _weeklyProgrammeDay</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWeeklyProgrammeDay(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _weeklyProgrammeDay, new PropertyChangedEventHandler( OnWeeklyProgrammeDayPropertyChanged ), "WeeklyProgrammeDay", WeeklyProgrammeMatchEntity.Relations.WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId, true, signalRelatedEntity, "WeeklyProgrammeMatch", resetFKFields, new int[] { (int)WeeklyProgrammeMatchFieldIndex.FkWeeklyProgrammeDayId } );		
			_weeklyProgrammeDay = null;
		}

		/// <summary> setups the sync logic for member _weeklyProgrammeDay</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWeeklyProgrammeDay(IEntity2 relatedEntity)
		{
			if(_weeklyProgrammeDay!=relatedEntity)
			{
				DesetupSyncWeeklyProgrammeDay(true, true);
				_weeklyProgrammeDay = (WeeklyProgrammeDayEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _weeklyProgrammeDay, new PropertyChangedEventHandler( OnWeeklyProgrammeDayPropertyChanged ), "WeeklyProgrammeDay", WeeklyProgrammeMatchEntity.Relations.WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWeeklyProgrammeDayPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this WeeklyProgrammeMatchEntity</param>
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
		public  static WeeklyProgrammeMatchRelations Relations
		{
			get	{ return new WeeklyProgrammeMatchRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}



		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTeam_
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(TeamEntityFactory))),
					(IEntityRelation)GetRelationsForField("Team_")[0], (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, 0, null, null, null, null, "Team_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTeam
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(TeamEntityFactory))),
					(IEntityRelation)GetRelationsForField("Team")[0], (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, 0, null, null, null, null, "Team", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeDay' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeDay
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(WeeklyProgrammeDayEntityFactory))),
					(IEntityRelation)GetRelationsForField("WeeklyProgrammeDay")[0], (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity, 0, null, null, null, null, "WeeklyProgrammeDay", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return WeeklyProgrammeMatchEntity.CustomProperties;}
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
			get { return WeeklyProgrammeMatchEntity.FieldsCustomProperties;}
		}

		/// <summary> The WeeklyProgrammeMatchId property of the Entity WeeklyProgrammeMatch<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WeeklyProgrammeMatch"."WeeklyProgrammeMatchID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 WeeklyProgrammeMatchId
		{
			get { return (System.Int32)GetValue((int)WeeklyProgrammeMatchFieldIndex.WeeklyProgrammeMatchId, true); }
			set	{ SetValue((int)WeeklyProgrammeMatchFieldIndex.WeeklyProgrammeMatchId, value); }
		}

		/// <summary> The FkWeeklyProgrammeDayId property of the Entity WeeklyProgrammeMatch<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WeeklyProgrammeMatch"."FK_WeeklyProgrammeDayId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> FkWeeklyProgrammeDayId
		{
			get { return (Nullable<System.Int32>)GetValue((int)WeeklyProgrammeMatchFieldIndex.FkWeeklyProgrammeDayId, false); }
			set	{ SetValue((int)WeeklyProgrammeMatchFieldIndex.FkWeeklyProgrammeDayId, value); }
		}

		/// <summary> The Time property of the Entity WeeklyProgrammeMatch<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WeeklyProgrammeMatch"."Time"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Time
		{
			get { return (System.String)GetValue((int)WeeklyProgrammeMatchFieldIndex.Time, true); }
			set	{ SetValue((int)WeeklyProgrammeMatchFieldIndex.Time, value); }
		}

		/// <summary> The FkTeam1 property of the Entity WeeklyProgrammeMatch<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WeeklyProgrammeMatch"."FK_Team1"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> FkTeam1
		{
			get { return (Nullable<System.Int32>)GetValue((int)WeeklyProgrammeMatchFieldIndex.FkTeam1, false); }
			set	{ SetValue((int)WeeklyProgrammeMatchFieldIndex.FkTeam1, value); }
		}

		/// <summary> The FkTeam2 property of the Entity WeeklyProgrammeMatch<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WeeklyProgrammeMatch"."FK_Team2"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> FkTeam2
		{
			get { return (Nullable<System.Int32>)GetValue((int)WeeklyProgrammeMatchFieldIndex.FkTeam2, false); }
			set	{ SetValue((int)WeeklyProgrammeMatchFieldIndex.FkTeam2, value); }
		}

		/// <summary> The OrderNo property of the Entity WeeklyProgrammeMatch<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WeeklyProgrammeMatch"."OrderNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> OrderNo
		{
			get { return (Nullable<System.Int32>)GetValue((int)WeeklyProgrammeMatchFieldIndex.OrderNo, false); }
			set	{ SetValue((int)WeeklyProgrammeMatchFieldIndex.OrderNo, value); }
		}

		/// <summary> The IsActive property of the Entity WeeklyProgrammeMatch<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WeeklyProgrammeMatch"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsActive
		{
			get { return (Nullable<System.Boolean>)GetValue((int)WeeklyProgrammeMatchFieldIndex.IsActive, false); }
			set	{ SetValue((int)WeeklyProgrammeMatchFieldIndex.IsActive, value); }
		}



		/// <summary> Gets / sets related entity of type 'TeamEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual TeamEntity Team_
		{
			get
			{
				return _team_;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncTeam_(value);
				}
				else
				{
					if(value==null)
					{
						if(_team_ != null)
						{
							_team_.UnsetRelatedEntity(this, "WeeklyProgrammeMatch_");
						}
					}
					else
					{
						if(_team_!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "WeeklyProgrammeMatch_");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'TeamEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual TeamEntity Team
		{
			get
			{
				return _team;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncTeam(value);
				}
				else
				{
					if(value==null)
					{
						if(_team != null)
						{
							_team.UnsetRelatedEntity(this, "WeeklyProgrammeMatch");
						}
					}
					else
					{
						if(_team!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "WeeklyProgrammeMatch");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'WeeklyProgrammeDayEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual WeeklyProgrammeDayEntity WeeklyProgrammeDay
		{
			get
			{
				return _weeklyProgrammeDay;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWeeklyProgrammeDay(value);
				}
				else
				{
					if(value==null)
					{
						if(_weeklyProgrammeDay != null)
						{
							_weeklyProgrammeDay.UnsetRelatedEntity(this, "WeeklyProgrammeMatch");
						}
					}
					else
					{
						if(_weeklyProgrammeDay!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "WeeklyProgrammeMatch");
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
			get { return (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity; }
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
