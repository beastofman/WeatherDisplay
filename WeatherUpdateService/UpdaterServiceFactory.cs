using OpenWeatherMapFetcher;
using OpenWeatherMapJsonMapper;
using SqlDataAccess;
using WeatherDomain;
using WeatherUpdateService.Properties;

namespace WeatherUpdateService
{
    public class UpdaterServiceFactory : IUpdaterServiceFactory
    {
        public IUpdaterService GetService()
        {
            var url = new OpenWeatherMapWeatherUrlFactory(Settings.Default.API_Key);
            var mapper = new JsonWeatherMapper();
            var fetcher = new OpenWeatherMapWeatherFetcher(url, mapper);

            var storage = new SqlWeatherRepository(Settings.Default.DataConnection);

            var fetcherService = new WeatherFetcherService(fetcher, storage);

            return new UpdaterService(fetcherService);
        }
    }
}