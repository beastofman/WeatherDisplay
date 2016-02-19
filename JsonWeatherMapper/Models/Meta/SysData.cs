using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmSysData
    {
        [DataMember(Name = "country", IsRequired = true)]
        public string Country { get; set; }

        [DataMember(Name = "message", IsRequired = true)]
        public double? Message { get; set; }

        [DataMember(Name = "sunrise", IsRequired = true)]
        public long? UnixSunrise { get; set; }

        [DataMember(Name = "sunset", IsRequired = true)]
        public long? UnixSunset { get; set; }
    }
}