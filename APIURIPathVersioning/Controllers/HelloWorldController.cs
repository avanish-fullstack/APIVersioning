using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QueryParamVersioning.Controllers
{
        
    public class HelloWorldController : ApiController
    {
        [ApiVersion("1.0")]        
        public string get() => "Hello World V1.0";

        [ApiVersion("2.0")]        
        public string get1() => "Hello World V2.0";
    }
}
