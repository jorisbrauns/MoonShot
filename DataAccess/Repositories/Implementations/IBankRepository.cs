using System.Collections.Generic;
using DataAccess.UnitOfWork;
using Entities;

namespace DataAccess.Repositories.Implementations
{
    public interface IBankRepository : IRepository<Bank>
    {
        IEnumerable<Bank> FindAll(IUnitOfWork uow);
    }
}
