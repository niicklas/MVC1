using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.IgnoreRoute("Participant/Create");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new
                {
                    controller = "Main",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Participants",
                url: "{action}",
                defaults: new
                {
                    controller = "Participant",
                    action = "All",
                }
            );

            routes.MapRoute(
                name: "Info",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Main",
                    action = "All",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
