using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAPI.Weather_Service.Data_Handling
{
    public class WeatherDTO
    {
      
        public WeatherModel weatherModel { get; set; }

        public void DeserializeWeatherModel(string WeatherModelResponse)
        {
            weatherModel = JsonConvert.DeserializeObject<WeatherModel>(WeatherModelResponse);
        }


    }
}
