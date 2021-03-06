﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BSIS.BoarderLogNightMonitoring.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.Add(new BSIS.BoarderLogNightMonitoring.API.App_Start.BrowserJsonFormatter());
        }
    }
}
