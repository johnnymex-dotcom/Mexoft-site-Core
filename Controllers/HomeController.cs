using System;
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

        public ActionResult CVMain()
        {
            return View();
        }

        public ActionResult CRUD_React()
        {
            return View();
        }

        public ActionResult CRUD_React_Edit()
        {
            return View();
        }

        public ActionResult WebAPISeveralGetMethods()
        {
            return View();
        }

        public ActionResult BasicAsyncAwaitIssue()
        {
            return View();
        }

        public ActionResult SFJ()
        {
            return View();
        }

        public ActionResult LOJ()
        {
            return View();
        }

        public ActionResult UnitTestInvolvingMocksAndstub()
        {
            return View();
        }

        public ActionResult UseMoqWithDbContext()
        {
            return View();
        }

        public ActionResult UseInMemoryDbContext()
        {
            return View();
        }

        public ActionResult GlobalizationIssue()
        {
            return View();
        }

        public ActionResult JwtIssue()
        {
            return View();
        }

        public ActionResult DoSomeSoapActions()
        {
            return View();
        }

        public ActionResult WinServiceAction()
        {
            return View();
        }

        public ActionResult WinformAction_Config_DbCtx()
        {
            return View();
        }

        public ActionResult SwaggerImplementationONAndOFF()
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
