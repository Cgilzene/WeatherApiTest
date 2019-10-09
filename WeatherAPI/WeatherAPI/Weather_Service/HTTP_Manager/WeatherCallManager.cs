using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WeatherAPI;


namespace WeatherAPI.Weather_Service.HTTP_Manager
{
    class WeatherCallManager
    {
        readonly IRestClient client;

        public WeatherCallManager()
        {
            client = new RestClient(WeatherConfig.BaseUrl);
        }

        public string GetLatestWeather()
        {
            var request = new RestRequest("/data/2.5/weather" + WeatherConfig.ApiUrlMod + WeatherConfig.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
