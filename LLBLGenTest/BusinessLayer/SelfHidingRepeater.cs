using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace LLBLGenTest.Application
{
    [ToolboxData("<{0}:SelfHidingRepeater ID='Tag1' runat=\"server\"></{0}:SelfHidingRepeater>")]
    public class SelfHidingRepeater : System.Web.UI.WebControls.Repeater
    {
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public ITemplate EmptyTemplate { get; set; }

        public new bool? EnableViewState;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            base.EnableViewState = EnableViewState == true;
        }

        protected override void OnPreRender(EventArgs e)
        {
            Visible = EmptyTemplate != null || (Visible && Items.Count > 0);
            base.OnPreRender(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            var stringWriter = new StringWriter();
            var htmlWriter = new HtmlTextWriter(stringWriter);
            base.Render(htmlWriter);
            writer.Write(stringWriter.ToString());
        }

        /// <summary>
        /// Raises the DataBinding event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> object that contains the event data.</param>
        protected override void OnDataBinding(EventArgs e)
        {
            var datasource = DataSource as IList;
            if ((datasource == null || datasource.Count == 0) && EmptyTemplate != null)
            {
                //HeaderTemplate ve FooterTemplate'i derleyip Control ekliyor repeater databinding sırasında base'de,
                //Oraya müdahale edemileyeceği için, HeaderTemplate'e emptytemplate veriliyor, emptytemplate'i kendisi derliyor dolayısıyla.
                HeaderTemplate = EmptyTemplate;
                FooterTemplate = null;
                base.OnDataBinding(e);
            }
            else
                base.OnDataBinding(e);
        }
    }

}
