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
	/// Entity class which represents the entity 'Category1Post'.
	/// </summary>
	[Serializable]
	public partial class MyCategory1PostEntity : Category1PostEntity, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		/// <summary> CTor</summary>
		public MyCategory1PostEntity()
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MyCategory1PostEntity(IEntityFields2 fields):base(fields)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this Category1PostEntity</param>
		public MyCategory1PostEntity(IValidator validator):base(validator)
		{
			InitClass();
		}
				

		/// <summary> CTor</summary>
		/// <param name="category1PostId">PK value for Category1Post which data should be fetched into this Category1Post object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyCategory1PostEntity(System.Int32 category1PostId):base(category1PostId)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="category1PostId">PK value for Category1Post which data should be fetched into this Category1Post object</param>
		/// <param name="validator">The custom validator object for this Category1PostEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyCategory1PostEntity(System.Int32 category1PostId, IValidator validator):base(category1PostId, validator)
		{
			InitClass();
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MyCategory1PostEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			InitClass();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new MyCategory1PostEntityFactory();
		}
		
		/// <summary>Initialization routine for class</summary>
		private void InitClass()
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		#region Class Property Declarations



		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category1' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathCategory1
		{
			get
			{
				return new PrefetchPathElement2(
					new EntityCollection(new MyCategory1EntityFactory()),
					Category1PostEntity.Relations.Category1EntityUsingFkCategory1Id, 
					(int)LLBLGenTest.LLBL.EntityType.Category1PostEntity, (int)LLBLGenTest.LLBL.EntityType.Category1Entity, 0, null, null, null, null, "Category1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

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
					Category1PostEntity.Relations.PostEntityUsingFkPostId, 
					(int)LLBLGenTest.LLBL.EntityType.Category1PostEntity, (int)LLBLGenTest.LLBL.EntityType.PostEntity, 0, null, null, null, null, "Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}




		/// <summary>
		/// Gets / sets related entity of type 'MyCategory1Entity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned.
		/// This property is not visible in databinded grids.
		/// </summary>
		[Browsable(false)]
		public new virtual MyCategory1Entity Category1
		{
			get	{ return (MyCategory1Entity)base.Category1; }
			set	{ base.Category1 = value;	}
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

		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
	}
}
