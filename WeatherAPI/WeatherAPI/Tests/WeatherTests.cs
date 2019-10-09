using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeatherAPI.Weather_Service;

namespace WeatherAPI.Tests
{
    [TestFixture]
    public class WeatherTests
    {
        private WeatherService weatherService = new WeatherService();

        [Test]
        public void WebcallScheck()
        {
            Assert.Greater(weatherService.weatherDTO.weatherModel.coord.lat, 50.55);
        }

        [Test]
        public void LocationNameCheck()
        {
            Assert.AreEqual("London", weatherService.weatherDTO.weatherModel.name);
        }

        [Test]
        public void weatherSpeedCheck()
        {
            Assert.AreEqual(weatherService.weatherDTO.weatherModel.wind.speed, 9.3);
        }

        [Test]
        public void baseCheck()
        {
            Assert.AreEqual("stations",weatherService.weatherDTO.weatherModel.@base);
        }

        [Test]
        public void mainCheck()
        {
            Assert.AreEqual(1004, weatherService.weatherDTO.weatherModel.main.pressure);
        }

        [Test]
        public void dtCheck()
        {
            Assert.AreEqual(1570628042, weatherService.weatherDTO.weatherModel.dt);
        }

        [Test]
        public void cloudCheck()
        {
            Assert.AreEqual(40, weatherService.weatherDTO.weatherModel.clouds.all);
        }

        [Test]
        public void sysCheck()
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
    }
}
