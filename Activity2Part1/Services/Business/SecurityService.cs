using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Activity2Part1.Models;
using Activity2Part1.Services.Business;

namespace Activity2Part1.Services.Business
{
    public class SecurityService
    {
        public bool Authenticate(UserModel user)
        {
            SecurityDOA service = new SecurityDOA();
            return service.FindByUser(user);
        }
    }
}