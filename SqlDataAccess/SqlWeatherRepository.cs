using System;
using System.Collections.Generic;
using System.Linq;
using WeatherDomain;

namespace SqlDataAccess
{
    public class SqlWeatherRepository : IWeatherRepository, IWeatherStorage
    {
        private readonly WeatherModelContext m_context;

        public SqlWeatherRepository(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString) || string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connectionString");

            this.m_context = new WeatherModelContext(connectionString);
        }

        public DayWeather GetDayWeather(ulong cityId, DateTime date)
        {
            var result = new DayWeather(date);
            var morning = (from f in this.m_context.Weather
                           where f.CityId == (long)cityId &&
                                 f.WeatherDate == date.Date &&
                                 f.WeatherTime.Hours >= 4 && f.WeatherTime.Hours < 10
                           orderby f.Measurement descending
                           select f).FirstOrDefault();
            var day = (from f in this.m_context.Weather
                       where f.CityId == (long)cityId &&
                             f.WeatherDate == date.Date &&
                             f.WeatherTime.Hours >= 10 && f.WeatherTime.Hours < 16
                       orderby f.Measurement descending
                       select f).FirstOrDefault();
            var evening = (from f in this.m_context.Weather
                           where f.CityId == (long)cityId &&
                                 f.WeatherDate == date.Date &&
                                 f.WeatherTime.Hours >= 16 && f.WeatherTime.Hours < 22
                           orderby f.Measurement descending
                           select f).FirstOrDefault();
            var night = (from f in this.m_context.Weather
                         where f.CityId == (long)cityId &&
                               f.WeatherDate == date.Date &&
                               (f.WeatherTime.Hours >= 22 || f.WeatherTime.Hours < 4)
                         orderby f.Measurement descending
                         select f).FirstOrDefault();

            result.Morning = morning == null
                ? null
                : morning.ToDomainWeather();
            result.Day = day == null
                ? null
                : day.ToDomainWeather();
            result.Evening = evening == null
                ? null
                : evening.ToDomainWeather();
            result.Night = night == null
                ? null
                : night.ToDomainWeather();

            return result;
        }

        public IEnumerable<WeatherDomain.Forecast> GetForecast(ulong cityId, DateTime start, DateTime end)
        {
            var result = new List<WeatherDomain.Forecast>();
            /*
             * Для начала сгруппируем прогнозы,
             * относящиеся к выбранному городу и периоду, по дате
             * и получим для каждой даты из периода
             * дату и время самого свежего прогноза
             */

            var latestMeasurements = (from f in this.m_context.Forecast
                                      where f.CityId == (long)cityId &&
                                      f.ForecastDate >= start.Date && f.ForecastDate <= end.Date
                                      group f by f.ForecastDate
                                          into g
                                          select new
                                          {
                                              ForecastDate = g.Key,
                                              Measurement = (from f in g select f.Measurement).Max()
                                          }
                                     );
            /*
             * Вернем пустой результат, если в бд нет прогнозов
             */
            if (!latestMeasurements.Any()) return result;

            foreach (var measurement in latestMeasurements)
            {
                /*
                 * Для каждой даты в периоде получим самый свежий прогноз
                 */
                var forecast = (from f in this.m_context.Forecast
                                where f.ForecastDate == measurement.ForecastDate &&
                                      f.Measurement == measurement.Measurement
                                select f).FirstOrDefault();
                if (forecast != null) result.Add(forecast.ToDomainForecast());
            }

            return result;
        }

        public void SaveForecast(IEnumerable<WeatherDomain.Forecast> forecasts)
        {
            var save = false;
            /*
             * Сохранять можно только те прогнозы, у которых заданы все температуры и
             * дата и время не равны DateTime.MinValue.
             * Такие данные рассматриваются как неправильно распознанные.
             */
            foreach (var forecast in forecasts.Where(forecast => forecast.Date != DateTime.MinValue &&
                                                                 !double.IsNaN(forecast.TemperatureDay) &&
                                                                 !double.IsNaN(forecast.TemperatureEvening) &&
                                                                 !double.IsNaN(forecast.TemperatureMorning) &&
                                                                 !double.IsNaN(forecast.TemperatureNight)
                ))
            {
                this.m_context.Forecast.AddObject(Forecast.ToForecast(forecast));
                save = true;
            }
            if (save) this.m_context.SaveChanges();
        }

        public void SaveWeather(WeatherDomain.Weather weather)
        {
            /*
             * Сохранять можно только те данные, у которых задана температура и
             * дата и время не равны DateTime.MinValue.
             * Такие данные рассматриваются как неправильно распознанные.
             */
            if (weather.Date == DateTime.MinValue ||
                double.IsNaN(weather.Temperature)) return;
            this.m_context.Weather.AddObject(Weather.ToWeather(weather));

            this.m_context.SaveChanges();
        }
    }
}