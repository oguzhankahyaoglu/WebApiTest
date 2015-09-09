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
using System.Collections.Generic;
using LLBLGenTest.LLBL.EntityClasses;
using LLBLGenTest.LLBL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.LLBL.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	
	/// <summary>Factory to create new, empty MyCategory1Entity objects.</summary>
	[Serializable]
	public partial class MyCategory1EntityFactory : Category1EntityFactory
	{
		/// <summary>CTor</summary>
		public MyCategory1EntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyCategory1Entity object.</summary>
		/// <returns>A new, empty MyCategory1Entity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyCategory1Entity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory1
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyCategory1Entity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyCategory1Entity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory1UsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyCategory1Entity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyCategory1PostEntity objects.</summary>
	[Serializable]
	public partial class MyCategory1PostEntityFactory : Category1PostEntityFactory
	{
		/// <summary>CTor</summary>
		public MyCategory1PostEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyCategory1PostEntity object.</summary>
		/// <returns>A new, empty MyCategory1PostEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyCategory1PostEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory1Post
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyCategory1PostEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyCategory1PostEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory1PostUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyCategory1PostEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyCategory2Entity objects.</summary>
	[Serializable]
	public partial class MyCategory2EntityFactory : Category2EntityFactory
	{
		/// <summary>CTor</summary>
		public MyCategory2EntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyCategory2Entity object.</summary>
		/// <returns>A new, empty MyCategory2Entity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyCategory2Entity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory2
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyCategory2Entity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyCategory2Entity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory2UsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyCategory2Entity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyCategory2PostEntity objects.</summary>
	[Serializable]
	public partial class MyCategory2PostEntityFactory : Category2PostEntityFactory
	{
		/// <summary>CTor</summary>
		public MyCategory2PostEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyCategory2PostEntity object.</summary>
		/// <returns>A new, empty MyCategory2PostEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyCategory2PostEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory2Post
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyCategory2PostEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyCategory2PostEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory2PostUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyCategory2PostEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyMainPageBannerEntity objects.</summary>
	[Serializable]
	public partial class MyMainPageBannerEntityFactory : MainPageBannerEntityFactory
	{
		/// <summary>CTor</summary>
		public MyMainPageBannerEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyMainPageBannerEntity object.</summary>
		/// <returns>A new, empty MyMainPageBannerEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyMainPageBannerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMainPageBanner
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyMainPageBannerEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyMainPageBannerEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMainPageBannerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyMainPageBannerEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyPostEntity objects.</summary>
	[Serializable]
	public partial class MyPostEntityFactory : PostEntityFactory
	{
		/// <summary>CTor</summary>
		public MyPostEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyPostEntity object.</summary>
		/// <returns>A new, empty MyPostEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyPostEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPost
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyPostEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyPostEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyPostEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyPostAttachmentEntity objects.</summary>
	[Serializable]
	public partial class MyPostAttachmentEntityFactory : PostAttachmentEntityFactory
	{
		/// <summary>CTor</summary>
		public MyPostAttachmentEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyPostAttachmentEntity object.</summary>
		/// <returns>A new, empty MyPostAttachmentEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyPostAttachmentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostAttachment
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyPostAttachmentEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyPostAttachmentEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostAttachmentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyPostAttachmentEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyPostTagEntity objects.</summary>
	[Serializable]
	public partial class MyPostTagEntityFactory : PostTagEntityFactory
	{
		/// <summary>CTor</summary>
		public MyPostTagEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyPostTagEntity object.</summary>
		/// <returns>A new, empty MyPostTagEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyPostTagEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostTag
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyPostTagEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyPostTagEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostTagUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyPostTagEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MySysLanguageEntity objects.</summary>
	[Serializable]
	public partial class MySysLanguageEntityFactory : SysLanguageEntityFactory
	{
		/// <summary>CTor</summary>
		public MySysLanguageEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MySysLanguageEntity object.</summary>
		/// <returns>A new, empty MySysLanguageEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MySysLanguageEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysLanguage
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MySysLanguageEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MySysLanguageEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysLanguageUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MySysLanguageEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MySysLogEntity objects.</summary>
	[Serializable]
	public partial class MySysLogEntityFactory : SysLogEntityFactory
	{
		/// <summary>CTor</summary>
		public MySysLogEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MySysLogEntity object.</summary>
		/// <returns>A new, empty MySysLogEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MySysLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MySysLogEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MySysLogEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysLogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MySysLogEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MySysMltextEntity objects.</summary>
	[Serializable]
	public partial class MySysMltextEntityFactory : SysMltextEntityFactory
	{
		/// <summary>CTor</summary>
		public MySysMltextEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MySysMltextEntity object.</summary>
		/// <returns>A new, empty MySysMltextEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MySysMltextEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysMltext
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MySysMltextEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MySysMltextEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysMltextUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MySysMltextEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MySysMltranslationEntity objects.</summary>
	[Serializable]
	public partial class MySysMltranslationEntityFactory : SysMltranslationEntityFactory
	{
		/// <summary>CTor</summary>
		public MySysMltranslationEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MySysMltranslationEntity object.</summary>
		/// <returns>A new, empty MySysMltranslationEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MySysMltranslationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysMltranslation
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MySysMltranslationEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MySysMltranslationEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysMltranslationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MySysMltranslationEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MySysSettingEntity objects.</summary>
	[Serializable]
	public partial class MySysSettingEntityFactory : SysSettingEntityFactory
	{
		/// <summary>CTor</summary>
		public MySysSettingEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MySysSettingEntity object.</summary>
		/// <returns>A new, empty MySysSettingEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MySysSettingEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysSetting
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MySysSettingEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MySysSettingEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysSettingUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MySysSettingEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MySysTransactionEntity objects.</summary>
	[Serializable]
	public partial class MySysTransactionEntityFactory : SysTransactionEntityFactory
	{
		/// <summary>CTor</summary>
		public MySysTransactionEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MySysTransactionEntity object.</summary>
		/// <returns>A new, empty MySysTransactionEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MySysTransactionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysTransaction
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MySysTransactionEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MySysTransactionEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysTransactionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MySysTransactionEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MySysUserEntity objects.</summary>
	[Serializable]
	public partial class MySysUserEntityFactory : SysUserEntityFactory
	{
		/// <summary>CTor</summary>
		public MySysUserEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MySysUserEntity object.</summary>
		/// <returns>A new, empty MySysUserEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MySysUserEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysUser
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MySysUserEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MySysUserEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysUserUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MySysUserEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyTagEntity objects.</summary>
	[Serializable]
	public partial class MyTagEntityFactory : TagEntityFactory
	{
		/// <summary>CTor</summary>
		public MyTagEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyTagEntity object.</summary>
		/// <returns>A new, empty MyTagEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyTagEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTag
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyTagEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyTagEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTagUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyTagEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyTeamEntity objects.</summary>
	[Serializable]
	public partial class MyTeamEntityFactory : TeamEntityFactory
	{
		/// <summary>CTor</summary>
		public MyTeamEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyTeamEntity object.</summary>
		/// <returns>A new, empty MyTeamEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyTeamEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTeam
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyTeamEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyTeamEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTeamUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyTeamEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyTeamPostEntity objects.</summary>
	[Serializable]
	public partial class MyTeamPostEntityFactory : TeamPostEntityFactory
	{
		/// <summary>CTor</summary>
		public MyTeamPostEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyTeamPostEntity object.</summary>
		/// <returns>A new, empty MyTeamPostEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyTeamPostEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTeamPost
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyTeamPostEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyTeamPostEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTeamPostUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyTeamPostEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyTextContentEntity objects.</summary>
	[Serializable]
	public partial class MyTextContentEntityFactory : TextContentEntityFactory
	{
		/// <summary>CTor</summary>
		public MyTextContentEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyTextContentEntity object.</summary>
		/// <returns>A new, empty MyTextContentEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyTextContentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTextContent
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyTextContentEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyTextContentEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTextContentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyTextContentEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyVideoEntity objects.</summary>
	[Serializable]
	public partial class MyVideoEntityFactory : VideoEntityFactory
	{
		/// <summary>CTor</summary>
		public MyVideoEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyVideoEntity object.</summary>
		/// <returns>A new, empty MyVideoEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyVideoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVideo
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyVideoEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyVideoEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVideoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyVideoEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyWeeklyProgrammeDayEntity objects.</summary>
	[Serializable]
	public partial class MyWeeklyProgrammeDayEntityFactory : WeeklyProgrammeDayEntityFactory
	{
		/// <summary>CTor</summary>
		public MyWeeklyProgrammeDayEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyWeeklyProgrammeDayEntity object.</summary>
		/// <returns>A new, empty MyWeeklyProgrammeDayEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyWeeklyProgrammeDayEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWeeklyProgrammeDay
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyWeeklyProgrammeDayEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyWeeklyProgrammeDayEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWeeklyProgrammeDayUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyWeeklyProgrammeDayEntity>(this);
		}
	}	
	/// <summary>Factory to create new, empty MyWeeklyProgrammeMatchEntity objects.</summary>
	[Serializable]
	public partial class MyWeeklyProgrammeMatchEntityFactory : WeeklyProgrammeMatchEntityFactory
	{
		/// <summary>CTor</summary>
		public MyWeeklyProgrammeMatchEntityFactory()
		{
		}

		/// <summary>Creates a new, empty MyWeeklyProgrammeMatchEntity object.</summary>
		/// <returns>A new, empty MyWeeklyProgrammeMatchEntity object.</returns>
		public override IEntity2 Create()
		{
			IEntity2 toReturn = new MyWeeklyProgrammeMatchEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWeeklyProgrammeMatch
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MyWeeklyProgrammeMatchEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new MyWeeklyProgrammeMatchEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWeeklyProgrammeMatchUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
				
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MyWeeklyProgrammeMatchEntity>(this);
		}
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 CreateMy(LLBLGenTest.LLBL.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case LLBLGenTest.LLBL.EntityType.Category1Entity:
					factoryToUse = new MyCategory1EntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.Category1PostEntity:
					factoryToUse = new MyCategory1PostEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.Category2Entity:
					factoryToUse = new MyCategory2EntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.Category2PostEntity:
					factoryToUse = new MyCategory2PostEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.MainPageBannerEntity:
					factoryToUse = new MyMainPageBannerEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.PostEntity:
					factoryToUse = new MyPostEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.PostAttachmentEntity:
					factoryToUse = new MyPostAttachmentEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.PostTagEntity:
					factoryToUse = new MyPostTagEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysLanguageEntity:
					factoryToUse = new MySysLanguageEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysLogEntity:
					factoryToUse = new MySysLogEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysMltextEntity:
					factoryToUse = new MySysMltextEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysMltranslationEntity:
					factoryToUse = new MySysMltranslationEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysSettingEntity:
					factoryToUse = new MySysSettingEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysTransactionEntity:
					factoryToUse = new MySysTransactionEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysUserEntity:
					factoryToUse = new MySysUserEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.TagEntity:
					factoryToUse = new MyTagEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.TeamEntity:
					factoryToUse = new MyTeamEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.TeamPostEntity:
					factoryToUse = new MyTeamPostEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.TextContentEntity:
					factoryToUse = new MyTextContentEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.VideoEntity:
					factoryToUse = new MyVideoEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity:
					factoryToUse = new MyWeeklyProgrammeDayEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity:
					factoryToUse = new MyWeeklyProgrammeMatchEntityFactory();
					break;
			}
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}
	}
	
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class MyEntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the LLBLGenTest.LLBL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(LLBLGenTest.LLBL.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.CreateMy(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static MyEntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(LLBLGenTest.LLBL.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.CreateMy((LLBLGenTest.LLBL.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			IEntityFactory2 toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the LLBLGenTest.LLBL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(LLBLGenTest.LLBL.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.CreateMy(typeOfEntity).GetType());
		}
#endif		
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class MyElementCreator : ElementCreator
	{
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the LLBLGenTest.LLBL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return MyEntityFactoryFactory.GetFactory((LLBLGenTest.LLBL.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return MyEntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}

}
