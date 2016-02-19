using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using WeatherDomain;

namespace OpenWeatherMapJsonMapper
{
    public class JsonWeatherMapper : IWeatherMapper
    {
        public IEnumerable<Forecast> ToForecast(object source)
        {
            var src = CheckSource(source);
            var raw = JsonConvert.DeserializeObject<OwmCityForecast>(src);

            if (raw.ResponseCode == 200)
            {
                var result = new List<Forecast>();
                var now = DateTime.Now.ToUniversalTime();
                result.AddRange(raw.Forecast.Select(f => new Forecast
                {
                    MeasurementDateTime = now,
                    Date = f.UnixDateTime.HasValue ? UnixTimeHelper.FromUnixTimestamp(f.UnixDateTime.Value).ToLocalTime() : DateTime.MinValue,
                    TemperatureMorning = f.Temperature != null ? f.Temperature.Morning.GetValueOrDefault(double.NaN) : double.NaN,
                    TemperatureDay = f.Temperature != null ? f.Temperature.Day.GetValueOrDefault(double.NaN) : double.NaN,
                    TemperatureEvening = f.Temperature != null ? f.Temperature.Evening.GetValueOrDefault(double.NaN) : double.NaN,
                    TemperatureNight = f.Temperature != null ? f.Temperature.Night.GetValueOrDefault(double.NaN) : double.NaN,
                    CityId = (ulong)raw.City.Id.GetValueOrDefault(0)
                }));

                return result;
            }
            ThrowException(raw);
            return null;
        }

        public Weather ToWeather(object source)
        {
            var src = CheckSource(source);
            var raw = JsonConvert.DeserializeObject<OwmCityWeather>(src);

            if (raw.ResponseCode == 200)
                return new Weather
                {
                    Cloudness = raw.Clouds != null && raw.Clouds.All.HasValue ? raw.Clouds.All.Value : (int?)null,
                    Date = raw.UnixDateTime.HasValue ? UnixTimeHelper.FromUnixTimestamp(raw.UnixDateTime.Value).ToLocalTime() : DateTime.MinValue,
                    Humidity = raw.Main != null ? raw.Main.Humidity : null,
                    MeasurementDateTime = DateTime.Now.ToUniversalTime(),
                    Pressure = raw.Main != null ? raw.Main.Pressure : null,
                    SunriseDateTime = raw.Sys != null && raw.Sys.UnixSunrise.HasValue ? UnixTimeHelper.FromUnixTimestamp(raw.Sys.UnixSunrise.Value).ToLocalTime() : (DateTime?)null,
                    SunsetDateTime = raw.Sys != null && raw.Sys.UnixSunset.HasValue ? UnixTimeHelper.FromUnixTimestamp(raw.Sys.UnixSunset.Value).ToLocalTime() : (DateTime?)null,
                    Temperature = raw.Main != null && raw.Main.Temperature.HasValue ? raw.Main.Temperature.Value : double.NaN,
                    WindDirection = raw.Wind != null && raw.Wind.Degree.HasValue ? raw.Wind.Degree.Value : (double?)null,
                    WindSpeed = raw.Wind != null && raw.Wind.Speed.HasValue ? raw.Wind.Speed.Value : (double?)null,
                    Condition = raw.Weather.Length > 0 ? raw.Weather[0].Description : string.Empty,
                    CityId = (ulong)raw.Id.GetValueOrDefault(0)
                };
            ThrowException(raw);
            return null;
        }

        private static string CheckSource(object source)
        {
            var src = source.ToString();
            if (string.IsNullOrEmpty(src) || string.IsNullOrWhiteSpace(src)) throw new InvalidCastException();
            return src;
        }

        private static void ThrowException(OwmResponse response)
        {
            if (!string.IsNullOrEmpty(response.Message)) throw new Exception(string.Format("{0}: {1}", response.ResponseCode, response.Message));
            throw new Exception();
        }
    }
}