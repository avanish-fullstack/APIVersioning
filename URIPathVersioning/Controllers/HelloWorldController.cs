using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace URIPathVersioning.Controllers
{
    [Route("api/v{version:apiVersion}/helloworld")]
    public class HelloWorldController : ApiController
    {
        [ApiVersion("1.0")]      
        public string get() => "HelloWorld V1.0!";

        [ApiVersion("2.0")]        
        public string get1() => "HelloWorld V2.0!";
    }
}
