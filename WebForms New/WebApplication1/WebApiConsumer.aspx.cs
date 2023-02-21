using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebApiConsumer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                populateDataV2();
            }
        }

        private async void populateDataV2()
        {

        }

        private void populateData()
        {
            string url = "http://localhost:53745/api/Employee";
            WebClient proxy = new WebClient();
            proxy.Headers.Add("Content-type", "application/json");
            proxy.Encoding = Encoding.UTF8;

            string json = proxy.DownloadString(url);
            lblData.Text = json;
            myControl.DataSource = (new JavaScriptSerializer()).Deserialize<List<Employee>>(json);
            myControl.DataBind();
        }
    }
}