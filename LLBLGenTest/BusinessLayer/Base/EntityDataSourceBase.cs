using System;
using System.Collections;
using System.Configuration;
using System.Linq;
using LLBLGenTest.Application.Base.Exceptions;
using LLBLGenTest.LLBL;
using LLBLGenTest.LLBL.DatabaseSpecific;
using LLBLGenTest.LLBL.FactoryClasses;
using LLBLGenTest.LLBL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.Application.Base
{
    public class EntityDataSourceBase<TEntity, TParameter> : IDisposable
        where TEntity : EntityBase2
        where TParameter : EntityDataSourceParameterBase
    {
        protected static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["PLT"].ConnectionString;
        protected static readonly object LOCKER = new object();

        protected DataAccessAdapter Adapter;
        protected IEntityFactory2 EntityFactoryToUse;
        protected EntityType EntityTypeEnumValue;
        protected String EntityTypeName;


        #region Constructors &  Destructor

        public EntityDataSourceBase()
        {
            EntityTypeName = typeof(TEntity).Name;
            EntityFactoryToUse = EntityFactoryFactory.GetFactory(typeof(TEntity));
            EntityTypeEnumValue = (EntityType)Enum.Parse(typeof(EntityType), EntityTypeName, true);
            Adapter = new DataAccessAdapter(ConnectionString);
        }

        public void Dispose()
        {
            Adapter.Dispose();
        }

        #endregion

        #region Get, Update & Delete Entity Methods

        public virtual TEntity GetEntity(int entityId)
        {
            throw new GetEntityMethodException(GetType());
        }

        public TEntity GetEntity(TParameter p)
        {
            return GetEntity(p, false);
        }

        public TEntity GetEntity(TParameter p, bool hideExceptions)
        {
            var entities = GetEntities(p);
            if (hideExceptions == false)
            {
                if (entities.Count == 0)
                    throw new EntityNotFoundException(typeof(TEntity), p);

                if (entities.Count > 1)
                    throw new MultipleEntitiesFoundException(typeof(TEntity), p);
            }
            return entities.FirstOrDefault();
        }

        public bool DeleteEntity(TEntity entity)
        {
            return Adapter.DeleteEntity(entity);
        }

        public bool SaveEntity(TEntity entity)
        {
            return Adapter.SaveEntity(entity, true);
        }

        public int SaveEntity(IEntityCollection2 entities)
        {
            return Adapter.SaveEntityCollection(entities);
        }

        /// <summary>
        /// Fetches all entities, without filtering, sorting or anyting else...
        /// </summary>
        /// <returns></returns>
        public EntityCollectionBase2<TEntity> GetEntities()
        {
            var collection = GetEmptyEntityCollection();
            Adapter.FetchEntityCollection(collection, null);
            return collection;
        }

        public EntityCollectionBase2<TEntity> GetEntities(TParameter p)
        {
            var collection = GetEmptyEntityCollection();
            if (p == null)
                throw new ArgumentNullException("p", "Parameter null olamaz.");

            //Filter
            var filters = new PredicateExpression();
            if (p.FiltersFunc != null)
                p.FiltersFunc.Invoke(filters);
            var relationFilterBucket = new RelationPredicateBucket(filters);
            PrepareRelations(p, relationFilterBucket.Relations);
            PrepareRelationFilters(p, relationFilterBucket.PredicateExpression);

            //Search
            //PrepareSearchExpression(p, ref relationFilterBucket);

            //Sort
            ISortExpression sort = new SortExpression();
            PrepareSortExpression(p, ref sort);

            //SubPaths:
            var path = new PrefetchPath2(EntityTypeEnumValue);
            if (p.PathsFunc != null)
                p.PathsFunc.Invoke(path);
            //PrepareSubPaths(p, ref path);

            //Aggregate
            if (p.CalculateAggregate)
                p.Aggregate = Adapter.GetDbCount(collection, relationFilterBucket);

            Adapter.FetchEntityCollection(collection, relationFilterBucket, p.ItemsToReturn, sort, path, null, p.PageNumber, p.PageSize);
            return collection;
        }

        #endregion

        /// <summary>
        /// İlgili manager'ın entity'lerine ulaşmak için gereken path'i, parametre kullanarak oluşturmalı.
        /// </summary>
        /// <param name="p">Parametre</param>
        /// <param name="path">PathElement, rootPath değil. Bu metod başka manager'dan çağırıldığından, rootPath başka manager'da olacaktır. Bu metod pathElement üretir.</param>
        /// <returns></returns>
        public IPrefetchPathElement2 GetPathElement(TParameter p, IPrefetchPathElement2 path)
        {
            IPredicateExpression filterPredicateExpression = new PredicateExpression();

            //Filtering 
            PrepareFilter(p, ref filterPredicateExpression);
            path.Filter = filterPredicateExpression;

            //Relations
            //PrepareRelations(p, path.FilterRelations);

            //Sort
            ISortExpression sortExpression = new SortExpression();
            PrepareSortExpression(p, ref sortExpression);
            path.Sorter = sortExpression;

            //SubPaths
            var subPath = new PrefetchPath2(EntityTypeEnumValue);
            if (p.PathsFunc != null)
                p.PathsFunc.Invoke(subPath);
            //PrepareSubPaths(p, ref subPath);
            path.SubPath = subPath;

            return path;
        }

        public EntityCollection<TEntity> GetEmptyEntityCollection()
        {
            var result = new EntityCollection<TEntity>();
            return result;
        }

        #region Virtual Methods

        /// <summary>
        /// Filtreyi oluşturmalı.
        /// </summary>
        /// <param name="p">Parametre</param>
        /// <param name="filterPredicateExpression">Filtre</param>
        protected virtual void PrepareFilter(TParameter p, ref IPredicateExpression filterPredicateExpression) { }

        /// <summary>
        /// İlişkileri ve filtreli ilişkileri oluşturı
        /// </summary>
        /// <param name="p"></param>
        /// <param name="relations"></param>
        protected virtual void PrepareRelations(TParameter p, IRelationCollection relations) { }

        /// <summary>
        /// SortExpression'u oluşturmalı.
        /// </summary>
        /// <param name="p">Parametre</param>
        /// <param name="sortExpression">Oluşacak olarna sortExpression</param>
        protected virtual void PrepareSortExpression(TParameter p, ref ISortExpression sortExpression) { }

        /// <summary>
        /// (Oğuzhan) MegaReduktorCms'de Ürün Grubu-> Alt ürün Grubu-> Ürün -> Marka hiyerarşisinde, relation'lara verilen filtreler çalışmıyordu.
        /// Relation filtrelemesi bu metod aracılığı ile yapılmalı eğer yapılacaksa!
        /// </summary>
        /// <param name="p"></param>
        /// <param name="predicateExpression"></param>
        protected virtual void PrepareRelationFilters(TParameter p, IPredicateExpression predicateExpression) { }

        #endregion

        #region Helpers

        #region Filtering Helpers

        /// <summary>
        /// Nullable field'lar için (ID, IsActive gibi) FilterPredicate üreterek filterPredicateExpression'a ekler.
        /// </summary>
        /// <param name="filterPredicateExpression">Filtre</param>
        /// <param name="field">EntityField</param>
        /// <param name="nullableParameter">Nullable Parametre (ID değeri gibi)</param>
        protected void AddNullableFieldEqualsToFilter(ref IPredicateExpression filterPredicateExpression, EntityField2 field, object nullableParameter)
        {
            AddNullableFieldFilter(ref filterPredicateExpression, field == nullableParameter, nullableParameter);
        }

        /// <summary>
        /// Nullable field'lar için (ID, IsActive gibi) FilterPredicate üreterek filterPredicateExpression'a ekler.
        /// </summary>
        /// <param name="filterPredicateExpression">Filtre</param>
        /// <param name="field">EntityField</param>
        /// <param name="nullableList"></param>
        protected void AddNullableFieldEqualsToFilter(ref IPredicateExpression filterPredicateExpression, EntityField2 field, IList nullableList)
        {
            if (nullableList != null && nullableList.Count > 0)
                AddNullableFieldFilter(ref filterPredicateExpression, field == nullableList, nullableList);
        }

        /// <summary>
        /// Verilen koşulu (predicate) filtreye ekler. NullableParameter'ın null olması durumunda filtreye eklenmez.
        /// </summary>
        /// <param name="filterPredicateExpression"></param>
        /// <param name="fieldPredicateExpression"></param>
        /// <param name="nullableParameter"></param>
        public void AddNullableFieldFilter(ref IPredicateExpression filterPredicateExpression, Predicate fieldPredicateExpression, object nullableParameter)
        {
            if (nullableParameter != null)
                filterPredicateExpression.Add(fieldPredicateExpression);
        }

        #endregion

        #endregion
    }

}
