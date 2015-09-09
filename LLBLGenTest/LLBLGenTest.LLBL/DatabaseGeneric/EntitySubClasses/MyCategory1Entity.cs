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
	/// Entity class which represents the entity 'Category1'.
	/// </summary>
	[Serializable]
	public partial class MyCategory1Entity : Category1Entity, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		/// <summary> CTor</summary>
		public MyCategory1Entity()
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MyCategory1Entity(IEntityFields2 fields):base(fields)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this Category1Entity</param>
		public MyCategory1Entity(IValidator validator):base(validator)
		{
			InitClass();
		}
				

		/// <summary> CTor</summary>
		/// <param name="category1Id">PK value for Category1 which data should be fetched into this Category1 object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyCategory1Entity(System.Int32 category1Id):base(category1Id)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="category1Id">PK value for Category1 which data should be fetched into this Category1 object</param>
		/// <param name="validator">The custom validator object for this Category1Entity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyCategory1Entity(System.Int32 category1Id, IValidator validator):base(category1Id, validator)
		{
			InitClass();
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MyCategory1Entity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			InitClass();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new MyCategory1EntityFactory();
		}
		
		/// <summary>Initialization routine for class</summary>
		private void InitClass()
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		#region Class Property Declarations

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category1Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathCategory1Post
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyCategory1PostEntityFactory()),
					Category1Entity.Relations.Category1PostEntityUsingFkCategory1Id, 
					(int)LLBLGenTest.LLBL.EntityType.Category1Entity, (int)LLBLGenTest.LLBL.EntityType.Category1PostEntity, 0, null, null, null, null, "Category1Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category2' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathCategory2
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyCategory2EntityFactory()),
					Category1Entity.Relations.Category2EntityUsingFkCategory1Id, 
					(int)LLBLGenTest.LLBL.EntityType.Category1Entity, (int)LLBLGenTest.LLBL.EntityType.Category2Entity, 0, null, null, null, null, "Category2", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'MainPageBanner' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathMainPageBanner
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyMainPageBannerEntityFactory()),
					Category1Entity.Relations.MainPageBannerEntityUsingFkCategory1Id, 
					(int)LLBLGenTest.LLBL.EntityType.Category1Entity, (int)LLBLGenTest.LLBL.EntityType.MainPageBannerEntity, 0, null, null, null, null, "MainPageBanner", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathPostCollectionViaCategory1Post
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = Category1Entity.Relations.Category1PostEntityUsingFkCategory1Id;
				intermediateRelation.SetAliases(string.Empty, "Category1Post_");
				relations.Add(Category1Entity.Relations.Category1PostEntityUsingFkCategory1Id, "Category1Entity__", "Category1Post_", JoinHint.None);
				relations.Add(Category1PostEntity.Relations.PostEntityUsingFkPostId, "Category1Post_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyPostEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.Category1Entity, (int)LLBLGenTest.LLBL.EntityType.PostEntity, 0, null, null, relations, null, "PostCollectionViaCategory1Post", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyCategory1PostEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyCategory1PostEntity))]
		public override EntityCollection<Category1PostEntity> Category1Post
		{
			get
			{
				EntityCollection<Category1PostEntity> toReturn = base.Category1Post;
				toReturn.EntityFactoryToUse = new MyCategory1PostEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyCategory2Entity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyCategory2Entity))]
		public override EntityCollection<Category2Entity> Category2
		{
			get
			{
				EntityCollection<Category2Entity> toReturn = base.Category2;
				toReturn.EntityFactoryToUse = new MyCategory2EntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyMainPageBannerEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyMainPageBannerEntity))]
		public override EntityCollection<MainPageBannerEntity> MainPageBanner
		{
			get
			{
				EntityCollection<MainPageBannerEntity> toReturn = base.MainPageBanner;
				toReturn.EntityFactoryToUse = new MyMainPageBannerEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyPostEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyPostEntity))]
		public override EntityCollection<PostEntity> PostCollectionViaCategory1Post
		{
			get
			{
				EntityCollection<PostEntity> toReturn = base.PostCollectionViaCategory1Post;
				toReturn.EntityFactoryToUse = new MyPostEntityFactory();
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
