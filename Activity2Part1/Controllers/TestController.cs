using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> user = new List<UserModel>();

            UserModel user1 = new UserModel("Sam","heya", "slamminsammy@gcu.com", "1233241234");
            UserModel user2 = new UserModel("Steven", "kitter", "krall@noneya.net", "4563451234");

            user.Add(user1);
            user.Add(user2);

            return View("Test", user);
        }
    }
}