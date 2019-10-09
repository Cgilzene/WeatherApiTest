using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeatherAPI.Weather_Service;
using WeatherAPI.Weather_Service.HTTP_Manager;

namespace WeatherAPI.Tests
{
    [TestFixture]
    public class WeatherTests
    {
        private WeatherService weatherService = new WeatherService();
        private WeatherCallManager weatherCallManager = new WeatherCallManager();

        [Test]
        public void coord_Lat_Check()
        {
            Assert.Greater(weatherService.weatherDTO.weatherModel.coord.lat, 50.55);
        }

        [Test]
        public void Location_Name_Check()
        {
            Assert.AreEqual("London", weatherService.weatherDTO.weatherModel.name);
        }

        [Test]
        public void wind_Speed_Check()
        {
            Assert.AreEqual(weatherService.weatherDTO.weatherModel.wind.speed, 9.3);
        }

        [Test]
        public void base_Check()
        {
            Assert.AreEqual("stations",weatherService.weatherDTO.weatherModel.@base);
        }

        [Test]
        public void main_Info_Pressure_Check()
        {
            Assert.AreEqual(1004, weatherService.weatherDTO.weatherModel.main.pressure);
        }

        [Test]
        public void dt_Check()
        {
            Assert.AreEqual(1570628042, weatherService.weatherDTO.weatherModel.dt);
        }

        [Test]
        public void cloud_All_Check()
        {
            Assert.AreEqual(40, weatherService.weatherDTO.weatherModel.clouds.all);
        }

        [Test]
        public void sys_Country_Check()
        {
            Assert.AreEqual("GB", weatherService.weatherDTO.weatherModel.sys.country);
        }

        [Test]
        public void timeZone_Check()
        {
            Assert.AreEqual(3600, weatherService.weatherDTO.weatherModel.timezone);
        }

        [Test]
        public void id_Check()
        {
            Assert.AreEqual(2643743, weatherService.weatherDTO.weatherModel.id);
        }

        [Test]
        public void cod_Check()
        {
            Assert.AreEqual(200, weatherService.weatherDTO.weatherModel.cod);
        }

        [Test]
        public void weather_Check()
        {
            Assert.AreEqual("scatterred clouds", weatherService.weatherDTO.weatherModel.weather[0].description);
        }

        [Test]
        public void visibility_Check()
        {
            Assert.AreEqual(10000, weatherService.weatherDTO.weatherModel.visibility);
        }

        [Test]
        public void id_TypeNull_Check()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.id);
        }

        [Test]
        public void timezone_TypeNull_Check()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.timezone);
        }

        [Test]
        public void name_TypeNull_Check()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.name);
        }

        [Test]
        public void visibility_TypeNull_Check()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.weather);
        }

        [Test]
        public void total_In_Coord()
        {
            Assert.AreEqual(2, weatherService.GetTotalInCoord());
        }

        [Test]
        public void total_Sys()
        {
            Assert.AreEqual(6, weatherService.GetTotalInSys());
        }

        [Test]
        public void total_In_Clouds()
        {
            Assert.AreEqual(1, weatherService.GetTotalInCloud());
        }

        [Test]
        public void total_In_Rain()
        {
            Assert.AreEqual(1, weatherService.GetTotalInRain());
        }

        [Test]
        public void total_In_Wind()
        {
            Assert.AreEqual(2, weatherService.GetTotalInWind());
        }

        [Test]
        public void total_in_Main()
        {
            Assert.AreEqual(5, weatherService.GetTotalInMain());
        }

       

        [Test]
        public void test_VarType_For_Id()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.id);

        }

        [Test]
        public void test_VarType_For_Coord_Lat_Lon()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.coord.lat);
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.coord.lon);

        }

        [Test]
        public void test_VarType_For_Weather()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.weather[0].id);
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.weather[0].main);
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.weather[0].description);
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.weather[0].icon);
        }

        [Test]
        public void test_VarType_For_Base()
        {
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.@base);
        }

        [Test]
        public void test_VarType_For_Main()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.main.temp);
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.main.pressure);
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.main.humidity);
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.main.temp_max);
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.main.temp_min);
        }

        [Test]
        public void test_VarType_Wind()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.wind.speed);
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.wind.deg);
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.wind.gust);

        }

        [Test]
        public void test_VarType_Cloud()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.clouds.all);
        }

        [Test]
        public void test_VarType_Dt()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.dt);
        }

        [Test]
        public void test_VarType_Sys()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.sys.type);
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.sys.id);
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.sys.message);
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.sys.country);
            Assert.IsInstanceOf(typeof(Int32), weatherService.weatherDTO.weatherModel.sys.sunset);
            Assert.IsInstanceOf(typeof(Int32), weatherService.weatherDTO.weatherModel.sys.sunrise);
        }

        [Test]
        public void test_VarType_timezone()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.timezone);
        }
        [Test]
        public void test_VarType_Name()
        {
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.name);
        }
        [Test]
        public void test_VarType_Cod()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.cod);
        }

       
    }
}
