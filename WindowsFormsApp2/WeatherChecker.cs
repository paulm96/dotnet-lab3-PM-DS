using System;
using System.IO;
using System.Net;

namespace WindowsFormsApp2
{
    class WeatherChecker : ICondition
    {
        string city;
        string temperatureThreshold;

        public WeatherChecker(string _city, string _temperatureThreshold)
        {
            city = _city;
            temperatureThreshold = _temperatureThreshold;
        }

        public string City { get => city; set => city = value; }
        public string TemperatureThreshold { get => temperatureThreshold; set => temperatureThreshold = value; }

        public override string ToString()
        {
            return string.Format("{0},{1}",
                this.City, this.TemperatureThreshold);
        }

        public override bool Check()
        {
            var stream = new WebClient().DownloadString($"http://api.openweathermap.org/data/2.5/weather?q={city}&APPID=742070efe45d2e97d12202fbc91af4f7");
            var welcome = Welcome.FromJson(stream);
            var tempDouble = (welcome.Main.Temp - 273.15);
            var url = $"http://openweathermap.org/img/w/{welcome.Weather[0].Icon}.png";
            var com = welcome.Weather[0].Description;
            File.WriteAllText(@"./atturl.txt", url + "\r\n" + "Weather in " + city + ": " + com + ", temperature: " + Math.Round(tempDouble, 2).ToString() + "°C.");
            if (tempDouble <= Convert.ToDouble(TemperatureThreshold))
            {
                throw new ArgumentException("Condition wan not met for " + city + ", temp: " + temperatureThreshold, "arg");
            }

            return true;
        }
    }
}
