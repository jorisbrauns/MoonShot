﻿using System.Linq;
using System.Web.Http;
using DataAccess.Repositories;
using DataAccess.uow;
using Entities;
using Entities.Infrastructure;

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

        public IPagination<Person> Get([FromUri] PagingCriteria pagingCriteria, [FromUri] Person personFilter, [FromUri] bool OrderBy, [FromUri] string OrderOn)
        {
            int totalRecords = 0;
            Entities.OrderBy order = OrderBy ? Entities.OrderBy.Ascending : Entities.OrderBy.Descending;

            var orderBy = new PersonOrderBy
            {
                Id = OrderOn == "Id" ? order : Entities.OrderBy.None,
                FirstName = OrderOn == "FirstName" ? order : Entities.OrderBy.None,
                LastName = OrderOn == "LastName" ? order : Entities.OrderBy.None,
                Age = OrderOn == "Age" ? order : Entities.OrderBy.None,
            };

            var dataResult = _personRepository.GetByPaging(pagingCriteria, personFilter, orderBy, out totalRecords);

            IPagination<Person> result = new Pagination<Person>
            {
                Records = dataResult.ToList(),
                TotalItems = totalRecords,
                PageSize = pagingCriteria.PageSize,
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
