using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmCityWeather : OwmResponse
    {
        [DataMember(Name = "base", IsRequired = false)]
        public string Base { get; set; }

        [DataMember(Name = "clouds", IsRequired = false)]
        public OwmClouds Clouds { get; set; }

        [DataMember(Name = "coord", IsRequired = false)]
        public OwmCoordinates Coordinates { get; set; }

        [DataMember(Name = "id", IsRequired = false)]
        public long? Id { get; set; }

        [DataMember(Name = "main", IsRequired = false)]
        public OwmMainData Main { get; set; }

        [DataMember(Name = "name", IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "sys", IsRequired = false)]
        public OwmSysData Sys { get; set; }

        [DataMember(Name = "dt", IsRequired = false)]
        public long? UnixDateTime { get; set; }

        [DataMember(Name = "weather", IsRequired = false)]
        public OwmWeatherData[] Weather { get; set; }

        [DataMember(Name = "wind", IsRequired = false)]
        public OwmWind Wind { get; set; }
    }
}