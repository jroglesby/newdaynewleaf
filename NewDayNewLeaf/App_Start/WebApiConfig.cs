﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NewDayNewLeaf
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        
        {
            config.Routes.MapHttpRoute(
                name: "GetSpecificFish",
                routeTemplate: "api/Fish/{fishName}",
                defaults: new { controller="Fish", action="Get", fishName = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "GetCurrentFish",
                routeTemplate: "api/Fish/CurrentFish/{ticks}",
                defaults: new { controller = "Fish", action = "GetCurrentFish", ticks = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GenericAction",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
            config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All;
            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();

            // To disable tracing in your application, please comment out or remove the following line of code
            // For more information, refer to: http://www.asp.net/web-api
            config.EnableSystemDiagnosticsTracing();
        }
    }
}
