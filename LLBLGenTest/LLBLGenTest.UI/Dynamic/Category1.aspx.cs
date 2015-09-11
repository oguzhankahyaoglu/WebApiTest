using System;
using BusinessLayer;
using LLBLGenTest.Application;
using LLBLGenTest.Application.Base;
using LLBLGenTest.LLBL.EntityClasses;

namespace LLBLGenTest.UI.Dynamic
{
    public partial class Category1 : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var parameter = new EntityDataSourceParameterBase
                            {
                                ItemsToReturn = 0,
                                PathsFunc = paths =>
                                            {
                                                var c2 = Category1Entity.PrefetchPathCategory2.WithMaxNumberOfItems(2);
                                                c2.SubPath.Add(Category2Entity.PrefetchPathPostCollectionViaCategory2Post.WithMaxNumberOfItems(20));
                                                paths.Add(c2);
                                            },
                                //FiltersFunc = filters => filters.Add(fkAuthorId == authorid)
                            };
            
            using (var ds = new EntityDataSourceBase<Category1Entity, EntityDataSourceParameterBase>())
            {
                var entities = ds.GetEntities(parameter);
                rpt.DataSource = entities;
            }
            rpt.DataBind();
        }
    }
}