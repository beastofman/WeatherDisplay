using System;

namespace WeatherDomain
{
    public abstract class WeatherEntity
    {
        public ulong CityId { get; set; }
        public DateTime Date { get; set; }
        public DateTime MeasurementDateTime { get; set; }
    }
}