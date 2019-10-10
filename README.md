# WeatherApiTest
Testing the Content of a 5 day weather forcast using the OpenWeatherMap.org 

# Built with
Visual studio C#

# Packages Used
* RestSharp
* NUnit
* NUnitTestAdapter
* NewtonsoftJson

# Classes
* WeahterDTO : Data Transfer Object to use the Json Files and Deserialse them
* WeatherModel : Used to read and structure the data files
* WeatherCallManager : Used to connect the Api with connections strings
* App.config : Used to add the settings with a key representing each part of the Http address
* WeatherConfig : Translates the informating from App.config so its c# readable 
* Test : Returns test on data points e.g "wind" "speed" - Check the wind speed is an int

# Purpose
To get familiar with testing Api's using postman, working out diffrent methods of testing, experimenting with diffrent types of tests. 


