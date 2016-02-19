using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmCoordinates
    {
        [DataMember(Name = "lat", IsRequired = true)]
        public double? Latitude { get; set; }

        [DataMember(Name = "lon", IsRequired = true)]
        public double? Longitude { get; set; }
    }
}