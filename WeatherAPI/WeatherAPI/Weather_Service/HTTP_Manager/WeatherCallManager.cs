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
        public string ContentType = " ";
        public string Server = " ";

        public WeatherCallManager()
        {
            
            client = new RestClient(WeatherConfig.BaseUrl);
      
        }
        
        // Making a connection
        public string GetLatestWeatherInfo()
        {
            //using a connection string 
            var request = new RestRequest("/data/2.5/weather" + WeatherConfig.ApiUrlMod + "&" + WeatherConfig.ApiKey);
            var response = client.Execute(request, Method.GET);
            ContentType = response.ContentType.ToString();
            Server = response.Server.ToString();
            
            return response.Content;
           
        }
    }
}
