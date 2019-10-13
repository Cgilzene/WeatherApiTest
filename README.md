# OpenWeather Api Test
Testing the Content of a 5 day weather forcast using [OpenWeatherMap.org] (https://openweathermap.org/api) 

## Purpose 
Using Postman, the main purpose was to test the GET response from the OpenweatherMap Api to check the validity of the recived responses. 

## Built with
Visual studio C#

## Running the test
* Clone repository 
* Open WeatherAPI.sln
* Build the project
* Update NuGet packages
* Click on test and run the test.


## NuGet Packages Used
* RestSharp - A REST and HTTP API Client
* NUnit - Unit testing framework for all .NET languages with a TDD focus
* NUnitTestAdapter - An addapter for running unit tests in visiual studio
* NewtonsoftJson - A high-perofrmance JSON framework for .NET

## Classes
* WeatherService : Used to create instances of the data handling and http manager classes acting as an entrypoint for access. 
* WeahterDTO : Data Transfer Object used to pass data from the response received to the data model deserialse them.
* WeatherModel : Used to read and convert the data types received from the response.
* WeatherCallManager : Used to create the REST client and make a response to the Api, the returned response is then deserialised in the DTO
* App.config : Used to add the settings with a key representing each part of the Http address
* WeatherConfig : Translates the informating from App.config so its c# readable 
* Test : Returns test on data points e.g "wind" "speed" - Check the wind speed is an int

## Test
To view the responses recived from the API Postman was used to help with modeling the data.

#### JSON API Response Example Using Postman:
~~~JSON{
    "coord": {
        "lon": -0.13,
        "lat": 51.51
    },
    "weather": [
        {
            "id": 800,
            "main": "Clear",
            "description": "clear sky",
            "icon": "01n"
        }
    ],
    "base": "stations",
    "main": {
        "temp": 284.64,
        "pressure": 1008,
        "humidity": 76,
        "temp_min": 282.59,
        "temp_max": 287.04
    },
    "visibility": 10000,
    "wind": {
        "speed": 4.1,
        "deg": 240
    },
    "clouds": {
        "all": 0
    },
    "dt": 1570994416,
    "sys": {
        "type": 1,
        "id": 1412,
        "message": 0.0122,
        "country": "GB",
        "sunrise": 1570947612,
        "sunset": 1570986790
    },
    "timezone": 3600,
    "id": 2643743,
    "name": "London",
    "cod": 200
}
~~~
###Exaples of a few tests performed:

**Headers**
- Content-Type - Check that it is a JSON Format
- Server - Check that it is openresty

**NotNull**
- timezone - can't be null
- id - can't be null
- name - can't be null
- dt - can't be null

**Greater than zero**
- main - speed - must be greater than 0

# Reflection



