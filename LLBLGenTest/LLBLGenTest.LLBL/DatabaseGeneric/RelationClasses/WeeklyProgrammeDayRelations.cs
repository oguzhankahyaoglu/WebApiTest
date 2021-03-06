﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 10 Eylül 2015 Perşembe 16:20:14
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
	/// <summary>Implements the static Relations variant for the entity: WeeklyProgrammeDay. </summary>
	public partial class WeeklyProgrammeDayRelations
	{
		/// <summary>CTor</summary>
		public WeeklyProgrammeDayRelations()
		{
		}

		/// <summary>Gets all relations of the WeeklyProgrammeDayEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.WeeklyProgrammeMatchEntityUsingFkWeeklyProgrammeDayId);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between WeeklyProgrammeDayEntity and WeeklyProgrammeMatchEntity over the 1:n relation they have, using the relation between the fields:
		/// WeeklyProgrammeDay.WeeklyProgrammeDayId - WeeklyProgrammeMatch.FkWeeklyProgrammeDayId
		/// </summary>
		public virtual IEntityRelation WeeklyProgrammeMatchEntityUsingFkWeeklyProgrammeDayId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WeeklyProgrammeMatch" , true);
				relation.AddEntityFieldPair(WeeklyProgrammeDayFields.WeeklyProgrammeDayId, WeeklyProgrammeMatchFields.FkWeeklyProgrammeDayId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WeeklyProgrammeDayEntity", true);
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
