using System.Web.Http;
using IOC.Ninject;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.DependencyResolver = new WebApiNinjectDependencyResolver();
        }
    }
}
