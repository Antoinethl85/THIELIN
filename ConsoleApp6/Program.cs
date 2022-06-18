using System;
using ConsoleApp6.API;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Api tp2 = new Api();
            
            //Question 1
            Console.WriteLine("What's the weather like in Morocco ?");
            Coordonates Morocco = new Coordonates(	33.9715904f, -6.8498129f);
            Root weatherMorocco = tp2.GetWeather(Morocco);
            Console.WriteLine($"The weather in Morocco is {weatherMorocco.current.weather[0].description} \n");

            //Question 2
            Console.WriteLine("When will the sun rise and set today in Oslo?");
            Coordonates Oslo = new Coordonates(59.9138688f, 10.7522454f);
            Root sunRiseOslo = tp2.GetWeather(Oslo);
            Console.WriteLine($"The sun rise in Oslo is at {sunRiseOslo.current.sunrise} and the sun set is at {sunRiseOslo.current.sunset} Kelvin \n");
            
            //Question 3
            Console.WriteLine("What’s the temperature in Jakarta?");
            Coordonates Jakarta = new Coordonates(-6.2087634f, 106.845599f);
            Root temperatureJakarta = tp2.GetWeather(Jakarta);
            Console.WriteLine($"The temperature in Jakarta is {temperatureJakarta.current.temp - 273} °C\n");
            
            //Question 4
            Console.WriteLine("Where is it more windy, New-York, Tokyo or Paris?");
            Coordonates NY = new Coordonates(40.712784f, -74.005941f);
            Root windNY = tp2.GetWeather(NY);
            Coordonates Tokyo = new Coordonates(35.709026f, 139.731992f);
            Root windTokyo = tp2.GetWeather(Tokyo);
            Coordonates Paris = new Coordonates(48.856614f, 2.3522219f);
            Root windParis = tp2.GetWeather(Paris);

            double maxWind = windNY.current.wind_speed;
            if (maxWind < windParis.current.wind_speed)
            {
                if (windParis.current.wind_speed < windTokyo.current.wind_speed)
                {
                    Console.WriteLine($"It is more windy in Tokyo for {windTokyo.current.wind_speed * 3.6} km/h \n");
                }
                else
                {
                    Console.WriteLine($"It is more windy in Paris for {windParis.current.wind_speed * 3.6} km/h \n");
                }
            }
            else
            {
                if (maxWind < windTokyo.current.wind_speed)
                {
                    Console.WriteLine($"It is more windy in Tokyo for {windTokyo.current.wind_speed * 3.6} km/h \n");
                }
                else
                {
                    Console.WriteLine($"It is more windy in New York for {maxWind * 3.6} km/h \n");
                }
            }

            //Question 5
            Console.WriteLine("What is the humidity and pressure like in Kiev, Moscow and Berlin?");
            Coordonates Kiev = new Coordonates(4, 4);
            Coordonates Moscow = new Coordonates(4, 4);
            Coordonates Berlin = new Coordonates(4, 4);
            Root humidityBerlin = tp2.GetWeather(Berlin);
            Console.WriteLine();
            
        }
        
    }
}