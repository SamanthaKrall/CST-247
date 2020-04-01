using Activity2Part1.Services.Business;
using Activity2Part1.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestLoggingService3Controller : Controller
    {
        private ILogger logger;
        private ITestService service;

        public TestLoggingService3Controller(ILogger log, ITestService svc)
        {
            this.logger = log;
            this.service = svc;
        }

        public string Index()
        {
            service.TestLogger();
            return "TestLoggingService3";
        }
    }
}