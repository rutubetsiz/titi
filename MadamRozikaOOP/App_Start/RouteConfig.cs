using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MadamRozikaOOP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Anasayfa",
                url: "anasayfa",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Category",
                url: "{categoryurl}",
                defaults: new { controller = "Category", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CategorySayfa",
                url: "{categoryurl}/sayfa-{sayfaid}",
                defaults: new { controller = "Category", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
