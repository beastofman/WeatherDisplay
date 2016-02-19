using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmWind
    {
        [DataMember(Name = "deg", IsRequired = true)]
        public double? Degree { get; set; }

        [DataMember(Name = "speed", IsRequired = true)]
        public double? Speed { get; set; }
    }
}