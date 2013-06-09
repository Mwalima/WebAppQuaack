using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppQuaack
{
    public partial class Follower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ctx = new QuaackEntities();
            var result = (from f in ctx.follower select f).ToList();
            gv_follower.DataSource = result;
            gv_follower.DataBind();

        }
    }
}