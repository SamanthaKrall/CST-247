using Activity2Part1.App_Start;
using System;
using System.Linq;
using System.Web.Mvc;
using Unity.AspNet.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Activity2Part1.UnityMvcActivator), nameof(Activity2Part1.UnityMvcActivator.Start))]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(Activity2Part1.UnityMvcActivator), nameof(Activity2Part1.UnityMvcActivator.Shutdown))]


namespace Activity2Part1
{
    public static class UnityMvcActivator
    {
        public static void Start()
        {
            FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
            FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(UnityConfig.Container));

            DependencyResolver.SetResolver(new UnityDependencyResolver(UnityConfig.Container));
        }

        public static void Shutdown()
        {
            UnityConfig.Container.Dispose();
        }
    }
}