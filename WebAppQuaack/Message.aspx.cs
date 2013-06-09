using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppQuaack
{
    public partial class Message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ctx = new QuaackEntities();
            var result = (from l in ctx.message select l).ToList();
            gv_message.DataSource = result;
            gv_message.DataBind();
        }
    }
}