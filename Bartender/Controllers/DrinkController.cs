﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Controllers
{
    public class DrinkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
