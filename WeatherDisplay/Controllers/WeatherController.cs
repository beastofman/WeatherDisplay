using System;
using System.Linq;
using System.Web.Mvc;
using WeatherDisplay.Models;
using WeatherDomain;

namespace WeatherDisplay.Controllers
{
    public class WeatherController : Controller
    {
        private readonly ulong m_cityId;
        private readonly IWeatherDisplayService m_service;

        public WeatherController(IWeatherDisplayService displayService, ulong cityId)
        {
            if (displayService == null) throw new ArgumentNullException("displayService");
            this.m_service = displayService;
            this.m_cityId = cityId;
        }

        public ActionResult Index()
        {
            //var now = new DateTime(2016, 02, 19, 22, 22, 54);
            var now = DateTime.Now;
            var model = new WeatherWithForecastViewModel(now);
            var weather = this.m_service.GetDayWeather(this.m_cityId, now);
            var forecast = this.m_service.GetForecast(this.m_cityId, now.AddDays(1), now.AddDays(3));

            model.Forecast.AddRange(forecast.Select(f => new ForecastViewModel(f)));
            model.Weather = WeatherViewModel.FromDayWeather(weather, now);

            return this.View(model);
        }
    }
}