using System;
using System.Configuration;
using LLBLGenTest.LLBL;
using LLBLGenTest.LLBL.DatabaseSpecific;
using LLBLGenTest.LLBL.FactoryClasses;
using LLBLGenTest.LLBL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.Application
{
    public class DynamicDataSource<TEntity> where TEntity : EntityBase2
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["PLT"].ConnectionString;

        private IEntityFactory2 EntityFactoryToUse;
        private EntityType EntityTypeEnumValue;
        private String EntityTypeName;

        public DynamicDataSource()
        {
            EntityTypeName = typeof(TEntity).Name;
            EntityFactoryToUse = EntityFactoryFactory.GetFactory(typeof(TEntity));
            EntityTypeEnumValue = (EntityType)Enum.Parse(typeof(EntityType), EntityTypeName, true);
        }

        public EntityCollection GetEntities(Action<PrefetchPath2> pathsFunc, Action<PredicateExpression> filtersFunc)
        {
            var entities = new EntityCollection();
            entities.EntityFactoryToUse = EntityFactoryToUse;

            //Paths
            var prefetchPaths = new PrefetchPath2(EntityTypeEnumValue);
            pathsFunc.Invoke(prefetchPaths);

            //Filters
            var filters = new PredicateExpression();
            filtersFunc.Invoke(filters);
            var relationFilterBucket = new RelationPredicateBucket(filters);
            //PrepareRelations(p, relationFilterBucket.Relations);
            //PrepareRelationFilters(p, relationFilterBucket.PredicateExpression);
            using (var adapter = new DataAccessAdapter(ConnectionString))
            {
                adapter.FetchEntityCollection(entities, relationFilterBucket, 20, null, prefetchPaths, null, 1, 20);
            }
            return entities;
        }
    }

}
