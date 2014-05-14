using DataAccess.Repositories.Implementations;
using Ninject.Modules;

namespace IOC.Ninject.Modules
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBankRepository>().To<BankRepository>();
            Bind<IPersonRepository>().To<PersonRepository>();
        }
    }

}
