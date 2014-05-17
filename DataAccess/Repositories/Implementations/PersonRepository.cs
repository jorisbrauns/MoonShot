using System.Collections.Generic;
using System.Linq;
using DataAccess.uow;
using Entities;
using Entities.Infrastructure;

namespace DataAccess.Repositories.Implementations
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IUnitOfWork uow) : base(uow)
        {
        
        }

        public List<Person> GetByPaging(PagingCriteria criteria, Person filter, PersonOrderBy orderBy,
            out int totalRecords)
        {
            var query = GetByFilter(filter, orderBy, DbSet);
            totalRecords = query.Count();

            return query.Skip((criteria.Page - 1) * criteria.PageSize).Take(criteria.PageSize).ToList();
        }

        public IEnumerable<Person> GetByFilter(Person  filter, PersonOrderBy orderby, IQueryable<Person> query)
        {

            #region Filtering
            if (!string.IsNullOrEmpty(filter.FirstName))
            {
                query = query.Where(f => f.FirstName.Contains(filter.FirstName));
            }
            if (!string.IsNullOrEmpty(filter.LastName))
            {
                query = query.Where(f => f.LastName.Contains(filter.LastName));
            }
            query = query.Where(f => f.Age == filter.Age);
            #endregion

            #region Sorting
            IOrderedQueryable<Person> orderedQuery = query.OrderBy(o => 0);
            if (orderby.FirstName != OrderBy.None)
            {
                orderedQuery = orderby.FirstName == OrderBy.Ascending
                    ? orderedQuery.ThenBy(o => o.FirstName)
                    : orderedQuery.ThenByDescending(o => o.LastName);
            }
            if (orderby.LastName != OrderBy.None)
            {
                orderedQuery = orderby.LastName == OrderBy.Ascending
                    ? orderedQuery.ThenBy(o => o.LastName)
                    : orderedQuery.ThenByDescending(o => o.LastName);
            }
            if (orderby.Age != OrderBy.None)
            {
                orderedQuery = orderby.Age == OrderBy.Ascending
                    ? orderedQuery.ThenBy(o => o.Age)
                    : orderedQuery.ThenByDescending(o => o.Age);
            }
            #endregion

            return orderedQuery;
        }
    }
}
