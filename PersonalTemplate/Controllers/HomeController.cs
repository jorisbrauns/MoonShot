using System.Linq;
using System.Web.Mvc;
using DataAccess.Factories;
using DataAccess.Repositories.Implementations;
using DataAccess.UnitOfWork;
using Entities;

namespace PersonalTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IBankRepository _bankRepository;

        public HomeController()
        {
             _unitOfWorkFactory = new UnitOfWorkFactory();
            _bankRepository = new BankRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            using (IUnitOfWork uow = _unitOfWorkFactory.CreateUnitOfWork())
            {
                var newObject = new Bank {Naam = "KBC"};

                _bankRepository.Add(uow, newObject);

                var result = _bankRepository.FindAll(uow);

                var firstOrDefault = result.FirstOrDefault();
                if (firstOrDefault != null)
                {
                    _bankRepository.Delete(uow, firstOrDefault);
                }


                uow.Save();
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}