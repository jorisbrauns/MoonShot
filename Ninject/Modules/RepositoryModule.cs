using DataAccess.Repositories.Implementations;
using Ninject.Modules;

namespace IOC.Ninject.Modules
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBankRepository>().To<BankRepository>();
            Bind<ITEst>().To<TEst>();
        }
    }

    public interface ITEst
    {
        
    }
    public class TEst : ITEst
    {
        
    }
}
