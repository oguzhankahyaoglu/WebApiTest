///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 09 Eylül 2015 Çarşamba 16:20:09
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
	/// <summary>Implements the static Relations variant for the entity: WeeklyProgrammeMatch. </summary>
	public partial class WeeklyProgrammeMatchRelations
	{
		/// <summary>CTor</summary>
		public WeeklyProgrammeMatchRelations()
		{
		}

		/// <summary>Gets all relations of the WeeklyProgrammeMatchEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.TeamEntityUsingFkTeam2);
			toReturn.Add(this.TeamEntityUsingFkTeam1);
			toReturn.Add(this.WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between WeeklyProgrammeMatchEntity and TeamEntity over the m:1 relation they have, using the relation between the fields:
		/// WeeklyProgrammeMatch.FkTeam2 - Team.TeamId
		/// </summary>
		public virtual IEntityRelation TeamEntityUsingFkTeam2
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Team_", false);
				relation.AddEntityFieldPair(TeamFields.TeamId, WeeklyProgrammeMatchFields.FkTeam2);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TeamEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WeeklyProgrammeMatchEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WeeklyProgrammeMatchEntity and TeamEntity over the m:1 relation they have, using the relation between the fields:
		/// WeeklyProgrammeMatch.FkTeam1 - Team.TeamId
		/// </summary>
		public virtual IEntityRelation TeamEntityUsingFkTeam1
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Team", false);
				relation.AddEntityFieldPair(TeamFields.TeamId, WeeklyProgrammeMatchFields.FkTeam1);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TeamEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WeeklyProgrammeMatchEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WeeklyProgrammeMatchEntity and WeeklyProgrammeDayEntity over the m:1 relation they have, using the relation between the fields:
		/// WeeklyProgrammeMatch.FkWeeklyProgrammeDayId - WeeklyProgrammeDay.WeeklyProgrammeDayId
		/// </summary>
		public virtual IEntityRelation WeeklyProgrammeDayEntityUsingFkWeeklyProgrammeDayId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WeeklyProgrammeDay", false);
				relation.AddEntityFieldPair(WeeklyProgrammeDayFields.WeeklyProgrammeDayId, WeeklyProgrammeMatchFields.FkWeeklyProgrammeDayId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WeeklyProgrammeDayEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WeeklyProgrammeMatchEntity", true);
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
