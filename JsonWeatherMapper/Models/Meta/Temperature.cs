using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public class OwmForecastTemperature
    {
        [DataMember(Name = "day", IsRequired = false)]
        public double? Day { get; set; }

        [DataMember(Name = "eve", IsRequired = false)]
        public double? Evening { get; set; }

        [DataMember(Name = "max", IsRequired = false)]
        public double? Maximum { get; set; }

        [DataMember(Name = "min", IsRequired = false)]
        public double? Minimum { get; set; }

        [DataMember(Name = "morn", IsRequired = false)]
        public double? Morning { get; set; }

        [DataMember(Name = "night", IsRequired = false)]
        public double? Night { get; set; }
    }
}