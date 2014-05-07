using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.UnitOfWork;

namespace DataAccess.Repositories
{
    public abstract class RepositoryBase<TEntity> : MarshalByRefObject, IRepository<TEntity>
        where TEntity : class
    {
        protected IEntityContext GetContext(IUnitOfWork uow)
        {
            var unitOfWork = uow as UnitOfWorkBase;
            if (unitOfWork == null) throw new ArgumentException(String.Format("uow is niet van type {0}.", typeof(IEntityContext).Name), "uow");
            return unitOfWork.Context;
        }

        public abstract TEntity Get(IUnitOfWork uow, int id);

        protected virtual IQueryable<TEntity> FindBy(IUnitOfWork uow, Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = GetContext(uow)
                .Set<TEntity>()
                .Where(predicate);
            return query;
        }

        public virtual void Add(IUnitOfWork uow, TEntity entity)
        {
            GetContext(uow).Set<TEntity>().Add(entity);
        }

        public virtual void Delete(IUnitOfWork uow, TEntity entity)
        {
            GetContext(uow).Set<TEntity>().Remove(entity);
        }

        public void Update(IUnitOfWork uow, TEntity entity)
        {
            GetContext(uow).Entry(entity).State = EntityState.Modified;
        }
    }
}
