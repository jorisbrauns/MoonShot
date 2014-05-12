using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using DataAccess.Repositories.Implementations;
using DataAccess.uow;
using Entities;
using WebGrease.Css.Extensions;

namespace PersonalTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWorkFactory;
        private readonly IBankRepository _bankRepository;

        public HomeController(IUnitOfWork uow, IBankRepository bankRepository)
        {
            _unitOfWorkFactory = uow;
            _bankRepository = bankRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            try
            {
                //_bankRepository.Add(new Bank { Naam = "KBC"});
                //_bankRepository.Add(new Bank { Naam = "Argenta" });
                //_bankRepository.Add(new Bank { Naam = "ING" });

                var list = _bankRepository.FindAll();
                var allBanks = string.Join(", ", list.Select(w => w.Name));

                int num = _unitOfWorkFactory.Save();

                ViewBag.result = "Saved! <br><br>" + allBanks;
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                ViewBag.result = exceptionMessage;

                // Throw a new DbEntityValidationException with the improved exception message.
                //throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
            catch (Exception ex)
            {
                ViewBag.result = ex.Message;
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