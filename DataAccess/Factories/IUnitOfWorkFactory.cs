using DataAccess.UnitOfWork;

namespace DataAccess.Factories
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork CreateUnitOfWork();
        IUnitOfWork CreateUnitOfWork(string nameOrConnectionString);
    }
}
