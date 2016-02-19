using System;
using WeatherDomain;

namespace OpenWeatherMapFetcher
{
    public class OpenWeatherMapWeatherUrlFactory : IWeatherUrlFactory
    {
        public OpenWeatherMapWeatherUrlFactory(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException("apiKey");
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; private set; }

        public string GetForecastUrl(ulong cityId, uint daysCount)
        {
            if (daysCount <= 0) throw new Exception(string.Format("Неправильно указано количество дней прогноза: {0}", daysCount));

            return string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?id={0}&lang=ru&appid={1}&units=metric&cnt={2}",
                cityId,
                this.ApiKey,
                daysCount
                );
        }

        public string GetWeatherUrl(ulong cityId)
        {
            return string.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&lang=ru&appid={1}&units=metric",
               cityId,
               this.ApiKey);
        }
    }
}