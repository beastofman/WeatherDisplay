using System.Collections.Generic;

namespace WeatherDomain
{
    public interface IWeatherFetcher
    {
        /// <summary>
        /// Получить прогноз погоды
        /// </summary>
        /// <param name="cityId">Код населенного пункта</param>
        /// <param name="daysCount">Кол-во дней прогноза</param>
        /// <returns></returns>
        IEnumerable<Forecast> GetForecast(ulong cityId, uint daysCount);

        /// <summary>
        /// Получить текущее значение погоды
        /// </summary>
        /// <param name="cityId">Код населенного пункта</param>
        /// <returns></returns>
        Weather GetWeather(ulong cityId);
    }
}