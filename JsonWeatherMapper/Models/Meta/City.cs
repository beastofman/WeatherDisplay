using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmCity
    {
        [DataMember(Name = "coord", IsRequired = false)]
        public OwmCoordinates Coordinates { get; set; }

        [DataMember(Name = "country", IsRequired = false)]
        public string Country { get; set; }

        [DataMember(Name = "id", IsRequired = false)]
        public long? Id { get; set; }

        [DataMember(Name = "name", IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "population", IsRequired = false)]
        public int? Population { get; set; }
    }
}