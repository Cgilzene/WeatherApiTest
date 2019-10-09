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
      /*  public string baseStatiion { get; set; }
        public int visibility { get; set; }
        public int dt { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public int cod { get; set; }


        public Coord coord { get; set; }
        public Clouds clouds { get; set; }
        public Sys sys { get; set;}
        public Rain rain { get; set; }
        public Wind wind { get; set; }
        public Main main { get; set; }
        public Weather weather { get; set; }
            
        public void DeserializeCoord(string coordResponse)
        {
            coord = JsonConvert.DeserializeObject<Coord>(coordResponse);
        }

        public void DeserializeClouds(string cloudsResponse)
        {
            clouds = JsonConvert.DeserializeObject<Clouds>(cloudsResponse);
        }
        public void DeserializeSys(string sysResponse)
        {
            sys = JsonConvert.DeserializeObject<Sys>(sysResponse);
        }

        public void DeserializeRain(string rainResponse)
        {
            rain = JsonConvert.DeserializeObject<Rain>(rainResponse);
        }

        public void DeserializeWind(string windResponse)
        {
            wind = JsonConvert.DeserializeObject<Wind>(windResponse);
        }

        public void DeserializeMain(string mainResponse)
        {
            main = JsonConvert.DeserializeObject<Main>(mainResponse);
        }

        public void DeserializeWeather(string weatherResponse)
        {
            weather = JsonConvert.DeserializeObject<Weather>(weatherResponse);
        }
        */


        public WeatherModel weatherModel { get; set; }

        public void DeserializeWeatherModel(string WeatherModelResponse)
        {
            weatherModel = JsonConvert.DeserializeObject<WeatherModel>(WeatherModelResponse);
        }


    }
}
