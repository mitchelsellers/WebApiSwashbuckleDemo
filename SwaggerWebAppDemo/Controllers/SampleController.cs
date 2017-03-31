using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerWebAppDemo.Controllers
{
    /// <summary>
    /// Grouping of API Methods for sample/demonstration purposes
    /// </summary>
    [RoutePrefix("Samples")]
    public class SampleController : ApiController
    {
        /// <summary>
        /// Sample get method, used to get a status message
        /// </summary>
        /// <returns>Status message.  Should be success for all responses</returns>
        [HttpGet]
        [Route("TestPublicGet")]
        public HttpResponseMessage TestPublicGet()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }

        /// <summary>
        /// Sample authenticated get method, used to show a more secure method requiring authentication
        /// </summary>
        /// <returns>Status message. should be success for all authenticated responses</returns>
        [HttpGet]
        [Route("TestAuthenticatedGet")]
        [Authorize]
        public HttpResponseMessage TetAuthenticatedGet()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }

    }
}
