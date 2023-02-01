using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductWebApplication.CustomControls
{
    public partial class Server : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txttime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}