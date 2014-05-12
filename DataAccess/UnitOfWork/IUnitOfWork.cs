using System;

namespace DataAccess.uow
{
    public interface IUnitOfWork : IDisposable
    {
        IEntityContext Context { get; set; }
        Int32? CommandTimeOutInSeconds { get; set; }
        int Save();
    }
}
