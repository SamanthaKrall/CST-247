using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity2Part1.Models;
using NLog;
using Activity2Part1.Services.Business;
using Activity2Part1.Services.Utility;

namespace Activity2Part1.Controllers
{
    public class LoginController : Controller
    {
        private static MyLogger1 logger = MyLogger1.GetInstance();

        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            if (!ModelState.IsValid)
            {return View("Login");
            }

            SecurityService authService = new SecurityService();

            bool authorized = authService.Authenticate(model);

            if (authorized)
            {return View("LoginPassed", model);
            }
            else
            {return View("LoginFailed");
            }
        }
    }
}