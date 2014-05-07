using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitOfWork;
using Entities;

namespace DataAccess.Repositories.Implementations
{
    public class BankRepository : RepositoryBase<Bank>, IBankRepository
    {
        public IEnumerable<Bank> FindAll(IUnitOfWork uow)
        {
            return GetContext(uow).Banken.ToList();
        }

        public override Bank Get(IUnitOfWork uow, int id)
        {
            return FindBy(uow, x => x.BankId == id).FirstOrDefault();
        }

    }
}
