using System;
using System.Collections.Generic;

namespace WeatherDomain
{
    public class WeatherDisplayService : IWeatherDisplayService
    {
        private readonly IWeatherRepository m_repository;

        public WeatherDisplayService(IWeatherRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");
            this.m_repository = repository;
        }

        /// <summary>
        /// Получить погоду на указанную дату для выбранного населенного пункта
        /// </summary>
        /// <param name="cityId">Код населенного пункта</param>
        /// <param name="dateTime">Дата и время</param>
        /// <returns></returns>
        public DayWeather GetDayWeather(ulong cityId, DateTime dateTime)
        {
            return this.m_repository.GetDayWeather(cityId, dateTime);
        }

        /// <summary>
        /// Получить прогноз погоды на период для выбранного населенного пункта
        /// </summary>
        /// /// <param name="cityId">Код населенного пункта</param>
        /// <param name="start">Начало периода</param>
        /// <param name="end">Окончание периода</param>
        /// <returns></returns>
        public IEnumerable<Forecast> GetForecast(ulong cityId, DateTime start, DateTime end)
        {
            return this.m_repository.GetForecast(cityId, start, end);
        }
    }
}