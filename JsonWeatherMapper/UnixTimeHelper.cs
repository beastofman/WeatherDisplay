using System;

namespace OpenWeatherMapJsonMapper
{
    internal static class UnixTimeHelper
    {
        public static DateTime FromUnixTimestamp(long timestamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestamp);
        }
    }
}