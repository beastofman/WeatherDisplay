using System;
using System.Collections.Generic;

namespace WeatherDomain
{
    public interface IWeatherDisplayService
    {
        /// <summary>
        /// Получить погоду на указанную дату для выбранного населенного пункта
        /// </summary>
        /// <param name="cityId">Код населенного пункта</param>
        /// <param name="dateTime">Дата и время</param>
        /// <returns></returns>
        DayWeather GetDayWeather(ulong cityId, DateTime dateTime);

        /// <summary>
        /// Получить прогноз погоды на период для выбранного населенного пункта
        /// </summary>
        /// /// <param name="cityId">Код населенного пункта</param>
        /// <param name="start">Начало периода</param>
        /// <param name="end">Окончание периода</param>
        /// <returns></returns>
        IEnumerable<Forecast> GetForecast(ulong cityId, DateTime start, DateTime end);
    }
}