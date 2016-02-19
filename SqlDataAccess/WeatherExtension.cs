namespace SqlDataAccess
{
    public partial class Weather
    {
        public static Weather ToWeather(WeatherDomain.Weather source)
        {
            return new Weather
            {
                Humidity = source.Humidity,
                Measurement = source.MeasurementDateTime,
                WeatherDate = source.Date,
                WindSpeed = source.WindSpeed,
                Temperature = source.Temperature,
                WindDirection = source.WindDirection,
                Pressure = source.Pressure,
                Cloudness = source.Cloudness,
                Sunrise = source.SunriseDateTime,
                Sunset = source.SunsetDateTime,
                Condition = source.Condition,
                WeatherTime = source.Date.TimeOfDay,
                CityId = (long)source.CityId
            };
        }

        public WeatherDomain.Weather ToDomainWeather()
        {
            return new WeatherDomain.Weather
            {
                MeasurementDateTime = this.Measurement,
                Date = this.WeatherDate.Date.Add(this.WeatherTime),
                Humidity = this.Humidity,
                WindSpeed = this.WindSpeed,
                Temperature = this.Temperature,
                WindDirection = this.WindDirection,
                Pressure = this.Pressure,
                Cloudness = this.Cloudness,
                SunriseDateTime = this.Sunrise,
                SunsetDateTime = this.Sunset,
                Condition = this.Condition,
                CityId = (ulong)this.CityId
            };
        }
    }
}