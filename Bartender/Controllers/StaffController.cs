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
        [HttpPost]
        public IActionResult OrderReady(string id)
        {
            Order order = _repository.Orders.Where(x => x.OrderID == id).FirstOrDefault();

            if (order is null) { return NotFound($"Order with ID: {id} not found."); }

            _repository.Orders.Remove(order);

            return RedirectToAction("Index");
        }

        // ADDITIONAL EXPERIMENTAL FEATURES BELOW FOR PRACTICE, NOT REQUIRED BY PROJECT
        
        [HttpGet]
        public IActionResult CreateDrink()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDrink(Drink drink)
        {
            if (!ModelState.IsValid) { return View(); }


            _repository.Drinks.Add(drink);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (!ModelState.IsValid) { return View(); }


            _repository.Users.Add(user);

            return RedirectToAction("Index");
        }

    }
}
