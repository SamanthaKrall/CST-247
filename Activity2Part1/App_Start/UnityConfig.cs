using Activity2Part1.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Activity2Part1.Services.Business;

namespace Activity2Part1.App_Start
{
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });
        public static IUnityContainer Container => container.Value;
        #endregion

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ILogger, MyLogger2>();
            container.RegisterType<ITestService, TestService>();
            container.RegisterType<TestService>(new Unity.Injection.InjectionMethod("Initialize", new MyLogger2()));

        }
    }
}