using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common.WebHost;
using TestDomain.UI.IOC;

namespace TestDomain.UI
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);  
        }

        protected override IKernel CreateKernel()
        {
            var modules = new NinjectModule[] { new NinjectMod() };
            return new StandardKernel(modules);
        }
    }
}
