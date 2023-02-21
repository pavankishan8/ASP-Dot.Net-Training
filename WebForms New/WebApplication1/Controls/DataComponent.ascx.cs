using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Controls
{
    public partial class DataComponent : System.Web.UI.UserControl
    {
        private List<Employee> data = null;
        public List<Employee> DataSource {

            get; set;

        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            rpData.DataSource = DataSource;
            rpData.DataBind();
        }
    }
}