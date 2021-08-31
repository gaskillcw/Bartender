using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bartender.Models;
using Bartender.Repository;
using Microsoft.AspNetCore.Http;
using Bartender.Models.ViewModels;
using Bartender.Services.Interfaces;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace Bartender.Controllers
{

    [Authorize("Staff")]
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

        // this is where orders will be deilvered
        public IActionResult OrderReady(String id)
        {
            Order order = _repository.Orders.Where(x => x.Equals(id)).FirstOrDefault();

            _repository.Orders.Remove(order);

            return RedirectToAction("Index");
        }
    }
}
