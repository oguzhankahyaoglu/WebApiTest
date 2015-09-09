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
	/// Entity class which represents the entity 'Category2'.
	/// </summary>
	[Serializable]
	public partial class MyCategory2Entity : Category2Entity, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		/// <summary> CTor</summary>
		public MyCategory2Entity()
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MyCategory2Entity(IEntityFields2 fields):base(fields)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this Category2Entity</param>
		public MyCategory2Entity(IValidator validator):base(validator)
		{
			InitClass();
		}
				

		/// <summary> CTor</summary>
		/// <param name="category2Id">PK value for Category2 which data should be fetched into this Category2 object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyCategory2Entity(System.Int32 category2Id):base(category2Id)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="category2Id">PK value for Category2 which data should be fetched into this Category2 object</param>
		/// <param name="validator">The custom validator object for this Category2Entity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyCategory2Entity(System.Int32 category2Id, IValidator validator):base(category2Id, validator)
		{
			InitClass();
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MyCategory2Entity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			InitClass();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new MyCategory2EntityFactory();
		}
		
		/// <summary>Initialization routine for class</summary>
		private void InitClass()
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		#region Class Property Declarations

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category2Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathCategory2Post
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyCategory2PostEntityFactory()),
					Category2Entity.Relations.Category2PostEntityUsingFkCategory2Id, 
					(int)LLBLGenTest.LLBL.EntityType.Category2Entity, (int)LLBLGenTest.LLBL.EntityType.Category2PostEntity, 0, null, null, null, null, "Category2Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathPostCollectionViaCategory2Post
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = Category2Entity.Relations.Category2PostEntityUsingFkCategory2Id;
				intermediateRelation.SetAliases(string.Empty, "Category2Post_");
				relations.Add(Category2Entity.Relations.Category2PostEntityUsingFkCategory2Id, "Category2Entity__", "Category2Post_", JoinHint.None);
				relations.Add(Category2PostEntity.Relations.PostEntityUsingFkPostId, "Category2Post_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyPostEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.Category2Entity, (int)LLBLGenTest.LLBL.EntityType.PostEntity, 0, null, null, relations, null, "PostCollectionViaCategory2Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

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
					Category2Entity.Relations.Category1EntityUsingFkCategory1Id, 
					(int)LLBLGenTest.LLBL.EntityType.Category2Entity, (int)LLBLGenTest.LLBL.EntityType.Category1Entity, 0, null, null, null, null, "Category1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyCategory2PostEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyCategory2PostEntity))]
		public override EntityCollection<Category2PostEntity> Category2Post
		{
			get
			{
				EntityCollection<Category2PostEntity> toReturn = base.Category2Post;
				toReturn.EntityFactoryToUse = new MyCategory2PostEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyPostEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyPostEntity))]
		public override EntityCollection<PostEntity> PostCollectionViaCategory2Post
		{
			get
			{
				EntityCollection<PostEntity> toReturn = base.PostCollectionViaCategory2Post;
				toReturn.EntityFactoryToUse = new MyPostEntityFactory();
				return toReturn;
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

		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
	}
}
