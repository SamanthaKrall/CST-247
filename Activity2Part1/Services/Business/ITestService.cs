using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Activity2Part1.Services.Utility;
using System.Threading.Tasks;


namespace Activity2Part1.Services.Business
{
    public interface ITestService
    {
        void Initialize(ILogger logger);
        void TestLogger();
    }
}