using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Entities;

namespace DataAccess
{
    public interface IEntityContext : IDisposable
    {
        int SaveChanges();
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        IDbSet<Bank> Banks { get; set; }
        IDbSet<Person> Persons { get; set; }
    }
}
