using System.Web.Optimization;
using Microsoft.Owin;
using Nancy;
using Nancy.Owin;
using Owin;

[assembly: OwinStartup(typeof(Moonshot.Startup))]
namespace Moonshot
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            app.UseNancy(options => options.PassThroughWhenStatusCodesAre(HttpStatusCode.NotFound));
        }
    }
}