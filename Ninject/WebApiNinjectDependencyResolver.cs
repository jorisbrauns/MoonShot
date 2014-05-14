using System.Web.Http.Dependencies;
namespace IOC.Ninject
{
    public class WebApiNinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver 
    {
        public IDependencyScope BeginScope()
        {
            return this;
        }
    }
}
