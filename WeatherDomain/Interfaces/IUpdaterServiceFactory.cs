namespace WeatherDomain
{
    public interface IUpdaterServiceFactory
    {
        IUpdaterService GetService();
    }
}