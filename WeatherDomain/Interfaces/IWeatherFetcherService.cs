namespace WeatherDomain
{
    public interface IWeatherFetcherService
    {
        /// <summary>
        /// Получить прогноз погоды и сохранить его в хранилище
        /// </summary>
        /// <param name="cityId">Код населенного пункта</param>
        /// <param name="daysCount">Кол-во дней прогноза</param>
        /// <returns></returns>
        void FetchForecast(ulong cityId, uint daysCount);

        /// <summary>
        /// Получить текущую погоду и сохранить данные в хранилище
        /// </summary>
        /// <param name="cityId">Код населенного пункта</param>
        /// <returns></returns>
        void FetchWeather(ulong cityId);
    }
}