using WeatherDomain;

namespace WeatherDisplay.Models
{
    public class ForecastViewModel
    {
        public ForecastViewModel(Forecast source)
        {
            this.ForecastDate = string.Format("{0:dddd}, {0:D}", source.Date);
            this.TemperatureMorning = string.Format("{0:N2} °C", source.TemperatureMorning);
            this.TemperatureDay = string.Format("{0:N2} °C", source.TemperatureDay);
            this.TemperatureEvening = string.Format("{0:N2} °C", source.TemperatureEvening);
            this.TemperatureNight = string.Format("{0:N2} °C", source.TemperatureNight);
        }

        public string ForecastDate { get; set; }
        public string TemperatureDay { get; set; }
        public string TemperatureEvening { get; set; }
        public string TemperatureMorning { get; set; }
        public string TemperatureNight { get; set; }
    }
}