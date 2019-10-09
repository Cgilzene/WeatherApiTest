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
            weatherDTO.DeserializeWeatherModel(weatherCallManager.GetLatestWeatherInfo());
            weatherInfoJson = JObject.Parse(weatherCallManager.GetLatestWeatherInfo());
        }

        public int GetTotalInCoord()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["coord"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalInWeather()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["weather"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalInMain()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["main"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalInWind()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["wind"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalInRain()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["rain"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalInSys()
        {
            int count = 0;
            foreach (var item in weatherInfoJson["sys"])
            {
                count += 1;
            }
            return count;
        }

        public int GetTotalInCloud()
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
