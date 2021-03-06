﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace APIURIPathVersioning.App_Start
{
    public class CustomContollerSelector : DefaultHttpControllerSelector
    {
        HttpConfiguration _config;

        public CustomContollerSelector(HttpConfiguration config) : base(config)
        {
            _config = config;
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            var controllers = GetControllerMapping();
            var routeData = request.GetRouteData();

            var controllerName = routeData.Values["controller"].ToString();

            var versionNumber = "1";

            var versionQueryString = HttpUtility.ParseQueryString(request.RequestUri.Query);

            if (versionQueryString["v"] != null)
            {
                versionNumber = versionQueryString["v"];
            }
               if (versionNumber == "1")
                {
                    controllerName = controllerName + "V1";
                }
                else
                {
                controllerName = controllerName + "V2";
                }

            HttpControllerDescriptor controllerDescriptor;
            if (controllers.TryGetValue("controllerName", out controllerDescriptor))
            {
                return controllerDescriptor;
            }

            return null;
        }
    }
}