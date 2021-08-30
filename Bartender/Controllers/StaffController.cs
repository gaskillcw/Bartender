using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bartender.Models;
using Bartender.Repository;

namespace Bartender.Controllers
{


    public class StaffController : Controller
    {
        private Repository.Repository _repository;

        public StaffController(Repository.Repository repository)
        {
            _repository = repository;
        }


        public IActionResult Index()
        {
            IEnumerable<Order> orders = _repository.Orders;

            return View(orders.ToList());
        }
    }
}
