﻿using Microsoft.AspNetCore.Mvc;
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


    public class StaffController : Controller
    {
        private Repository.Repository _repository;

        public StaffController(Repository.Repository repository)
        {
            _repository = repository;
        }

        [Authorize("Staff")]
        public IActionResult Index()
        {
            IEnumerable<Order> orders = _repository.Orders;

            return View(orders.ToList());
        }
    }
}
