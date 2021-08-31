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

    [Authorize(Roles = "Staff,Customer")]
    public class CustomerController : Controller
    {
        private Repository.Repository _repository;

        public CustomerController(Repository.Repository repository)
        {
            _repository = repository;
        }

        
        public IActionResult Index()
        {
            IEnumerable<Drink> drinks = _repository.Drinks;

            return View(drinks.ToList());
        }

        // this is where we will create order items
        public IActionResult PlaceOrder(string Name, float Price, string Ingredients)
        {


            return RedirectToAction("Index");
        }
    }
}
