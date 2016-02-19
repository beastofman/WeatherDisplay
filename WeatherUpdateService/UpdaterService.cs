using NLog;
using System;
using System.Timers;
using WeatherDomain;

namespace WeatherUpdateService
{
    public class UpdaterService : IUpdaterService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly ulong m_cityId;
        private readonly uint m_daysCount;
        private readonly IWeatherFetcherService m_fetcher;
        private Timer m_timer;
        private uint m_updateInterval;

        public UpdaterService(IWeatherFetcherService fetcherService, ulong cityId = 524901, uint daysCount = 4)
        {
            if (fetcherService == null) throw new ArgumentNullException("fetcherService");
            this.m_fetcher = fetcherService;
            this.m_daysCount = daysCount;
            this.m_cityId = cityId;
            /*
             * Интервал по умолчанию - 10800 секунд (3 часа)
             */
            this.UpdateInterval = 10800;
        }

        public uint UpdateInterval
        {
            get { return this.m_updateInterval; }
            set { this.m_updateInterval = value * 1000; }
        }

        public void ForceUpdate()
        {
            this.Update();
        }

        public void Start()
        {
            if (this.m_timer == null)
            {
                this.m_timer = new Timer();
                this.m_timer.Elapsed += (sender, args) =>
                                        {
                                            this.Update();
                                        };
                this.Update();
            }
            else
            {
                this.m_timer.Stop();
            }

            this.m_timer.Interval = this.UpdateInterval;
            this.m_timer.Start();
        }

        public void Stop()
        {
            if (this.m_timer != null)
            {
                this.m_timer.Stop();
            }
        }

        private void Update()
        {
            try
            {
                this.m_fetcher.FetchForecast(this.m_cityId, this.m_daysCount);
                this.m_fetcher.FetchWeather(this.m_cityId);
            }
            catch (Exception ex)
            {
                logger.Error("{0}", ex.ToString());
            }
        }
    }
}