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
       

        [Test]
        public void coordLatCheck()
        {
            Assert.Greater(weatherService.weatherDTO.weatherModel.coord.lat, 50.55);
        }

        [Test]
        public void LocationNameCheck()
        {
            Assert.AreEqual("London", weatherService.weatherDTO.weatherModel.name);
        }

        [Test]
        public void windSpeedCheck()
        {
            Assert.AreEqual(weatherService.weatherDTO.weatherModel.wind.speed, 6.3);
        }

        [Test]
        public void baseCheck()
        {
            Assert.AreEqual("stations",weatherService.weatherDTO.weatherModel.@base);
        }

        [Test]
        public void mainInfoPressureCheck()
        {
            Assert.AreEqual(1005, weatherService.weatherDTO.weatherModel.main.pressure);
        }

        [Test]
        public void dtCheck()
        {
            Assert.AreEqual(1570628042, weatherService.weatherDTO.weatherModel.dt);
        }

        [Test]
        public void cloudAllCheck()
        {
            Assert.AreEqual(100, weatherService.weatherDTO.weatherModel.clouds.all);
        }

        [Test]
        public void sysCountryCheck()
        {
            Assert.AreEqual("GB", weatherService.weatherDTO.weatherModel.sys.country);
        }

        [Test]
        public void timeZoneCheck()
        {
            Assert.AreEqual(3600, weatherService.weatherDTO.weatherModel.timezone);
        }

        [Test]
        public void idCheck()
        {
            Assert.AreEqual(2643743, weatherService.weatherDTO.weatherModel.id);
        }

        [Test]
        public void codCheck()
        {
            Assert.AreEqual(200, weatherService.weatherDTO.weatherModel.cod);
        }

        [Test]
        public void weatherCheck()
        {
            Assert.AreEqual("scatterred clouds", weatherService.weatherDTO.weatherModel.weather[0].description);
        }

        [Test]
        public void visibilityCheck()
        {
            Assert.AreEqual(10000, weatherService.weatherDTO.weatherModel.visibility);
        }

        [Test]
        public void idTypeNullCheck()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.id);
        }

        [Test]
        public void timezoneTypeNullCheck()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.timezone);
        }

        [Test]
        public void nameTypeNullCheck()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.name);
        }

        [Test]
        public void visibilityTypeNullCheck()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.weather);
        }

        [Test]
        public void totalInCoord()
        {
            Assert.AreEqual(2, weatherService.GetTotalInCoord());
        }

        [Test]
        public void totalSys()
        {
            Assert.AreEqual(6, weatherService.GetTotalInSys());
        }

        [Test]
        public void totalInClouds()
        {
            Assert.AreEqual(1, weatherService.GetTotalInCloud());
        }

        [Test]
        public void totalInRain()
        {
            Assert.AreEqual(1, weatherService.GetTotalInRain());
        }

        [Test]
        public void totalInWind()
        {
            Assert.AreEqual(2, weatherService.GetTotalInWind());
        }

        [Test]
        public void totalInMain()
        {
            Assert.AreEqual(5, weatherService.GetTotalInMain());
        }

       

        [Test]
        public void testVarTypeForId()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.id);

        }

        [Test]
        public void testVarTypeForCoordLon()
        {

            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.coord.lon);
        }

        [Test]
        public void testVarTypeForCoordLat()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.coord.lat);

        }

        [Test]
        public void testVarTypeForWeatherId()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.weather[0].id);
        }

        [Test]
        public void testVarTypeForWeatherMain()
        {
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.weather[0].main);
           
        }

        [Test]
        public void testVarTypeForWeatherDescription()
        {
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.weather[0].description);
        }

        [Test]
        public void testVarTypeForWeatherIcon()
        {
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.weather[0].icon);
        }

        [Test]
        public void testVarTypeForBase()
        {
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.@base);
        }

        [Test]
        public void testVarTypeForTemp()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.main.temp);

        }

        [Test]
        public void testVarTypeForPressure()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.main.pressure);
        }

        [Test]
        public void testVarTypeForHumidity()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.main.humidity); 
        }

        [Test]
        public void testVarTypeForTempMax()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.main.temp_min);
        }

        [Test]
        public void testVarTypeFor()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.main.temp_min);
        }


        [Test]
        public void testVarTypeSpeed()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.wind.speed);
            

        }

        [Test]
        public void testVarTypeDeg()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.wind.deg);

        }

        [Test]
        public void testVarTypeGust()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.wind.gust);
        }

        

        [Test]
        public void testVarTypeCloud()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.clouds.all);
        }

        [Test]
        public void testVarTypeDt()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.dt);
        }

        [Test]
        public void testVarTypeSysType()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.sys.type);
            
        }

        [Test]
        public void testVarTypeSysId()
        {
            
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.sys.id);
            
        }

        [Test]
        public void testVarTypeSysMessage()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.sys.message);
        }

        [Test]
        public void testVarTypeSysCountry()
        {
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.sys.country);
        }

        [Test]
        public void testVarTypeSysSunset()
        {
            Assert.IsInstanceOf(typeof(Int32), weatherService.weatherDTO.weatherModel.sys.sunset);
        }

        [Test]
        public void testVarTypeSysSunrise()
        {
            Assert.IsInstanceOf(typeof(Int32), weatherService.weatherDTO.weatherModel.sys.sunrise);
        }

        [Test]
        public void testVarTypeTimezone()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.timezone);
        }
        [Test]
        public void testVarTypeName()
        {
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.name);
        }
        [Test]
        public void testVarTypeCod()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.cod);
        }

        [Test]
        public void ContentTypeCheck()
        {
            Assert.AreEqual("application/json; charset=utf-8",weatherService.weatherCallManager.ContentType);
        }


        [Test]
        public void ServerName()
        {
            Assert.AreEqual("openresty", weatherService.weatherCallManager.Server);
        }


        [Test]
        public void CoordNotlatNull()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.coord.lat);
        }


        [Test]
        public void CoordNotlonNull()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.coord.lon);
        }


        [Test]
        public void TempNotNull()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.main.temp);
        }


        [Test]
        public void PresureNotNull()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.main.pressure);
        }

        [Test]
        public void HumidityNotNull()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.main.humidity);
        }
        [Test]
        public void SpeedNotNull()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.wind.speed);
        }

        [Test]
        public void DegreeNotNull()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.wind.deg);
        }
    }
}
