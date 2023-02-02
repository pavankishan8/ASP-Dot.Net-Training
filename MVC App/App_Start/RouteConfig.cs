using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Calci",
                url: "{controller}/{action}/{p1}/{p2}",
                defaults: new { controller = "Home", action = "GetNumber" }
            );

            routes.MapRoute(
                name: "Employee",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "DisplayEmployee"}
            );

            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "HelloWorld" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Cars", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
