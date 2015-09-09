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
	/// Entity class which represents the entity 'WeeklyProgrammeDay'.
	/// </summary>
	[Serializable]
	public partial class MyWeeklyProgrammeDayEntity : WeeklyProgrammeDayEntity, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		/// <summary> CTor</summary>
		public MyWeeklyProgrammeDayEntity()
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MyWeeklyProgrammeDayEntity(IEntityFields2 fields):base(fields)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this WeeklyProgrammeDayEntity</param>
		public MyWeeklyProgrammeDayEntity(IValidator validator):base(validator)
		{
			InitClass();
		}
				

		/// <summary> CTor</summary>
		/// <param name="weeklyProgrammeDayId">PK value for WeeklyProgrammeDay which data should be fetched into this WeeklyProgrammeDay object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyWeeklyProgrammeDayEntity(System.Int32 weeklyProgrammeDayId):base(weeklyProgrammeDayId)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="weeklyProgrammeDayId">PK value for WeeklyProgrammeDay which data should be fetched into this WeeklyProgrammeDay object</param>
		/// <param name="validator">The custom validator object for this WeeklyProgrammeDayEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyWeeklyProgrammeDayEntity(System.Int32 weeklyProgrammeDayId, IValidator validator):base(weeklyProgrammeDayId, validator)
		{
			InitClass();
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MyWeeklyProgrammeDayEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			InitClass();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new MyWeeklyProgrammeDayEntityFactory();
		}
		
		/// <summary>Initialization routine for class</summary>
		private void InitClass()
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		#region Class Property Declarations

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeMatch' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeMatch
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyWeeklyProgrammeMatchEntityFactory()),
					WeeklyProgrammeDayEntity.Relations.WeeklyProgrammeMatchEntityUsingFkWeeklyProgrammeDayId, 
					(int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, 0, null, null, null, null, "WeeklyProgrammeMatch", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathTeamCollectionViaWeeklyProgrammeMatch_
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = WeeklyProgrammeDayEntity.Relations.WeeklyProgrammeMatchEntityUsingFkWeeklyProgrammeDayId;
				intermediateRelation.SetAliases(string.Empty, "WeeklyProgrammeMatch_");
				relations.Add(WeeklyProgrammeDayEntity.Relations.WeeklyProgrammeMatchEntityUsingFkWeeklyProgrammeDayId, "WeeklyProgrammeDayEntity__", "WeeklyProgrammeMatch_", JoinHint.None);
				relations.Add(WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam2, "WeeklyProgrammeMatch_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyTeamEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, 0, null, null, relations, null, "TeamCollectionViaWeeklyProgrammeMatch_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathTeamCollectionViaWeeklyProgrammeMatch
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = WeeklyProgrammeDayEntity.Relations.WeeklyProgrammeMatchEntityUsingFkWeeklyProgrammeDayId;
				intermediateRelation.SetAliases(string.Empty, "WeeklyProgrammeMatch_");
				relations.Add(WeeklyProgrammeDayEntity.Relations.WeeklyProgrammeMatchEntityUsingFkWeeklyProgrammeDayId, "WeeklyProgrammeDayEntity__", "WeeklyProgrammeMatch_", JoinHint.None);
				relations.Add(WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam1, "WeeklyProgrammeMatch_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyTeamEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, 0, null, null, relations, null, "TeamCollectionViaWeeklyProgrammeMatch", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyWeeklyProgrammeMatchEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyWeeklyProgrammeMatchEntity))]
		public override EntityCollection<WeeklyProgrammeMatchEntity> WeeklyProgrammeMatch
		{
			get
			{
				EntityCollection<WeeklyProgrammeMatchEntity> toReturn = base.WeeklyProgrammeMatch;
				toReturn.EntityFactoryToUse = new MyWeeklyProgrammeMatchEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyTeamEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyTeamEntity))]
		public override EntityCollection<TeamEntity> TeamCollectionViaWeeklyProgrammeMatch_
		{
			get
			{
				EntityCollection<TeamEntity> toReturn = base.TeamCollectionViaWeeklyProgrammeMatch_;
				toReturn.EntityFactoryToUse = new MyTeamEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyTeamEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyTeamEntity))]
		public override EntityCollection<TeamEntity> TeamCollectionViaWeeklyProgrammeMatch
		{
			get
			{
				EntityCollection<TeamEntity> toReturn = base.TeamCollectionViaWeeklyProgrammeMatch;
				toReturn.EntityFactoryToUse = new MyTeamEntityFactory();
				return toReturn;
			}
		}


		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
	}
}
