﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WeatherUpdateService.Properties {
    
    
    [CompilerGenerated()]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("2f42a2bd6e00bf0cc155caa1fc84032f")]
        public string API_Key {
            get {
                return ((string)(this["API_Key"]));
            }
            set {
                this["API_Key"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue(@"metadata=res://*/WeatherModel.csdl|res://*/WeatherModel.ssdl|res://*/WeatherModel.msl;provider=System.Data.SqlClient;provider connection string=""data source=localhost;initial catalog=WeatherDisplay;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework""")]
        public string DataConnection {
            get {
                return ((string)(this["DataConnection"]));
            }
            set {
                this["DataConnection"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("524901")]
        public ulong CityId {
            get {
                return ((ulong)(this["CityId"]));
            }
            set {
                this["CityId"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("4")]
        public uint DaysCount {
            get {
                return ((uint)(this["DaysCount"]));
            }
            set {
                this["DaysCount"] = value;
            }
        }
    }
}
