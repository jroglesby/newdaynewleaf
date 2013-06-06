using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NewDayNewLeaf
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "FishInfoAll",
                url: "FishInfo/AllFish/",
                defaults: new { controller = "FishInfo", action = "AllFish" }
            );

            routes.MapRoute(
                name: "FishInfo",
                url: "FishInfo/{fishName}",
                defaults: new { controller = "FishInfo", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}