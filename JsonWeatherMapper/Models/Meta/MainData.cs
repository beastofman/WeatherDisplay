using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmMainData
    {
        [DataMember(Name = "grnd_level", IsRequired = false)]
        public double? GroundLevel { get; set; }

        [DataMember(Name = "humidity", IsRequired = false)]
        public double? Humidity { get; set; }

        [DataMember(Name = "temp_max", IsRequired = false)]
        public double? MaxTemperature { get; set; }

        [DataMember(Name = "temp_min", IsRequired = false)]
        public double? MinTemperature { get; set; }

        [DataMember(Name = "pressure", IsRequired = false)]
        public double? Pressure { get; set; }

        [DataMember(Name = "sea_level", IsRequired = false)]
        public double? SeaLevel { get; set; }

        [DataMember(Name = "temp", IsRequired = false)]
        public double? Temperature { get; set; }
    }
}