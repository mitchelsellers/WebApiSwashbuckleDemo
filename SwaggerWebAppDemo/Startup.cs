using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;
using System.Web.Http;

[assembly: OwinStartupAttribute(typeof(SwaggerWebAppDemo.Startup))]
namespace SwaggerWebAppDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            var config = new HttpConfiguration();

            ConfigureAuth(app);
            app.UseWebApi(config);
        }
    }
}
