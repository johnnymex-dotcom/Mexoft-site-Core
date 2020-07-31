﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mexoft_site.Models;

namespace Mexoft_site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ReadConfigValues()
        {
            return View();
        }

        public ActionResult HowToImplementEFCore()
        {
            return View();
        }

        public ActionResult HowToImplementCulture()
        {
            return View();
        }

        public ActionResult GetMethods()
        {
            return View();
        }
        public ActionResult PutMethod()
        {
            return View();
        }
        public ActionResult PostMethod()
        {
            return View();
        }

        public IActionResult ShowValidators()
        {
            return View();
        }

        public ActionResult AjaxBeginForm()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
