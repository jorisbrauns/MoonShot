using System;
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

        public virtual TEntity Get(IUnitOfWork uow, int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(IUnitOfWork uow, TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(IUnitOfWork uow, TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IUnitOfWork uow, TEntity entity)
        {
            var ctx = GetContext(uow);
            //ctx.Entry(entity).State = System.Data.EntityState.Modified;
        }
    }
}
