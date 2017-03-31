using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Swashbuckle.Swagger;

namespace SwaggerWebAppDemo.Filters
{
    /// <summary>
    ///     Custom <see cref="IOperationFilter" /> create to add the required "Authorization" header for swagger documentation
    /// </summary>
    /// <remarks>
    ///     Used for the generation of documentation for use with Swagger, not used for any implementation for web
    ///     functionality
    /// </remarks>
    public class AuthorizationHeaderOperationFilter : IOperationFilter
    {
        /// <summary>
        ///     Review each opertion, if a secure operation is found add the needed parameter to document authorization information
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiDescription"></param>
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            // Determine if the operation has the Authorize attribute
            var authorizeAttributes = apiDescription
                .ActionDescriptor.GetCustomAttributes<AuthorizeAttribute>();

            if (!authorizeAttributes.Any())
                return;

            if (operation.parameters == null)
                operation.parameters = new List<Parameter>();

            operation.parameters.Add(new Parameter
            {
                name = "Authorization",
                @in = "header",
                description = "Access Token From /Token replaces the XXX value",
                required = true,
                type = "string",
                @default = "Bearer XXX"
            });
        }
    }
}