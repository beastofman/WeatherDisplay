using System.Collections.Generic;

namespace WeatherDomain
{
    public interface IWeatherStorage
    {
        /// <summary>
        /// Сохранить прогноз
        /// </summary>
        /// <param name="forecasts">Список прогнозов</param>
        void SaveForecast(IEnumerable<Forecast> forecasts);

        /// <summary>
        /// Сохранить погоду
        /// </summary>
        /// <param name="weather">Погода</param>
        void SaveWeather(Weather weather);
    }
}