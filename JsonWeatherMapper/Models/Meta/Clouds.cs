using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmClouds
    {
        [DataMember(Name = "all", IsRequired = true)]
        public int? All { get; set; }
    }
}