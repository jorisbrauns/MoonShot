using DataAccess.UnitOfWork;

namespace DataAccess.Repositories
{
    public interface IRepository<TEntity>
    {
        TEntity Get(IUnitOfWork uow, int id);

        void Add(IUnitOfWork uow, TEntity entity);
        void Delete(IUnitOfWork uow, TEntity entity);
        void Update(IUnitOfWork uow, TEntity entity);
    }
}
