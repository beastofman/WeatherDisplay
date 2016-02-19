using System;

namespace WeatherDomain
{
    public class WeatherFetcherService : IWeatherFetcherService
    {
        private readonly IWeatherFetcher m_fetcher;
        private readonly IWeatherStorage m_storage;

        public WeatherFetcherService(IWeatherFetcher fetcher, IWeatherStorage storage)
        {
            if (fetcher == null) throw new ArgumentNullException("fetcher");
            if (storage == null) throw new ArgumentNullException("storage");
            this.m_fetcher = fetcher;
            this.m_storage = storage;
        }

        public void FetchForecast(ulong cityId, uint daysCount)
        {
            this.m_storage.SaveForecast(this.m_fetcher.GetForecast(cityId, daysCount));
        }

        public void FetchWeather(ulong cityId)
        {
            this.m_storage.SaveWeather(this.m_fetcher.GetWeather(cityId));
        }
    }
}