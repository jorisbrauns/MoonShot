using System;
namespace DataAccess.uow
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IEntityContext context)
        {
            Context = context;
        }

        private bool _isDisposed;

        protected void CheckDisposed()
        {
            if (_isDisposed) throw new ObjectDisposedException("De UnitOfWork is al disposed en kan niet meer gebruikt worden.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                        Context = default(IEntityContext);
                    }
                }
            }
            _isDisposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        public int Save()
        {
            CheckDisposed();
            return Context.SaveChanges();
        }

        public IEntityContext Context { get; set; }
        public Int32? CommandTimeOutInSeconds { get; set; }
    }
}
