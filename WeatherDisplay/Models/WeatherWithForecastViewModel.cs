using System;
using System.Collections.Generic;

namespace WeatherDisplay.Models
{
    public class WeatherWithForecastViewModel
    {
        public List<ForecastViewModel> Forecast;

        public List<WeatherViewModel> Weather;

        public WeatherWithForecastViewModel(DateTime now)
        {
            this.Forecast = new List<ForecastViewModel>();
            this.Weather = new List<WeatherViewModel>();
            this.Now = now;
        }

        public DateTime Now { get; private set; }
    }
}