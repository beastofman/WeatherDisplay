namespace WeatherDomain
{
    public class Forecast : WeatherEntity
    {
        public double TemperatureDay { get; set; }
        public double TemperatureEvening { get; set; }
        public double TemperatureMorning { get; set; }
        public double TemperatureNight { get; set; }

        override public string ToString()
        {
            return string.Format("Дата: {0:d} Утром: {1:N2} Днем: {2:N2} Вечером: {3:N2} Ночью: {4:N2} Прогноз получен {5:d} в {5:T}",
                this.Date,
                this.TemperatureMorning,
                this.TemperatureDay,
                this.TemperatureEvening,
                this.TemperatureNight,
                this.MeasurementDateTime.ToLocalTime()
                );
        }
    }
}