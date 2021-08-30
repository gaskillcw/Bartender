using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Bartender.Models;
using Bartender.Repository;

namespace Bartender.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
