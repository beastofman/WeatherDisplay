using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using WeatherDomain;

namespace OpenWeatherMapFetcher
{
    public class OpenWeatherMapWeatherFetcher : IWeatherFetcher
    {
        private readonly IWeatherMapper m_mapper;
        private readonly IWeatherUrlFactory m_weatherUrlFactory;

        public OpenWeatherMapWeatherFetcher(IWeatherUrlFactory weatherUrlFactory, IWeatherMapper mapper)
        {
            if (weatherUrlFactory == null) throw new ArgumentNullException("weatherUrlFactory");
            if (mapper == null) throw new ArgumentNullException("mapper");
            this.m_weatherUrlFactory = weatherUrlFactory;
            this.m_mapper = mapper;
        }

        public IEnumerable<Forecast> GetForecast(ulong cityId, uint daysCount)
        {
            var url = this.m_weatherUrlFactory.GetForecastUrl(cityId, daysCount);
            var response = this.FetchDataFromUrl(url);

            return this.m_mapper.ToForecast(response);
        }

        public Weather GetWeather(ulong cityId)
        {
            var url = this.m_weatherUrlFactory.GetWeatherUrl(cityId);
            var response = this.FetchDataFromUrl(url);

            return this.m_mapper.ToWeather(response);
        }

        private string FetchDataFromUrl(string url)
        {
            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                return client.DownloadString(url);
            }
        }
    }
}