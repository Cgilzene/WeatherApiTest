using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace WeatherAPI.Weather_Service.HTTP_Manager
{
    class WeatherCallManager
    {
        readonly IRestClient client;

        public WeatherCallManager()
        {
            client = new RestClient();
        }

        public string GetLatestWeather()
        {
            var request = new RestRequest();
            var respone = client.Execute(request, Method.Get);
            return response.Content;
        }
    }
}
