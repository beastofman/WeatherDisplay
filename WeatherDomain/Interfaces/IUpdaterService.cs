namespace WeatherDomain
{
    public interface IUpdaterService
    {
        /// <summary>
        /// Интервал обновления данных в секундах
        /// </summary>
        uint UpdateInterval { get; set; }

        /// <summary>
        /// Вызвать обновление данных, невзирая на интервал обновления
        /// </summary>
        void ForceUpdate();

        /// <summary>
        /// Запуск сервиса
        /// </summary>
        void Start();

        /// <summary>
        /// Остановка сервиса
        /// </summary>
        void Stop();
    }
}