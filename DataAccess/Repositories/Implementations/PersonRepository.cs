using DataAccess.uow;
using Entities;

namespace DataAccess.Repositories.Implementations
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
