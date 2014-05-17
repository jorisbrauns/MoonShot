using Ninject.Modules;

namespace IOC.Ninject.Modules
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {

            //Bind<IPagination>().To<Pagination<>>();
        }
    }
}
