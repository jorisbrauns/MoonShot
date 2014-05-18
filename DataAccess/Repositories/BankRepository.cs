using DataAccess.uow;
using Entities;

namespace DataAccess.Repositories
{
    public class BankRepository : RepositoryBase<Bank>, IBankRepository
    {
        public BankRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
