using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            var ex = new Exception("Invalid Controller/Action ");
            var eInfo = new HandleErrorInfo(ex, "Unknown", "Unknown");
            return View("Error", eInfo);
        }
    }
}