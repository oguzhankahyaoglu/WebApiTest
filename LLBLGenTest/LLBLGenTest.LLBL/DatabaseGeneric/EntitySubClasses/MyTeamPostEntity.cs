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
	/// Entity class which represents the entity 'TeamPost'.
	/// </summary>
	[Serializable]
	public partial class MyTeamPostEntity : TeamPostEntity, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		/// <summary> CTor</summary>
		public MyTeamPostEntity()
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MyTeamPostEntity(IEntityFields2 fields):base(fields)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TeamPostEntity</param>
		public MyTeamPostEntity(IValidator validator):base(validator)
		{
			InitClass();
		}
				

		/// <summary> CTor</summary>
		/// <param name="teamPostId">PK value for TeamPost which data should be fetched into this TeamPost object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyTeamPostEntity(System.Int32 teamPostId):base(teamPostId)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="teamPostId">PK value for TeamPost which data should be fetched into this TeamPost object</param>
		/// <param name="validator">The custom validator object for this TeamPostEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyTeamPostEntity(System.Int32 teamPostId, IValidator validator):base(teamPostId, validator)
		{
			InitClass();
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MyTeamPostEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			InitClass();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new MyTeamPostEntityFactory();
		}
		
		/// <summary>Initialization routine for class</summary>
		private void InitClass()
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		#region Class Property Declarations



		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathPost
		{
			get
			{
				return new PrefetchPathElement2(
					new EntityCollection(new MyPostEntityFactory()),
					TeamPostEntity.Relations.PostEntityUsingFkPostId, 
					(int)LLBLGenTest.LLBL.EntityType.TeamPostEntity, (int)LLBLGenTest.LLBL.EntityType.PostEntity, 0, null, null, null, null, "Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					TeamPostEntity.Relations.TeamEntityUsingFkTeamId, 
					(int)LLBLGenTest.LLBL.EntityType.TeamPostEntity, (int)LLBLGenTest.LLBL.EntityType.TeamEntity, 0, null, null, null, null, "Team", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}




		/// <summary>
		/// Gets / sets related entity of type 'MyPostEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned.
		/// This property is not visible in databinded grids.
		/// </summary>
		[Browsable(false)]
		public new virtual MyPostEntity Post
		{
			get	{ return (MyPostEntity)base.Post; }
			set	{ base.Post = value;	}
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

		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
	}
}
