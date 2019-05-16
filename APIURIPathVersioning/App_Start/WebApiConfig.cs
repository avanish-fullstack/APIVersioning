using APIURIPathVersioning.App_Start;
using Microsoft.Web.Http.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace QueryParamVersioning
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //GitHub - https://github.com/microsoft/aspnet-api-versioning/blob/master/src/Common/Versioning/QueryStringApiVersionReader.cs

            // Web API configuration and services
            config.AddApiVersioning(options => options.ApiVersionReader = new QueryStringApiVersionReader());

            // Without the API Versioning package
            // config.Services.Replace(typeof(IHttpControllerSelector), new CustomContollerSelector(config));


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
