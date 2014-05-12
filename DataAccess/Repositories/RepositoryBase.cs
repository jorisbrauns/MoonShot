using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.uow;
using Entities;
namespace DataAccess.Repositories
{
    public abstract class RepositoryBase<TEntity> :  IRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;

        protected IDbSet<TEntity> DbSet { get; private set; }

        protected RepositoryBase(IUnitOfWork uow)
        {
            _unitOfWork = uow;
            DbSet = uow.Context.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<TEntity> FindAll()
        {
            return DbSet.ToList();
        }

        protected virtual IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query =
                DbSet
               .Where(predicate);
            return query;
        }

        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
        }
    }
}
