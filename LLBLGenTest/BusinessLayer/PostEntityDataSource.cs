using LLBLGenTest.Application.Base;
using LLBLGenTest.LLBL.EntityClasses;
using LLBLGenTest.LLBL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.Application
{
    public class PostEntityParameter : EntityDataSourceParameterBase
    {
        public int? AuthorID { get; set; }
        public Category1EntityParameter Category1EntityParameter { get; set; }
    }

    public class PostEntityDataSource : EntityDataSourceBase<PostEntity, PostEntityParameter>
    {
        //protected override void PrepareSubPaths(PostEntityParameter p, ref PrefetchPath2 rootPath)
        //{
        //    if (p.Category1EntityParameter != null)
        //        rootPath.Add(new Category1EntityDataSource().GetPathElement(p.Category1EntityParameter, PostEntity.PrefetchPathCategory1CollectionViaCategory1Post));
        //}

        protected override void PrepareFilter(PostEntityParameter p, ref IPredicateExpression filterPredicateExpression)
        {
            AddNullableFieldEqualsToFilter(ref filterPredicateExpression, PostFields.FkAuthorId, p.AuthorID);
        }
    }
}
