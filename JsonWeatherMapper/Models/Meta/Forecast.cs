using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmForecast
    {
        [DataMember(Name = "humidity", IsRequired = false)]
        public double? Humidity { get; set; }

        [DataMember(Name = "pressure", IsRequired = false)]
        public double? Pressure { get; set; }

        [DataMember(Name = "temp", IsRequired = false)]
        public OwmForecastTemperature Temperature { get; set; }

        [DataMember(Name = "dt", IsRequired = false)]
        public long? UnixDateTime { get; set; }

        [DataMember(Name = "weather", IsRequired = false)]
        public OwmWeatherData[] WeatherData { get; set; }
    }
}