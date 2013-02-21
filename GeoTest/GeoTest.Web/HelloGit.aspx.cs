using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GeoTest.DataAccess;

namespace GeoTest.Web
{
    public partial class HelloGit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptMessages.DataSource = QueryManager.GetAllMessages();
            rptMessages.DataBind();
        }

        protected override void OnInit(EventArgs e)
        {
            rptMessages.ItemDataBound += rptMessages_ItemDataBound;
            base.OnInit(e);
        }

        void rptMessages_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var dataItem = (GitMessage) e.Item.DataItem;
            var litMessage = (Literal)e.Item.FindControl("litMessage");
            if (litMessage != null)
                litMessage.Text = dataItem.Message;
        }
    }
}