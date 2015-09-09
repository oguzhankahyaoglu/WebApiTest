using LLBLGenTest.Application.Base;
using LLBLGenTest.LLBL.EntityClasses;
using LLBLGenTest.LLBL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.Application
{
    public class Category1EntityParameter : EntityDataSourceParameterBase
    {
        public int? AuthorID;
    }

    public class Category1EntityDataSource : EntityDataSourceBase<Category1Entity, Category1EntityParameter>
    {
        protected override void PrepareFilter(Category1EntityParameter p, ref IPredicateExpression filterPredicateExpression)
        {
            AddNullableFieldEqualsToFilter(ref filterPredicateExpression, PostFields.FkAuthorId, p.AuthorID);
        }
    }
}
