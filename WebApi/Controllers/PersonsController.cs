using System.Collections.Generic;
using System.Web.Http;
using DataAccess.Repositories.Implementations;
using DataAccess.uow;
using Entities;

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

        // GET: api/Default
        public IEnumerable<Person> Get()
        {
            return _personRepository.FindAll();
        }

        // GET: api/Default/5
        public Person Get(int id)
        {
            return _personRepository.Get(id);
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
             _personRepository.Delete(this.Get(id));
        }
    }
}
