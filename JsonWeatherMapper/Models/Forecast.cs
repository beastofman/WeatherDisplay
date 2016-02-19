using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmCityForecast : OwmResponse
    {
        [DataMember(Name = "city", IsRequired = false)]
        public OwmCity City { get; set; }

        [DataMember(Name = "cnt", IsRequired = false)]
        public int? Count { get; set; }

        [DataMember(Name = "list", IsRequired = false)]
        public OwmForecast[] Forecast { get; set; }
    }
}