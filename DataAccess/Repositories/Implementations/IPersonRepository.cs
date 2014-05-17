using System.Collections.Generic;
using System.Linq;
using Entities;
using Entities.Infrastructure;

namespace DataAccess.Repositories.Implementations
{
    public interface IPersonRepository : IRepository<Person>
    {
        List<Person> GetByPaging(PagingCriteria criteria, Person filter, PersonOrderBy orderBy,
            out int totalRecords);

        IEnumerable<Person> GetByFilter(Person filter, PersonOrderBy orderBy, IQueryable<Person> query);
    }
}
