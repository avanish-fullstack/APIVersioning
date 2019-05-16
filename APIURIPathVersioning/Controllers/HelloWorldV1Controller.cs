using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QueryParamVersioning.Controllers
{
        
    public class HelloWorldV1Controller : ApiController
    {        
        public string get() => "Hello World V1.0";
    }
}
