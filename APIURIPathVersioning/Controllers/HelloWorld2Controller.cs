using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIURIPathVersioning.Controllers
{
   
    [RoutePrefix("api/helloworld")]
    [ApiVersion("2.0")]
    public class HelloWorld2Controller : ApiController
    {        
        [Route]
        public string get() => "Hello World V2.0";
    }
}
