using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LLBLGenTest.Application;
using LLBLGenTest.LLBL.EntityClasses;

namespace LLBLGenTest.UI.Dynamic
{
    public partial class Relations : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var entity = new PostEntity();
            var fieldsType = typeof(PostEntity.MemberNames);
            var relationFields = fieldsType.GetFields();
            var manyToManyFields = relationFields.Where(f => f.Name.Contains("CollectionVia"));
            var oneToManyFields = relationFields.Except(manyToManyFields);

            {
                var fields = PostEntity.FieldsCustomProperties;
                rptFields.DataSource = fields;
                rptFields.DataBind();
            }
            {
                var relations = PostEntity.Relations.GetAllRelations();
                rptRelations.DataSource = relations;
                rptRelations.DataBind();
            }
            {
                var customProperties = PostEntity.CustomProperties;
                rptCustomProperties.DataSource = customProperties;
                rptCustomProperties.DataBind();
            }
            {
                rptOneToManyRelationFields.DataSource = oneToManyFields;
                rptOneToManyRelationFields.DataBind();
            }
            {
                rptManyToManyRelationFields.DataSource = manyToManyFields;
                rptManyToManyRelationFields.DataBind();
            }
        }
    }
}