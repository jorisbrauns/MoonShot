using System;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Int32? CommandTimeOutInSeconds { get; set; }
        int Save();
    }
}
