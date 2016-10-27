using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NetCoders.SisAmigos.RestFul
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //libera o cors
            config.EnableCors();

            // Web API configuration and services

            config.Formatters.Remove(config.Formatters.XmlFormatter);


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
