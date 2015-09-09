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
	/// Entity class which represents the entity 'WeeklyProgrammeMatch'.
	/// </summary>
	[Serializable]
	public partial class MyWeeklyProgrammeMatchEntity : WeeklyProgrammeMatchEntity, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		/// <summary> CTor</summary>
		public MyWeeklyProgrammeMatchEntity()
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MyWeeklyProgrammeMatchEntity(IEntityFields2 fields):base(fields)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this WeeklyProgrammeMatchEntity</param>
		public MyWeeklyProgrammeMatchEntity(IValidator validator):base(validator)
		{
			InitClass();
		}
				

		/// <summary> CTor</summary>
		/// <param name="weeklyProgrammeMatchId">PK value for WeeklyProgrammeMatch which data should be fetched into this WeeklyProgrammeMatch object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyWeeklyProgrammeMatchEntity(System.Int32 weeklyProgrammeMatchId):base(weeklyProgrammeMatchId)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="weeklyProgrammeMatchId">PK value for WeeklyProgrammeMatch which data should be fetched into this WeeklyProgrammeMatch object</param>
		/// <param name="validator">The custom validator object for this WeeklyProgrammeMatchEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyWeeklyProgrammeMatchEntity(System.Int32 weeklyProgrammeMatchId, IValidator validator):base(weeklyProgrammeMatchId, validator)
		{
			InitClass();
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MyWeeklyProgrammeMatchEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			InitClass();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new MyWeeklyProgrammeMatchEntityFactory();
		}
		
		/// <summary>Initialization routine for class</summary>
		private void InitClass()
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		#region Class Property Declarations



		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathTeam_
		{
			get
			{
				return new PrefetchPathElement2(
					new EntityCollection(new MyTeamEntityFactory()),
					WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam2, 
					(int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, 0, null, null, null, null, "Team_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathTeam
		{
			get
			{
				return new PrefetchPathElement2(
					new EntityCollection(new MyTeamEntityFactory()),
					WeeklyProgrammeMatchEntity.Relations.TeamEntityUsingFkTeam1, 
					(int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, 0, null, null, null, null, "Team", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WeeklyProgrammeDay' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathWeeklyProgrammeDay
		{
			get
			{
				return new PrefetchPathElement2(
					new EntityCollection(new MyWeeklyProgrammeDayEntityFactory()),
					WeeklyProgrammeMatchEntity.Relations.WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId, 
					(int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity, (int)LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity, 0, null, null, null, null, "WeeklyProgrammeDay", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}




		/// <summary>
		/// Gets / sets related entity of type 'MyTeamEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned.
		/// This property is not visible in databinded grids.
		/// </summary>
		[Browsable(false)]
		public new virtual MyTeamEntity Team_
		{
			get	{ return (MyTeamEntity)base.Team_; }
			set	{ base.Team_ = value;	}
		}

		/// <summary>
		/// Gets / sets related entity of type 'MyTeamEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned.
		/// This property is not visible in databinded grids.
		/// </summary>
		[Browsable(false)]
		public new virtual MyTeamEntity Team
		{
			get	{ return (MyTeamEntity)base.Team; }
			set	{ base.Team = value;	}
		}

		/// <summary>
		/// Gets / sets related entity of type 'MyWeeklyProgrammeDayEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned.
		/// This property is not visible in databinded grids.
		/// </summary>
		[Browsable(false)]
		public new virtual MyWeeklyProgrammeDayEntity WeeklyProgrammeDay
		{
			get	{ return (MyWeeklyProgrammeDayEntity)base.WeeklyProgrammeDay; }
			set	{ base.WeeklyProgrammeDay = value;	}
		}

		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
	}
}
