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

        public override void Add(IUnitOfWork uow, Bank entity)
        {
            GetContext(uow).Banken.Add(entity);
        }
    }
}
