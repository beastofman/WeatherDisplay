using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WeatherDisplay
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var controllerFactory = new WeatherControllerFactory();
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}