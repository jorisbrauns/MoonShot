using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataAccess.Repositories.Implementations;
using DataAccess.uow;
using Entities;
using Entities.Infrastructure;
using WebApi.RequestsEntities;

namespace WebApi.Controllers
{
    public class PersonsController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPersonRepository _personRepository;

        public PersonsController(IUnitOfWork unitOfWork, IPersonRepository personRepository)
        {
            _unitOfWork = unitOfWork;
            _personRepository = personRepository;
        }

        public IPagination<Person> Get([FromUri] PagingCriteria pagingCriteria, [FromUri] Person personFilter)
        {
            int totalRecords = 0;

            var orderBy = new PersonOrderBy
            {
                Id = OrderBy.None,
                FirstName = OrderBy.Ascending,
                LastName = OrderBy.None,
                Age = OrderBy.None,
            };

            var records = _personRepository.GetByPaging(pagingCriteria, personFilter, orderBy, out totalRecords);

            IPagination<Person> result = new Pagination<Person>
            {
                Records = records.ToList(),
                TotalItems = totalRecords,
                PageSize = 25,
                Page = pagingCriteria.Page
            };

            return result;
        }

        // GET: api/Persons/5
        public Person Get(int id)
        {
            return _personRepository.Get(id);
        }

        // POST: api/Persons
        public bool Post(Person person)
        {
            _personRepository.Add(person);
           return _unitOfWork.Save() > 0;
        }

        // PUT: api/Persons/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Persons/5
        public void Delete(int id)
        {
             //_personRepository.Delete(this.Get(id));
        }
    }
}
