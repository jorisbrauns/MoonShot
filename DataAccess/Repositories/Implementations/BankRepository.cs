using DataAccess.uow;
using Entities;

namespace DataAccess.Repositories.Implementations
{
    public class BankRepository : RepositoryBase<Bank>, IBankRepository
    {
        public BankRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
