using Activity2Part1.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestLoggingService2Controller : Controller
    {
        [Unity.Dependency]
        public ILogger logger { get; set; }

        public string Index()
        {
            return "Test from LoggingService2";
        }
    }
}