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
	/// <summary>Implements the static Relations variant for the entity: Team. </summary>
	public partial class TeamRelations
	{
		/// <summary>CTor</summary>
		public TeamRelations()
		{
		}

		/// <summary>Gets all relations of the TeamEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.TeamPostEntityUsingFkTeamId);
			toReturn.Add(this.WeeklyProgrammeMatchEntityUsingFkTeam2);
			toReturn.Add(this.WeeklyProgrammeMatchEntityUsingFkTeam1);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and TeamPostEntity over the 1:n relation they have, using the relation between the fields:
		/// Team.TeamId - TeamPost.FkTeamId
		/// </summary>
		public virtual IEntityRelation TeamPostEntityUsingFkTeamId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "TeamPost" , true);
				relation.AddEntityFieldPair(TeamFields.TeamId, TeamPostFields.FkTeamId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TeamEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TeamPostEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and WeeklyProgrammeMatchEntity over the 1:n relation they have, using the relation between the fields:
		/// Team.TeamId - WeeklyProgrammeMatch.FkTeam2
		/// </summary>
		public virtual IEntityRelation WeeklyProgrammeMatchEntityUsingFkTeam2
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WeeklyProgrammeMatch_" , true);
				relation.AddEntityFieldPair(TeamFields.TeamId, WeeklyProgrammeMatchFields.FkTeam2);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TeamEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WeeklyProgrammeMatchEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and WeeklyProgrammeMatchEntity over the 1:n relation they have, using the relation between the fields:
		/// Team.TeamId - WeeklyProgrammeMatch.FkTeam1
		/// </summary>
		public virtual IEntityRelation WeeklyProgrammeMatchEntityUsingFkTeam1
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WeeklyProgrammeMatch" , true);
				relation.AddEntityFieldPair(TeamFields.TeamId, WeeklyProgrammeMatchFields.FkTeam1);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TeamEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WeeklyProgrammeMatchEntity", false);
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
