using System.Runtime.Serialization;

namespace OpenWeatherMapJsonMapper
{
    [DataContract]
    public abstract class OwmResponse
    {
        [DataMember(Name = "message", IsRequired = false)]
        public string Message { get; set; }

        [DataMember(Name = "cod", IsRequired = true)]
        public int ResponseCode { get; set; }
    }
}