using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductWebApplication
{
    public partial class Mainsheet : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.User.Identity.IsAuthenticated)
            {
                lblUserInfo.Text = "Welcome " + Page.User.Identity.Name;
            }
            else {
                lblUserInfo.Text = "Welcome Anonymous User";
            }

            lblYear.Text = DateTime.Now.Year.ToString();
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
        }
    }
}