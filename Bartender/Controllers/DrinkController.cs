using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Controllers
{
    

    public class DrinkController : Controller
    {
        private Repository.Repository _repository;

        public DrinkController(Repository.Repository repository)
        {
            _repository = repository;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
