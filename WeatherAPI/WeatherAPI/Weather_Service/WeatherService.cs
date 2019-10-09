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
        public JObject weatherInfoJson;

        public WeatherService() // Constructor
        {
            weatherDTO.DeserializeWeatherModel(weatherCallManager.GetLatestWeather());
            weatherInfoJson = JObject.Parse(weatherCallManager.GetLatestWeather());
        }

        public int GetTotalCoord()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["coord"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalWeather()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["weather"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalMain()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["main"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalWind()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["wind"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalRain()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["rain"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalSys()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["sys"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalCloud()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["clouds"])
            {
                count += 1;
            }
            return count;
        }
    }

    
        
}
