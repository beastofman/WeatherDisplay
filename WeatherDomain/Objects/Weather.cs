using System;

namespace WeatherDomain
{
    public class DayWeather
    {
        public DayWeather(DateTime dateTime)
        {
            this.DateTime = dateTime;
        }

        public DateTime DateTime { get; private set; }
        public Weather Day { get; set; }
        public Weather Evening { get; set; }
        public Weather Morning { get; set; }
        public Weather Night { get; set; }

        public Weather GetNow(DateTime dateTime)
        {
            switch (dateTime.Hour)
            {
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    return this.Morning;

                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    return this.Day;

                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                    return this.Evening;

                default:
                    return this.Night;
            }
        }

        override public string ToString()
        {
            var now = this.Night == this.GetNow(this.DateTime)
                ? this.Night
                : this.Morning == this.GetNow(this.DateTime)
                    ? this.Morning
                    : this.Day == this.GetNow(this.DateTime)
                        ? this.Day
                        : this.Evening;
            return string.Format("{4:dddd} {4:D}\n\tУтро:\t{0}\n\tДень:\t{1}\n\tВечер:\t{2}\n\tНочь:\t{3}\n\n\tСейчас:\t{5}",
                                 this.Morning == null ? "нет данных" : this.Morning.ToString(),
                                 this.Day == null ? "нет данных" : this.Day.ToString(),
                                 this.Evening == null ? "нет данных" : this.Evening.ToString(),
                                 this.Night == null ? "нет данных" : this.Night.ToString(),
                                 this.DateTime,
                                 now == null ? "нет данных" : now.ToString()
                );
        }
    }

    public class Weather : WeatherEntity
    {
        public double? Cloudness { get; set; }
        public string Condition { get; set; }
        public double? Humidity { get; set; }
        public double? Pressure { get; set; }
        public DateTime? SunriseDateTime { get; set; }
        public DateTime? SunsetDateTime { get; set; }
        public double Temperature { get; set; }
        public double? WindDirection { get; set; }
        public double? WindSpeed { get; set; }

        override public string ToString()
        {
            return string.Format("Температура: {0:N2} Данные получены {1:d} в {1:T}",
               this.Temperature,
               this.MeasurementDateTime.ToLocalTime()
               );
        }
    }
}