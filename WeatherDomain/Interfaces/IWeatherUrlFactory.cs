namespace WeatherDomain
{
    public interface IWeatherUrlFactory
    {
        string GetForecastUrl(ulong cityId, uint daysCount);

        string GetWeatherUrl(ulong cityId);
    }
}