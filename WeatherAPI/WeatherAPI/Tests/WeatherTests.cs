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
        p
    }
}
