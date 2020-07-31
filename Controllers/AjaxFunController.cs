using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Mexoft_site.Models;

namespace Mexoft_site.Controllers
{
    public class AjaxFunController : Controller
    {
        public IActionResult Index()
        {
            TestClass tc = new TestClass();

            int res = tc.Add2Numbers(1, 2);
            res = tc.multiply2Numbers(10, 4);
            var str = tc.funky();
            return View();
        }

        [HttpPost]
        public ActionResult AjaxPost1(string Name)
        {
            if (string.IsNullOrEmpty(Name))
                return Json("You didn't add a name....");
            else
                return Json("Good name you got there, <b>" + Name+"</b>");
        }

        [HttpPost]
        public ActionResult AjaxPost2(string Occupation)
        {
            if (string.IsNullOrEmpty(Occupation))
                return Json("You didn't add an ccupation....");
            else
            return Json("Congratulation with your job as <b>" + Occupation + "</b>");
        }
    }
}
