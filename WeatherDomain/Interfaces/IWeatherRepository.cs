using System;
using System.Collections.Generic;

namespace WeatherDomain
{
    public interface IWeatherRepository
    {
        /// <summary>
        /// Получить погоду на указанную дату
        /// </summary>
        /// <param name="cityId"></param>
        /// <param name="dateTime">Дата и время</param>
        /// <returns></returns>
        DayWeather GetDayWeather(ulong cityId, DateTime dateTime);

        /// <summary>
        /// Получить прогноз погоды на период
        /// </summary>
        /// <param name="cityId"></param>
        /// <param name="start">Начало периода</param>
        /// <param name="end">Окончание периода</param>
        /// <returns></returns>
        IEnumerable<Forecast> GetForecast(ulong cityId, DateTime start, DateTime end);
    }
}