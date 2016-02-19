using System.Collections.Generic;

namespace WeatherDomain
{
    public interface IWeatherMapper
    {
        IEnumerable<Forecast> ToForecast(object source);

        Weather ToWeather(object source);
    }
}