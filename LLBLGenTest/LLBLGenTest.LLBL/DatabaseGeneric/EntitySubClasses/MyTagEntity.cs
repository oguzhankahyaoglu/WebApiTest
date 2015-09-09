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
	/// Entity class which represents the entity 'Tag'.
	/// </summary>
	[Serializable]
	public partial class MyTagEntity : TagEntity, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		/// <summary> CTor</summary>
		public MyTagEntity()
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public MyTagEntity(IEntityFields2 fields):base(fields)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TagEntity</param>
		public MyTagEntity(IValidator validator):base(validator)
		{
			InitClass();
		}
				

		/// <summary> CTor</summary>
		/// <param name="tagId">PK value for Tag which data should be fetched into this Tag object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyTagEntity(System.Int32 tagId):base(tagId)
		{
			InitClass();
		}

		/// <summary> CTor</summary>
		/// <param name="tagId">PK value for Tag which data should be fetched into this Tag object</param>
		/// <param name="validator">The custom validator object for this TagEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public MyTagEntity(System.Int32 tagId, IValidator validator):base(tagId, validator)
		{
			InitClass();
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MyTagEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			InitClass();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new MyTagEntityFactory();
		}
		
		/// <summary>Initialization routine for class</summary>
		private void InitClass()
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		#region Class Property Declarations

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PostTag' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathPostTag
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new MyPostTagEntityFactory()),
					TagEntity.Relations.PostTagEntityUsingFkTagId, 
					(int)LLBLGenTest.LLBL.EntityType.TagEntity, (int)LLBLGenTest.LLBL.EntityType.PostTagEntity, 0, null, null, null, null, "PostTag", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary>
		/// Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.
		/// </summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public new static IPrefetchPathElement2 PrefetchPathPostCollectionViaPostTag
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = TagEntity.Relations.PostTagEntityUsingFkTagId;
				intermediateRelation.SetAliases(string.Empty, "PostTag_");
				relations.Add(TagEntity.Relations.PostTagEntityUsingFkTagId, "TagEntity__", "PostTag_", JoinHint.None);
				relations.Add(PostTagEntity.Relations.PostEntityUsingFkPostId, "PostTag_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new MyPostEntityFactory()),
					intermediateRelation, (int)LLBLGenTest.LLBL.EntityType.TagEntity, (int)LLBLGenTest.LLBL.EntityType.PostEntity, 0, null, null, relations, null, "PostCollectionViaPostTag", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyPostTagEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyPostTagEntity))]
		public override EntityCollection<PostTagEntity> PostTag
		{
			get
			{
				EntityCollection<PostTagEntity> toReturn = base.PostTag;
				toReturn.EntityFactoryToUse = new MyPostTagEntityFactory();
				return toReturn;
			}
		}

		/// <summary>
		/// Gets the EntityCollection with the related entities of type 'MyPostEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.
		/// </summary>
		[TypeContainedAttribute(typeof(MyPostEntity))]
		public override EntityCollection<PostEntity> PostCollectionViaPostTag
		{
			get
			{
				EntityCollection<PostEntity> toReturn = base.PostCollectionViaPostTag;
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
