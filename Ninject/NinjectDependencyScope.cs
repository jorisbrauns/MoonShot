using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using DataAccess;
using DataAccess.uow;
using IOC.Ninject.Modules;
using Ninject;
using Ninject.Syntax;

namespace IOC.Ninject
{
    public abstract class NinjectDependencyScope : IDependencyScope
    {
        private IKernel _kernel;

        protected NinjectDependencyScope()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        public void Dispose()
        {
            var disposable = _kernel as IDisposable;
            if (disposable != null)
                disposable.Dispose();

            _kernel = null;
        }

        public object GetService(Type serviceType)
        {
            if (_kernel == null)
                throw new ObjectDisposedException("this", "This scope has already been disposed");

            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (_kernel == null)
                throw new ObjectDisposedException("this", "This scope has already been disposed");

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
