﻿using System;
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
            Assert.AreEqual(weatherService.weatherDTO.weatherModel.wind.speed, 9.3);
        }

        [Test]
        public void baseCheck()
        {
            Assert.AreEqual("stations",weatherService.weatherDTO.weatherModel.@base);
        }

        [Test]
        public void mainInfoPressureCheck()
        {
            Assert.AreEqual(1004, weatherService.weatherDTO.weatherModel.main.pressure);
        }

        [Test]
        public void dtCheck()
        {
            Assert.AreEqual(1570628042, weatherService.weatherDTO.weatherModel.dt);
        }

        [Test]
        public void cloudAllCheck()
        {
            Assert.AreEqual(40, weatherService.weatherDTO.weatherModel.clouds.all);
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
        public void idTypeNullCheck()
        {
            Assert.IsNotNull(weatherService.weatherDTO.weatherModel.id);
        }

        [Test]
        public void totaOptionsCoord()
        {
            Assert.AreEqual(2, weatherService.GetTotalCoord());
        }

        [Test]
        public void totalSys()
        {
            Assert.AreEqual(6, weatherService.GetTotalSys());
        }

        [Test]
        public void totaOptionsClouds()
        {
            Assert.AreEqual(1, weatherService.GetTotalCloud());
        }

        [Test]
        public void totaOptionsRain()
        {
            Assert.AreEqual(1, weatherService.GetTotalRain());
        }

        [Test]
        public void totaOptionswind()
        {
            Assert.AreEqual(2, weatherService.GetTotalWind());
        }

        [Test]
        public void totaOptionsMain()
        {
            Assert.AreEqual(5, weatherService.GetTotalMain());
        }

        [Test]
        public void testVarTypeForId()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.id);

        }

        [Test]
        public void testVarTypeForCoordLatLon()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.coord.lat);
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.coord.lon);

        }

        [Test]
        public void testVarTypeForWeather()
        {
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.weather[0].id);
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.weather[0].main);
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.weather[0].description);
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.weather[0].icon);
        }

        [Test]
        public void testVarTypeForBase()
        {
            Assert.IsInstanceOf(typeof(string), weatherService.weatherDTO.weatherModel.@base);
        }

        [Test]
        public void testVarTypeForMain()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.main.temp);
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.main.pressure);
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.main.humidity);
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.main.temp_max);
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.main.temp_min);
        }

        [Test]
        public void testVarTypeWind()
        {
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.wind.speed);
            Assert.IsInstanceOf(typeof(int), weatherService.weatherDTO.weatherModel.wind.deg);
            Assert.IsInstanceOf(typeof(double), weatherService.weatherDTO.weatherModel.wind.gust);

        }
    }
}
