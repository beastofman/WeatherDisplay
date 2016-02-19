namespace SqlDataAccess
{
    public partial class Forecast
    {
        public static Forecast ToForecast(WeatherDomain.Forecast source)
        {
            return new Forecast
            {
                Measurement = source.MeasurementDateTime,
                ForecastDate = source.Date.Date,
                TemperatureDay = source.TemperatureDay,
                TemperatureEvening = source.TemperatureEvening,
                TemperatureNight = source.TemperatureNight,
                TemperatureMorning = source.TemperatureMorning,
                CityId = (long)source.CityId
            };
        }

        public WeatherDomain.Forecast ToDomainForecast()
        {
            return new WeatherDomain.Forecast
            {
                MeasurementDateTime = this.Measurement,
                Date = this.ForecastDate.Date,
                TemperatureMorning = this.TemperatureMorning,
                TemperatureDay = this.TemperatureDay,
                TemperatureEvening = this.TemperatureEvening,
                TemperatureNight = this.TemperatureNight,
                CityId = (ulong)this.CityId
            };
        }
    }
}