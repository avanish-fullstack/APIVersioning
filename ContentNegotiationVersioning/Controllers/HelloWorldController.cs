using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContentNegotiationVersioning.Controllers
{

    public class HelloWorldController : ApiController
    {
        //Accept - application/json;v=1.0

        [ApiVersion("1.0")]
        public string get() => "Hello world V1.0";

        [ApiVersion("2.0")]
        public string get1() => "Hello world V2.0";

        
    }
}
