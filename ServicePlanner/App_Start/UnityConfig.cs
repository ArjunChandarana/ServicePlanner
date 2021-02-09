using SP_BAL.Class;
using SP_BAL.Interfaces;
using System.Web.Http;
using Unity;
using Unity.WebApi;
using SP_BAL.Helper;

namespace ServicePlanner
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IBrandManager, BrandManager>();
            container.AddNewExtension<UnityRepositoryHelper>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}