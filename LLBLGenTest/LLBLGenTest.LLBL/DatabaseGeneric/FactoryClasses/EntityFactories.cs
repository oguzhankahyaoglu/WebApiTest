///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 10 Eylül 2015 Perşembe 16:20:16
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using LLBLGenTest.LLBL.EntityClasses;
using LLBLGenTest.LLBL.HelperClasses;
using LLBLGenTest.LLBL.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.LLBL.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2 : EntityFactoryCore2
	{
		private string _entityName;
		private LLBLGenTest.LLBL.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase2(string entityName, LLBLGenTest.LLBL.EntityType typeOfEntity)
		{
			_entityName = entityName;
			_typeOfEntity = typeOfEntity;
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public override IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}
		
		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((LLBLGenTest.LLBL.EntityType)entityTypeValue);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(_entityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			IEntityFactory2 toReturn = (IEntityFactory2)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(_entityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <param name="objectAlias">The object alias to use for the predicate(s).</param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);
		}
				
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public override string ForEntityName 
		{ 
			get { return _entityName; }
		}
	}
	
	/// <summary>Factory to create new, empty Category1Entity objects.</summary>
	[Serializable]
	public partial class Category1EntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public Category1EntityFactory() : base("Category1Entity", LLBLGenTest.LLBL.EntityType.Category1Entity) { }

		/// <summary>Creates a new, empty Category1Entity object.</summary>
		/// <returns>A new, empty Category1Entity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new Category1Entity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory1
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new Category1Entity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new Category1Entity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory1UsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<Category1Entity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty Category1PostEntity objects.</summary>
	[Serializable]
	public partial class Category1PostEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public Category1PostEntityFactory() : base("Category1PostEntity", LLBLGenTest.LLBL.EntityType.Category1PostEntity) { }

		/// <summary>Creates a new, empty Category1PostEntity object.</summary>
		/// <returns>A new, empty Category1PostEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new Category1PostEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory1Post
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new Category1PostEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new Category1PostEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory1PostUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<Category1PostEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty Category2Entity objects.</summary>
	[Serializable]
	public partial class Category2EntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public Category2EntityFactory() : base("Category2Entity", LLBLGenTest.LLBL.EntityType.Category2Entity) { }

		/// <summary>Creates a new, empty Category2Entity object.</summary>
		/// <returns>A new, empty Category2Entity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new Category2Entity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory2
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new Category2Entity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new Category2Entity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory2UsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<Category2Entity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty Category2PostEntity objects.</summary>
	[Serializable]
	public partial class Category2PostEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public Category2PostEntityFactory() : base("Category2PostEntity", LLBLGenTest.LLBL.EntityType.Category2PostEntity) { }

		/// <summary>Creates a new, empty Category2PostEntity object.</summary>
		/// <returns>A new, empty Category2PostEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new Category2PostEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory2Post
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new Category2PostEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new Category2PostEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory2PostUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<Category2PostEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty MainPageBannerEntity objects.</summary>
	[Serializable]
	public partial class MainPageBannerEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public MainPageBannerEntityFactory() : base("MainPageBannerEntity", LLBLGenTest.LLBL.EntityType.MainPageBannerEntity) { }

		/// <summary>Creates a new, empty MainPageBannerEntity object.</summary>
		/// <returns>A new, empty MainPageBannerEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new MainPageBannerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMainPageBanner
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MainPageBannerEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new MainPageBannerEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMainPageBannerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MainPageBannerEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty PostEntity objects.</summary>
	[Serializable]
	public partial class PostEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public PostEntityFactory() : base("PostEntity", LLBLGenTest.LLBL.EntityType.PostEntity) { }

		/// <summary>Creates a new, empty PostEntity object.</summary>
		/// <returns>A new, empty PostEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new PostEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPost
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new PostEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PostEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<PostEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty PostAttachmentEntity objects.</summary>
	[Serializable]
	public partial class PostAttachmentEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public PostAttachmentEntityFactory() : base("PostAttachmentEntity", LLBLGenTest.LLBL.EntityType.PostAttachmentEntity) { }

		/// <summary>Creates a new, empty PostAttachmentEntity object.</summary>
		/// <returns>A new, empty PostAttachmentEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new PostAttachmentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostAttachment
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new PostAttachmentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PostAttachmentEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostAttachmentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<PostAttachmentEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty PostTagEntity objects.</summary>
	[Serializable]
	public partial class PostTagEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public PostTagEntityFactory() : base("PostTagEntity", LLBLGenTest.LLBL.EntityType.PostTagEntity) { }

		/// <summary>Creates a new, empty PostTagEntity object.</summary>
		/// <returns>A new, empty PostTagEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new PostTagEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostTag
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new PostTagEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PostTagEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPostTagUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<PostTagEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty SysLanguageEntity objects.</summary>
	[Serializable]
	public partial class SysLanguageEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public SysLanguageEntityFactory() : base("SysLanguageEntity", LLBLGenTest.LLBL.EntityType.SysLanguageEntity) { }

		/// <summary>Creates a new, empty SysLanguageEntity object.</summary>
		/// <returns>A new, empty SysLanguageEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new SysLanguageEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysLanguage
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SysLanguageEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SysLanguageEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysLanguageUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<SysLanguageEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty SysLogEntity objects.</summary>
	[Serializable]
	public partial class SysLogEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public SysLogEntityFactory() : base("SysLogEntity", LLBLGenTest.LLBL.EntityType.SysLogEntity) { }

		/// <summary>Creates a new, empty SysLogEntity object.</summary>
		/// <returns>A new, empty SysLogEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new SysLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SysLogEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SysLogEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysLogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<SysLogEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty SysMltextEntity objects.</summary>
	[Serializable]
	public partial class SysMltextEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public SysMltextEntityFactory() : base("SysMltextEntity", LLBLGenTest.LLBL.EntityType.SysMltextEntity) { }

		/// <summary>Creates a new, empty SysMltextEntity object.</summary>
		/// <returns>A new, empty SysMltextEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new SysMltextEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysMltext
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SysMltextEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SysMltextEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysMltextUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<SysMltextEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty SysMltranslationEntity objects.</summary>
	[Serializable]
	public partial class SysMltranslationEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public SysMltranslationEntityFactory() : base("SysMltranslationEntity", LLBLGenTest.LLBL.EntityType.SysMltranslationEntity) { }

		/// <summary>Creates a new, empty SysMltranslationEntity object.</summary>
		/// <returns>A new, empty SysMltranslationEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new SysMltranslationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysMltranslation
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SysMltranslationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SysMltranslationEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysMltranslationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<SysMltranslationEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty SysSettingEntity objects.</summary>
	[Serializable]
	public partial class SysSettingEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public SysSettingEntityFactory() : base("SysSettingEntity", LLBLGenTest.LLBL.EntityType.SysSettingEntity) { }

		/// <summary>Creates a new, empty SysSettingEntity object.</summary>
		/// <returns>A new, empty SysSettingEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new SysSettingEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysSetting
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SysSettingEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SysSettingEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysSettingUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<SysSettingEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty SysTransactionEntity objects.</summary>
	[Serializable]
	public partial class SysTransactionEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public SysTransactionEntityFactory() : base("SysTransactionEntity", LLBLGenTest.LLBL.EntityType.SysTransactionEntity) { }

		/// <summary>Creates a new, empty SysTransactionEntity object.</summary>
		/// <returns>A new, empty SysTransactionEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new SysTransactionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysTransaction
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SysTransactionEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SysTransactionEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysTransactionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<SysTransactionEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty SysUserEntity objects.</summary>
	[Serializable]
	public partial class SysUserEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public SysUserEntityFactory() : base("SysUserEntity", LLBLGenTest.LLBL.EntityType.SysUserEntity) { }

		/// <summary>Creates a new, empty SysUserEntity object.</summary>
		/// <returns>A new, empty SysUserEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new SysUserEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysUser
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SysUserEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SysUserEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSysUserUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<SysUserEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty TagEntity objects.</summary>
	[Serializable]
	public partial class TagEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public TagEntityFactory() : base("TagEntity", LLBLGenTest.LLBL.EntityType.TagEntity) { }

		/// <summary>Creates a new, empty TagEntity object.</summary>
		/// <returns>A new, empty TagEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new TagEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTag
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new TagEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TagEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTagUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TagEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty TeamEntity objects.</summary>
	[Serializable]
	public partial class TeamEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public TeamEntityFactory() : base("TeamEntity", LLBLGenTest.LLBL.EntityType.TeamEntity) { }

		/// <summary>Creates a new, empty TeamEntity object.</summary>
		/// <returns>A new, empty TeamEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new TeamEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTeam
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new TeamEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TeamEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTeamUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TeamEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty TeamPostEntity objects.</summary>
	[Serializable]
	public partial class TeamPostEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public TeamPostEntityFactory() : base("TeamPostEntity", LLBLGenTest.LLBL.EntityType.TeamPostEntity) { }

		/// <summary>Creates a new, empty TeamPostEntity object.</summary>
		/// <returns>A new, empty TeamPostEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new TeamPostEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTeamPost
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new TeamPostEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TeamPostEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTeamPostUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TeamPostEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty TextContentEntity objects.</summary>
	[Serializable]
	public partial class TextContentEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public TextContentEntityFactory() : base("TextContentEntity", LLBLGenTest.LLBL.EntityType.TextContentEntity) { }

		/// <summary>Creates a new, empty TextContentEntity object.</summary>
		/// <returns>A new, empty TextContentEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new TextContentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTextContent
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new TextContentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TextContentEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTextContentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TextContentEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty VideoEntity objects.</summary>
	[Serializable]
	public partial class VideoEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public VideoEntityFactory() : base("VideoEntity", LLBLGenTest.LLBL.EntityType.VideoEntity) { }

		/// <summary>Creates a new, empty VideoEntity object.</summary>
		/// <returns>A new, empty VideoEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new VideoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVideo
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new VideoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new VideoEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVideoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<VideoEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty WeeklyProgrammeDayEntity objects.</summary>
	[Serializable]
	public partial class WeeklyProgrammeDayEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public WeeklyProgrammeDayEntityFactory() : base("WeeklyProgrammeDayEntity", LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity) { }

		/// <summary>Creates a new, empty WeeklyProgrammeDayEntity object.</summary>
		/// <returns>A new, empty WeeklyProgrammeDayEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new WeeklyProgrammeDayEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWeeklyProgrammeDay
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new WeeklyProgrammeDayEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new WeeklyProgrammeDayEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWeeklyProgrammeDayUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<WeeklyProgrammeDayEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty WeeklyProgrammeMatchEntity objects.</summary>
	[Serializable]
	public partial class WeeklyProgrammeMatchEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public WeeklyProgrammeMatchEntityFactory() : base("WeeklyProgrammeMatchEntity", LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity) { }

		/// <summary>Creates a new, empty WeeklyProgrammeMatchEntity object.</summary>
		/// <returns>A new, empty WeeklyProgrammeMatchEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new WeeklyProgrammeMatchEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWeeklyProgrammeMatch
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new WeeklyProgrammeMatchEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new WeeklyProgrammeMatchEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWeeklyProgrammeMatchUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<WeeklyProgrammeMatchEntity>(this);
		}
		

		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(LLBLGenTest.LLBL.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case LLBLGenTest.LLBL.EntityType.Category1Entity:
					factoryToUse = new Category1EntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.Category1PostEntity:
					factoryToUse = new Category1PostEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.Category2Entity:
					factoryToUse = new Category2EntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.Category2PostEntity:
					factoryToUse = new Category2PostEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.MainPageBannerEntity:
					factoryToUse = new MainPageBannerEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.PostEntity:
					factoryToUse = new PostEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.PostAttachmentEntity:
					factoryToUse = new PostAttachmentEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.PostTagEntity:
					factoryToUse = new PostTagEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysLanguageEntity:
					factoryToUse = new SysLanguageEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysLogEntity:
					factoryToUse = new SysLogEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysMltextEntity:
					factoryToUse = new SysMltextEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysMltranslationEntity:
					factoryToUse = new SysMltranslationEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysSettingEntity:
					factoryToUse = new SysSettingEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysTransactionEntity:
					factoryToUse = new SysTransactionEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.SysUserEntity:
					factoryToUse = new SysUserEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.TagEntity:
					factoryToUse = new TagEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.TeamEntity:
					factoryToUse = new TeamEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.TeamPostEntity:
					factoryToUse = new TeamPostEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.TextContentEntity:
					factoryToUse = new TextContentEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.VideoEntity:
					factoryToUse = new VideoEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.WeeklyProgrammeDayEntity:
					factoryToUse = new WeeklyProgrammeDayEntityFactory();
					break;
				case LLBLGenTest.LLBL.EntityType.WeeklyProgrammeMatchEntity:
					factoryToUse = new WeeklyProgrammeMatchEntityFactory();
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
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the LLBLGenTest.LLBL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(LLBLGenTest.LLBL.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(LLBLGenTest.LLBL.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.Create((LLBLGenTest.LLBL.EntityType)entityTypeValue);
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
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif		
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the LLBLGenTest.LLBL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue)
		{
			return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue);
		}
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (LLBLGenTest.LLBL.EntityType)Enum.Parse(typeof(LLBLGenTest.LLBL.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((LLBLGenTest.LLBL.EntityType)Enum.Parse(typeof(LLBLGenTest.LLBL.EntityType), leftOperandEntityName, false), joinType, (LLBLGenTest.LLBL.EntityType)Enum.Parse(typeof(LLBLGenTest.LLBL.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the LLBLGenTest.LLBL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((LLBLGenTest.LLBL.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
