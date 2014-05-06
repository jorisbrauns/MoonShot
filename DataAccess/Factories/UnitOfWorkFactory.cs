using DataAccess.UnitOfWork;
namespace DataAccess.Factories
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork CreateUnitOfWork()
        {
            return new UnitOfWorkBase(CreateContext());
        }

        public IUnitOfWork CreateUnitOfWork(string nameOrConnectionString)
        {
            return new UnitOfWorkBase(CreateContext(nameOrConnectionString));
        }

        private EntityContext CreateContext()
        {
            return new EntityContext();
        }

        private EntityContext CreateContext(string nameOrConnectionString)
        {
            return new EntityContext(nameOrConnectionString);
        }
    }
}
