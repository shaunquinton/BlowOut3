using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BlowOut
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contact",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional }
            );
           
            routes.MapRoute(
               name: "email",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Contact", action = "email", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                  name: "RentalNew",
                  url: "{controller}/{action}/{id}",
                  defaults: new { controller = "Rentals", action = "RentalNew", id = UrlParameter.Optional }
              );

            routes.MapRoute(
                  name: "Rentalused",
                  url: "{controller}/{action}/{id}",
                  defaults: new { controller = "Rentals", action = "Rentalused", id = UrlParameter.Optional }
              );

           
        }
    }
}
