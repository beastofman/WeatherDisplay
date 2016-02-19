using System;
using System.Collections.Generic;
using System.ComponentModel;
using WeatherDomain;

namespace WeatherDisplay.Models
{
    public enum WeatherDayPart
    {
        Morning,
        Day,
        Evening,
        Night
    }

    public class WeatherViewModel
    {
        [DisplayName("Облачность")]
        public string Cloudness { get; set; }

        [DisplayName("Состояние")]
        public string Condition { get; set; }

        public WeatherDayPart DayPart { get; set; }

        [DisplayName("Влажность")]
        public string Humidity { get; set; }

        public bool IsEmpty { get; set; }

        [DisplayName("Атмосферное давление")]
        public string Pressure { get; set; }

        [DisplayName("Восход")]
        public string Sunrise { get; set; }

        [DisplayName("Закат")]
        public string Sunset { get; set; }

        [DisplayName("Температура")]
        public string Temperature { get; set; }

        [DisplayName("Направление ветра")]
        public string WindDirection { get; set; }

        [DisplayName("Скорость ветра")]
        public string WindSpeed { get; set; }

        public static List<WeatherViewModel> FromDayWeather(DayWeather source, DateTime now)
        {
            var result = new List<WeatherViewModel>
            {
                FromWeather(WeatherDayPart.Morning, source.Morning, now),
                FromWeather(WeatherDayPart.Day, source.Day, now),
                FromWeather(WeatherDayPart.Evening, source.Evening, now)
            };
            result.Insert(now.Hour < 4 ? 0 : 3, FromWeather(WeatherDayPart.Night, source.Night, now));
            return result;
        }

        public bool IsNow(DateTime now)
        {
            return (this.DayPart == WeatherDayPart.Morning && now.Hour >= 4 && now.Hour < 10) ||
                   (this.DayPart == WeatherDayPart.Day && now.Hour >= 10 && now.Hour < 16) ||
                   (this.DayPart == WeatherDayPart.Evening && now.Hour >= 16 && now.Hour < 22) ||
                   (this.DayPart == WeatherDayPart.Night && (now.Hour >= 22 || now.Hour < 4));
        }

        private static WeatherViewModel FromWeather(WeatherDayPart dayPart, Weather source, DateTime now)
        {
            const string noData = "Нет данных";
            var result = new WeatherViewModel
            {
                DayPart = dayPart,
                Condition = noData,
                Humidity = noData,
                Temperature = noData,
                WindDirection = noData,
                Cloudness = noData,
                WindSpeed = noData,
                Pressure = noData,
                Sunset = noData,
                Sunrise = noData,
                IsEmpty = true
            };

            if (source == null) return result;

            result.Humidity = source.Humidity.HasValue ? string.Format("{0:N0}%", source.Humidity.Value) : noData;
            result.Cloudness = source.Cloudness.HasValue ? string.Format("{0:N0}%", source.Cloudness.Value) : noData;
            result.Condition = source.Condition;
            result.Pressure = source.Pressure.HasValue ? string.Format("{0:N0} мм рт. ст.", source.Pressure.Value / 1.33322) : noData;
            result.Temperature = string.Format("{0:N2} °C", source.Temperature);
            result.WindDirection = source.WindDirection.HasValue ? ToWindDirection(source.WindDirection.Value) : noData;
            result.WindSpeed = source.WindDirection.HasValue ? string.Format("{0:N2} м/с", source.WindSpeed) : noData;
            result.IsEmpty = false;

            if (source.SunriseDateTime.HasValue)
            {
                result.Sunrise = ToStringTimeInterval(now, source.SunriseDateTime.Value);
            }

            if (source.SunsetDateTime.HasValue)
            {
                result.Sunset = ToStringTimeInterval(now, source.SunsetDateTime.Value);
            }
            return result;
        }

        private static string ToStringTimeInterval(DateTime now, DateTime target)
        {
            var diff = now > target ? now - target : target - now;
            return string.Format("{0:t}, {1} {2}{3}", target,
                target > now ? "через" : "был",
                diff.ToString("hh\\:mm\\:ss"),
                target > now ? string.Empty : " назад"
                );
        }

        private static string ToWindDirection(double degrees)
        {
            var index = (int)(degrees / 22.5);
            var directions = new[]
            {
                "Север",
                "Северо-Северо-Восток",
                "Северо-Восток",
                "Восток-Северо-Восток",
                "Восток",
                "Восток-Юго-Восток",
                "Юго-Восток",
                "Юго-Юго-Восток",
                "Юг",
                "Юго-Юго-Запад",
                "Юго-Запад",
                "Запад-Юго-Запад",
                "Запад",
                "Запад-Северо-Запад",
                "Северо-Запад",
                "Северо-Северо-Запад"
            };
            return directions[index];
        }
    }
}