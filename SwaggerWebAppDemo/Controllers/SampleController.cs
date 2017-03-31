using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

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
        /// <response code="200">Successful response</response>
        [HttpGet]
        [Route("TestPublicGet")]
        [ResponseType(typeof(string))]
        public HttpResponseMessage TestPublicGet()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }

        /// <summary>
        /// Sample authenticated get method, used to show a more secure method requiring authentication
        /// </summary>
        /// <returns>Status message. should be success for all authenticated responses</returns>
        /// <response code="200">Successful response</response>
        /// <response code="401">User not yet authenticated</response>
        [HttpGet]
        [Route("TestAuthenticatedGet")]
        [Authorize]
        [ResponseType(typeof(string))]
        public HttpResponseMessage TetAuthenticatedGet()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }

    }
}
