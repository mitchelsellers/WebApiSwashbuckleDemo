using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerWebAppDemo.Controllers
{
    [RoutePrefix("Samples")]
    public class SampleController : ApiController
    {
        [HttpGet]
        [Route("TestPublicGet")]
        public HttpResponseMessage TestPublicGet()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }

        [HttpGet]
        [Route("TestAuthenticatedGet")]
        [Authorize]
        public HttpResponseMessage TetAuthenticatedGet()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }

    }
}
