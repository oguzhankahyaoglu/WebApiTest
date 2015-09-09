using System;
using LLBLGenTest.Application;
using LLBLGenTest.Application.Base;
using LLBLGenTest.LLBL.EntityClasses;
using LLBLGenTest.LLBL.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.UI.Dynamic
{
    public partial class Default : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var authorid = Convert.ToInt32(Request.QueryString["authorid"]);
            var fkAuthorId = (EntityField2)EntityFieldFactory.Create("PostEntity", "FkAuthorId");
            var parameter = new EntityDataSourceParameterBase
                            {
                                PathsFunc = path2 => path2.Add(PostEntity.PrefetchPathCategory1CollectionViaCategory1Post),
                                FiltersFunc = filters => filters.Add(fkAuthorId == authorid)
                            };
            using (var ds = new EntityDataSourceBase<PostEntity, EntityDataSourceParameterBase>())
            {
                var entities = ds.GetEntities(parameter);
                rpt.DataSource = entities;
            }
            rpt.DataBind();
        }
    }
}