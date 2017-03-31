using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SwaggerWebAppDemo.Models;

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

        /// <summary>
        /// Method to get a listing of employers with a specified search process
        /// </summary>
        /// <remarks>
        /// This is a great place to put examples for your users to see what they might need to know.
        /// </remarks>
        /// <param name="options">The desired search criteria for</param>
        /// <returns>Result object with success/failure indication and any results</returns>
        /// <response code="200">Successful response</response>
        /// <response code="401">User not yet authenticated</response>
        [HttpPost]
        [Route("SearchEmployers")]
        [Authorize]
        [ResponseType(typeof(EmployerSearchResultModel))]
        public HttpResponseMessage SearchEmployers(SearchRequestModel options)
        {
            //TODO: Actually work
            return Request.CreateResponse(HttpStatusCode.OK, new EmployerSearchResultModel());
        }
    }
}
