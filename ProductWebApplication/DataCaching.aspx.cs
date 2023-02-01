using Class1;
using DataAccessLib;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductWebApplication
{
    public partial class DataCaching : System.Web.UI.Page
    {
        private void cacheObject()
        {
            if (Cache["myData"] == null)
            {
                var component = ProductFactory.GetComponent();
                var data = component.GetAllProducts();
                var textFile = Server.MapPath("MyCache.txt");
                /////////////////File Cache dependency//////////////////////////////
                //Cache.Add("myData",//Key for the cache
                //    data,//value of the cache 
                //    new System.Web.Caching.CacheDependency(textFile), //File Dependency
                //    DateTime.Now.AddMinutes(5) ,//Duration of the cache
                //    System.Web.Caching.Cache.NoSlidingExpiration, //No Sliding expiring
                //    System.Web.Caching.CacheItemPriority.Default,//default
                //    null);//No callback after the cache is created. 
                ////////////////////////SqlCacheDependency/////////////////////////////
                string strCon = ConfigurationManager.ConnectionStrings["cacheString"].ConnectionString;
                SqlCacheDependencyAdmin.EnableNotifications(strCon);
                SqlCacheDependencyAdmin.EnableTableForNotifications(strCon, "Product");
                SqlCacheDependency dep = new SqlCacheDependency("Output-cache", "Product");
                Cache.Add("myData", data, dep, DateTime.Now.AddMinutes(2), Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
                Response.Write("Data got from the database");
            }
            else
            {
                Response.Write("Data got from Cache");
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cacheObject();
                grdDetails.DataSource = Cache["myData"] as List<Product>;
                grdDetails.DataBind();
            }
        }
    }
}