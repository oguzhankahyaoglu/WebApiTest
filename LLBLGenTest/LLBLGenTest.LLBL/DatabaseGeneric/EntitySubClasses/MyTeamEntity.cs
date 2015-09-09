///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 09 Eylül 2015 Çarşamba 16:20:11
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
	/// Entity class which represents the entity 'Team'.
	/// </summary>
	[Serializable]
	public partial class MyTeamEntity : TeamEntity, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		/// <summary> CTor</summary>
		public MyTeamEntity()
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MyTeamEntity(IEntityFields2 fields):base(fields)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TeamEntity</param>
		public MyTeamEntity(IValidator validator):base(validator)
		{
			InitClass();
		}
				

		/// <summary> CTor</summary>
		/// <param name="teamId">PK value for Team which data should be fetched into this Team object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyTeamEntity(System.Int32 teamId):base(teamId)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="teamId">PK value for Team which data should be fetched into this Team object</param>
		/// <param name="validator">The custom validator object for this TeamEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyTeamEntity(System.Int32 teamId, IValidator validator):base(teamId, validator)
		{
			InitClass();
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MyTeamEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			InitClass();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new MyTeamEntityFactory();
		}
		
		/// <summary>Initialization routine for class</summary>
		private void InitClass()
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		#region Class Property Declarations

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
					TeamEntity.Relations.TeamPostEntityUsingFkTeamId, 
					(int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.TeamPostEntity, 0, null, null, null, null, "TeamPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeMatch' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeMatch_
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyWeeklyProgrammeMatchEntityFactory()),
					TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam2, 
					(int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, 0, null, null, null, null, "WeeklyProgrammeMatch_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

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
					TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam1, 
					(int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, 0, null, null, null, null, "WeeklyProgrammeMatch", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathPostCollectionViaTeamPost
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = TeamEntity.Relations.TeamPostEntityUsingFkTeamId;
				intermediateRelation.SetAliases(string.Empty, "TeamPost_");
				relations.Add(TeamEntity.Relations.TeamPostEntityUsingFkTeamId, "TeamEntity__", "TeamPost_", JoinHint.None);
				relations.Add(TeamPostEntity.Relations.PostEntityUsingFkPostId, "TeamPost_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyPostEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.PostEntity, 0, null, null, relations, null, "PostCollectionViaTeamPost", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeDay' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam2;
				intermediateRelation.SetAliases(string.Empty, "WeeklyProgrammeMatch_");
				relations.Add(TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam2, "TeamEntity__", "WeeklyProgrammeMatch_", JoinHint.None);
				relations.Add(WeeklyProgrammeMatchEntity.Relations.WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId, "WeeklyProgrammeMatch_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyWeeklyProgrammeDayEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity, 0, null, null, relations, null, "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeDay' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam1;
				intermediateRelation.SetAliases(string.Empty, "WeeklyProgrammeMatch_");
				relations.Add(TeamEntity.Relations.WeeklyProgrammeMatchEntityUsingFkTeam1, "TeamEntity__", "WeeklyProgrammeMatch_", JoinHint.None);
				relations.Add(WeeklyProgrammeMatchEntity.Relations.WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId, "WeeklyProgrammeMatch_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyWeeklyProgrammeDayEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity, 0, null, null, relations, null, "WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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
		/// Gets the EntityCollection with the related entities of type 'MyWeeklyProgrammeMatchEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyWeeklyProgrammeMatchEntity))]
		public override EntityCollection<WeeklyProgrammeMatchEntity> WeeklyProgrammeMatch_
		{
			get
			{
				EntityCollection<WeeklyProgrammeMatchEntity> toReturn = base.WeeklyProgrammeMatch_;
				toReturn.EntityFactoryToUse = new MyWeeklyProgrammeMatchEntityFactory();
				return toReturn;
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
		/// Gets the EntityCollection with the related entities of type 'MyPostEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyPostEntity))]
		public override EntityCollection<PostEntity> PostCollectionViaTeamPost
		{
			get
			{
				EntityCollection<PostEntity> toReturn = base.PostCollectionViaTeamPost;
				toReturn.EntityFactoryToUse = new MyPostEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyWeeklyProgrammeDayEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyWeeklyProgrammeDayEntity))]
		public override EntityCollection<WeeklyProgrammeDayEntity> WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_
		{
			get
			{
				EntityCollection<WeeklyProgrammeDayEntity> toReturn = base.WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch_;
				toReturn.EntityFactoryToUse = new MyWeeklyProgrammeDayEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyWeeklyProgrammeDayEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyWeeklyProgrammeDayEntity))]
		public override EntityCollection<WeeklyProgrammeDayEntity> WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch
		{
			get
			{
				EntityCollection<WeeklyProgrammeDayEntity> toReturn = base.WeeklyProgrammeDayCollectionViaWeeklyProgrammeMatch;
				toReturn.EntityFactoryToUse = new MyWeeklyProgrammeDayEntityFactory();
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
