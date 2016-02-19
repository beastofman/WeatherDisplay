using System;
using System.Web.Mvc;
using System.Web.Routing;
using SqlDataAccess;
using WeatherDisplay.Controllers;
using WeatherDisplay.Properties;
using WeatherDomain;

namespace WeatherDisplay
{
    public class WeatherControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == typeof(WeatherController))
            {
                var repository = new SqlWeatherRepository(Settings.Default.DataConnection);
                var service = new WeatherDisplayService(repository);
                return new WeatherController(service, Settings.Default.CityId);
            }

            return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}