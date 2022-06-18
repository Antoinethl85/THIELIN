using System;
using System.Collections.Generic;
using System.Net.Http;
using ConsoleApp6.API;
using Newtonsoft.Json;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Api tp2 = new Api();
            
            //Question 1
            Console.WriteLine("What's the weather like in Morocco ?");
            Coordonates Morocco = new Coordonates(39.099724f, -94.578331f);
            Root weatherMorocco = tp2.GetWeather(Morocco);
            Console.WriteLine($"The weather in Morocco is {weatherMorocco.current.weather[0].description} for a temperature of {weatherMorocco.current.temp}\n");

            //Question 2
            Console.WriteLine("When will the sun rise and set today in Oslo?");
            Coordonates Oslo = new Coordonates(59.9138688f, 10.7522454f);
            Root sunRiseOslo = tp2.GetWeather(Oslo);
            Console.WriteLine($"The sun rise in Oslo is at {sunRiseOslo.current.sunrise} and the sun set is at {sunRiseOslo.current.sunset} Kelvin \n");
            
            //Question 3
            Console.WriteLine("What’s the temperature in Jakarta?");
            Coordonates Jakarta = new Coordonates(4, 4);
            Root temperatureJakarta = tp2.GetWeather(Jakarta);
            Console.WriteLine();
            
            //Question 4
            Console.WriteLine("Where is it more windy, New-York, Tokyo or Paris?");
            Coordonates NY = new Coordonates(4, 4);
            Coordonates Tokyo = new Coordonates(4, 4);
            Coordonates Paris = new Coordonates(4, 4);
            Root windParis = tp2.GetWeather(Paris);
            Console.WriteLine();
            
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