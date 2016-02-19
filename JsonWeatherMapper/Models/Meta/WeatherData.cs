using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmWeatherData
    {
        [DataMember(Name = "description", IsRequired = true)]
        public string Description { get; set; }

        [DataMember(Name = "icon", IsRequired = true)]
        public string Icon { get; set; }

        [DataMember(Name = "id", IsRequired = true)]
        public long? Id { get; set; }

        [DataMember(Name = "main", IsRequired = true)]
        public string Main { get; set; }
    }
}