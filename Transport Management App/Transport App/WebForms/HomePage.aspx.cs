using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportApp.Data_Component;

namespace TransportApp.WebForms
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var repo = new RouteData();
                var AllRoute = repo.GetRouteTables();
                txtroute.DataSource = AllRoute;
                txtroute.DataTextField = "RouteName";
                txtroute.DataValueField = "RouteNo";
                txtroute.DataBind();
            }
        }

        protected void txtroute_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(txtroute.SelectedValue);
            var repo = new RouteData();
            var AllStops = repo.GetPickUpTables(id);
            var img = repo.GetRouteTables();
      // \Images\Nag - White.jpg
            foreach (var item in img)
            {
                if (item.RouteNo == id)
                {
                    var imdurl = item.RouteImage.ToString();
                    var converted = imdurl.Replace(@"D:\Starmark - Pavan R\ASP DotNet\Transport Management App\Solution1\TransportApp", "~");
                    imgprew.ImageUrl = $"{converted}";
                }

            }
                txtPickup.DataSource = AllStops;
            txtPickup.DataTextField = "PickUpPoint";
            txtPickup.DataValueField = "EntryID";
            txtPickup.DataBind();
            txtDrop.DataSource = AllStops;
            txtDrop.DataTextField = "PickUpPoint";
            txtDrop.DataValueField = "EntryID";
            txtDrop.DataBind();
        }
    }
}