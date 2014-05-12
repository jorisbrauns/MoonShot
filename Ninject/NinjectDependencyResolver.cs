using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DataAccess;
using DataAccess.uow;
using IOC.Ninject.Modules;
using Ninject;
using Ninject.Syntax;

namespace IOC.Ninject
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;
        public NinjectDependencyResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        protected IBindingToSyntax<T> Bind<T>()
        {
            return _kernel.Bind<T>();
        }

        private void AddBindings()
        {
            // CONTEXT (without module)
            Bind<IEntityContext>().To<EntityContext>();
            // UNIT OF WORK (without module)
            Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();

            // REPOSITORIES (with module)
            _kernel.Load(new RepositoryModule());

        }
    }
}
