using ProductWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProductWebApplication
{
    public partial class Billing_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cart = Session["myCart"] as List<Product>;
            lstCart.DataSource = cart;
            lstCart.DataBind();

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            var cart = Session["myCart"] as List<Product>;
            var amount = 0.0;
            foreach (var item in cart)
            {
                amount += item.Price * item.Quantity;
            }
            lblMessage.Text = string.Format("An Amount of {0:c} should be paid on Delivery at your registered Location", amount);
            Session["myCart"] = new List<Product>();

        }
    }
}