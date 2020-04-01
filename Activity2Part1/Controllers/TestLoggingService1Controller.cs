using Activity2Part1.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestLoggingService1Controller : Controller
    {
        private ILogger logger;

        public TestLoggingService1Controller(ILogger log)
        {
            this.logger = log;
        }

        public string Index()
        {
            return "tested logger 1";
        }
    }
}