using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WeatherAPI.Weather_Service.Data_Handling;
using WeatherAPI.Weather_Service.HTTP_Manager;

namespace WeatherAPI.Weather_Service
{
    class WeatherService
    {
        // we need call Manager
        public WeatherCallManager weatherCallManager = new WeatherCallManager();
        // we need DTO
        public WeatherDTO weatherDTO = new WeatherDTO();
        // we need JobObject
        public JObject weatherInfo;

        public WeatherService() // Constructor
        {
            weatherDTO.DeserializeClouds(weatherCallManager.GetLatestWeather());
            weatherInfo = JObject.Parse(weatherCallManager.GetLatestWeather());
        }
    }

    
        
}
