﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

[assembly: EdmSchema()]
namespace SqlDataAccess
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WeatherModelContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WeatherModelContext object using the connection string found in the 'WeatherModelContext' section of the application configuration file.
        /// </summary>
        public WeatherModelContext() : base("name=WeatherModelContext", "WeatherModelContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WeatherModelContext object.
        /// </summary>
        public WeatherModelContext(string connectionString) : base(connectionString, "WeatherModelContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WeatherModelContext object.
        /// </summary>
        public WeatherModelContext(EntityConnection connection) : base(connection, "WeatherModelContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Forecast> Forecast
        {
            get
            {
                if ((_Forecast == null))
                {
                    _Forecast = base.CreateObjectSet<Forecast>("Forecast");
                }
                return _Forecast;
            }
        }
        private ObjectSet<Forecast> _Forecast;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Weather> Weather
        {
            get
            {
                if ((_Weather == null))
                {
                    _Weather = base.CreateObjectSet<Weather>("Weather");
                }
                return _Weather;
            }
        }
        private ObjectSet<Weather> _Weather;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Forecast EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToForecast(Forecast forecast)
        {
            base.AddObject("Forecast", forecast);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Weather EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWeather(Weather weather)
        {
            base.AddObject("Weather", weather);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="WeatherModel", Name="Forecast")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Forecast : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Forecast object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="forecastDate">Initial value of the ForecastDate property.</param>
        /// <param name="measurement">Initial value of the Measurement property.</param>
        /// <param name="temperatureDay">Initial value of the TemperatureDay property.</param>
        /// <param name="temperatureEvening">Initial value of the TemperatureEvening property.</param>
        /// <param name="temperatureMorning">Initial value of the TemperatureMorning property.</param>
        /// <param name="temperatureNight">Initial value of the TemperatureNight property.</param>
        /// <param name="cityId">Initial value of the CityId property.</param>
        public static Forecast CreateForecast(Int32 id, DateTime forecastDate, DateTime measurement, Double temperatureDay, Double temperatureEvening, Double temperatureMorning, Double temperatureNight, Int64 cityId)
        {
            Forecast forecast = new Forecast();
            forecast.Id = id;
            forecast.ForecastDate = forecastDate;
            forecast.Measurement = measurement;
            forecast.TemperatureDay = temperatureDay;
            forecast.TemperatureEvening = temperatureEvening;
            forecast.TemperatureMorning = temperatureMorning;
            forecast.TemperatureNight = temperatureNight;
            forecast.CityId = cityId;
            return forecast;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private Int32 _Id;
        partial void OnIdChanging(Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public DateTime ForecastDate
        {
            get
            {
                return _ForecastDate;
            }
            set
            {
                OnForecastDateChanging(value);
                ReportPropertyChanging("ForecastDate");
                _ForecastDate = SetValidValue(value, "ForecastDate");
                ReportPropertyChanged("ForecastDate");
                OnForecastDateChanged();
            }
        }
        private DateTime _ForecastDate;
        partial void OnForecastDateChanging(DateTime value);
        partial void OnForecastDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public DateTime Measurement
        {
            get
            {
                return _Measurement;
            }
            set
            {
                OnMeasurementChanging(value);
                ReportPropertyChanging("Measurement");
                _Measurement = SetValidValue(value, "Measurement");
                ReportPropertyChanged("Measurement");
                OnMeasurementChanged();
            }
        }
        private DateTime _Measurement;
        partial void OnMeasurementChanging(DateTime value);
        partial void OnMeasurementChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public Double TemperatureDay
        {
            get
            {
                return _TemperatureDay;
            }
            set
            {
                OnTemperatureDayChanging(value);
                ReportPropertyChanging("TemperatureDay");
                _TemperatureDay = SetValidValue(value, "TemperatureDay");
                ReportPropertyChanged("TemperatureDay");
                OnTemperatureDayChanged();
            }
        }
        private Double _TemperatureDay;
        partial void OnTemperatureDayChanging(Double value);
        partial void OnTemperatureDayChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public Double TemperatureEvening
        {
            get
            {
                return _TemperatureEvening;
            }
            set
            {
                OnTemperatureEveningChanging(value);
                ReportPropertyChanging("TemperatureEvening");
                _TemperatureEvening = SetValidValue(value, "TemperatureEvening");
                ReportPropertyChanged("TemperatureEvening");
                OnTemperatureEveningChanged();
            }
        }
        private Double _TemperatureEvening;
        partial void OnTemperatureEveningChanging(Double value);
        partial void OnTemperatureEveningChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public Double TemperatureMorning
        {
            get
            {
                return _TemperatureMorning;
            }
            set
            {
                OnTemperatureMorningChanging(value);
                ReportPropertyChanging("TemperatureMorning");
                _TemperatureMorning = SetValidValue(value, "TemperatureMorning");
                ReportPropertyChanged("TemperatureMorning");
                OnTemperatureMorningChanged();
            }
        }
        private Double _TemperatureMorning;
        partial void OnTemperatureMorningChanging(Double value);
        partial void OnTemperatureMorningChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public Double TemperatureNight
        {
            get
            {
                return _TemperatureNight;
            }
            set
            {
                OnTemperatureNightChanging(value);
                ReportPropertyChanging("TemperatureNight");
                _TemperatureNight = SetValidValue(value, "TemperatureNight");
                ReportPropertyChanged("TemperatureNight");
                OnTemperatureNightChanged();
            }
        }
        private Double _TemperatureNight;
        partial void OnTemperatureNightChanging(Double value);
        partial void OnTemperatureNightChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public Int64 CityId
        {
            get
            {
                return _CityId;
            }
            set
            {
                OnCityIdChanging(value);
                ReportPropertyChanging("CityId");
                _CityId = SetValidValue(value, "CityId");
                ReportPropertyChanged("CityId");
                OnCityIdChanged();
            }
        }
        private Int64 _CityId;
        partial void OnCityIdChanging(Int64 value);
        partial void OnCityIdChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="WeatherModel", Name="Weather")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Weather : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Weather object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="weatherDate">Initial value of the WeatherDate property.</param>
        /// <param name="weatherTime">Initial value of the WeatherTime property.</param>
        /// <param name="measurement">Initial value of the Measurement property.</param>
        /// <param name="temperature">Initial value of the Temperature property.</param>
        /// <param name="cityId">Initial value of the CityId property.</param>
        public static Weather CreateWeather(Int32 id, DateTime weatherDate, TimeSpan weatherTime, DateTime measurement, Double temperature, Int64 cityId)
        {
            Weather weather = new Weather();
            weather.Id = id;
            weather.WeatherDate = weatherDate;
            weather.WeatherTime = weatherTime;
            weather.Measurement = measurement;
            weather.Temperature = temperature;
            weather.CityId = cityId;
            return weather;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private Int32 _Id;
        partial void OnIdChanging(Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public DateTime WeatherDate
        {
            get
            {
                return _WeatherDate;
            }
            set
            {
                OnWeatherDateChanging(value);
                ReportPropertyChanging("WeatherDate");
                _WeatherDate = SetValidValue(value, "WeatherDate");
                ReportPropertyChanged("WeatherDate");
                OnWeatherDateChanged();
            }
        }
        private DateTime _WeatherDate;
        partial void OnWeatherDateChanging(DateTime value);
        partial void OnWeatherDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public TimeSpan WeatherTime
        {
            get
            {
                return _WeatherTime;
            }
            set
            {
                OnWeatherTimeChanging(value);
                ReportPropertyChanging("WeatherTime");
                _WeatherTime = SetValidValue(value, "WeatherTime");
                ReportPropertyChanged("WeatherTime");
                OnWeatherTimeChanged();
            }
        }
        private TimeSpan _WeatherTime;
        partial void OnWeatherTimeChanging(TimeSpan value);
        partial void OnWeatherTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public DateTime Measurement
        {
            get
            {
                return _Measurement;
            }
            set
            {
                OnMeasurementChanging(value);
                ReportPropertyChanging("Measurement");
                _Measurement = SetValidValue(value, "Measurement");
                ReportPropertyChanged("Measurement");
                OnMeasurementChanged();
            }
        }
        private DateTime _Measurement;
        partial void OnMeasurementChanging(DateTime value);
        partial void OnMeasurementChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public Double Temperature
        {
            get
            {
                return _Temperature;
            }
            set
            {
                OnTemperatureChanging(value);
                ReportPropertyChanging("Temperature");
                _Temperature = SetValidValue(value, "Temperature");
                ReportPropertyChanged("Temperature");
                OnTemperatureChanged();
            }
        }
        private Double _Temperature;
        partial void OnTemperatureChanging(Double value);
        partial void OnTemperatureChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<Double> Cloudness
        {
            get
            {
                return _Cloudness;
            }
            set
            {
                OnCloudnessChanging(value);
                ReportPropertyChanging("Cloudness");
                _Cloudness = SetValidValue(value, "Cloudness");
                ReportPropertyChanged("Cloudness");
                OnCloudnessChanged();
            }
        }
        private Nullable<Double> _Cloudness;
        partial void OnCloudnessChanging(Nullable<Double> value);
        partial void OnCloudnessChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<Double> Humidity
        {
            get
            {
                return _Humidity;
            }
            set
            {
                OnHumidityChanging(value);
                ReportPropertyChanging("Humidity");
                _Humidity = SetValidValue(value, "Humidity");
                ReportPropertyChanged("Humidity");
                OnHumidityChanged();
            }
        }
        private Nullable<Double> _Humidity;
        partial void OnHumidityChanging(Nullable<Double> value);
        partial void OnHumidityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<Double> Pressure
        {
            get
            {
                return _Pressure;
            }
            set
            {
                OnPressureChanging(value);
                ReportPropertyChanging("Pressure");
                _Pressure = SetValidValue(value, "Pressure");
                ReportPropertyChanged("Pressure");
                OnPressureChanged();
            }
        }
        private Nullable<Double> _Pressure;
        partial void OnPressureChanging(Nullable<Double> value);
        partial void OnPressureChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<DateTime> Sunrise
        {
            get
            {
                return _Sunrise;
            }
            set
            {
                OnSunriseChanging(value);
                ReportPropertyChanging("Sunrise");
                _Sunrise = SetValidValue(value, "Sunrise");
                ReportPropertyChanged("Sunrise");
                OnSunriseChanged();
            }
        }
        private Nullable<DateTime> _Sunrise;
        partial void OnSunriseChanging(Nullable<DateTime> value);
        partial void OnSunriseChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<DateTime> Sunset
        {
            get
            {
                return _Sunset;
            }
            set
            {
                OnSunsetChanging(value);
                ReportPropertyChanging("Sunset");
                _Sunset = SetValidValue(value, "Sunset");
                ReportPropertyChanged("Sunset");
                OnSunsetChanged();
            }
        }
        private Nullable<DateTime> _Sunset;
        partial void OnSunsetChanging(Nullable<DateTime> value);
        partial void OnSunsetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<Double> WindDirection
        {
            get
            {
                return _WindDirection;
            }
            set
            {
                OnWindDirectionChanging(value);
                ReportPropertyChanging("WindDirection");
                _WindDirection = SetValidValue(value, "WindDirection");
                ReportPropertyChanged("WindDirection");
                OnWindDirectionChanged();
            }
        }
        private Nullable<Double> _WindDirection;
        partial void OnWindDirectionChanging(Nullable<Double> value);
        partial void OnWindDirectionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<Double> WindSpeed
        {
            get
            {
                return _WindSpeed;
            }
            set
            {
                OnWindSpeedChanging(value);
                ReportPropertyChanging("WindSpeed");
                _WindSpeed = SetValidValue(value, "WindSpeed");
                ReportPropertyChanged("WindSpeed");
                OnWindSpeedChanged();
            }
        }
        private Nullable<Double> _WindSpeed;
        partial void OnWindSpeedChanging(Nullable<Double> value);
        partial void OnWindSpeedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public String Condition
        {
            get
            {
                return _Condition;
            }
            set
            {
                OnConditionChanging(value);
                ReportPropertyChanging("Condition");
                _Condition = SetValidValue(value, true, "Condition");
                ReportPropertyChanged("Condition");
                OnConditionChanged();
            }
        }
        private String _Condition;
        partial void OnConditionChanging(String value);
        partial void OnConditionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public Int64 CityId
        {
            get
            {
                return _CityId;
            }
            set
            {
                OnCityIdChanging(value);
                ReportPropertyChanging("CityId");
                _CityId = SetValidValue(value, "CityId");
                ReportPropertyChanged("CityId");
                OnCityIdChanged();
            }
        }
        private Int64 _CityId;
        partial void OnCityIdChanging(Int64 value);
        partial void OnCityIdChanged();

        #endregion

    }

    #endregion

}
