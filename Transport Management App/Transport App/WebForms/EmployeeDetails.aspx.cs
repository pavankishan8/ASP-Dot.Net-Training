using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.UI;
using System.Web.UI.WebControls;
using TransportApp.Data_Component;

namespace TransportApp.WebForms
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var repo = new RouteData();
                var allemp = repo.getallemp();
                grdtable.DataSource = allemp;
                grdtable.DataBind();
            }
        }
    }
}