using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppQuaack
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ctx = new QuaackEntities();
            var result = (from l in ctx.profile select l).ToList();
            gv_profile.DataSource = result;
            gv_profile.DataBind();
        }
    }
}