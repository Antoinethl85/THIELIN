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
            Console.WriteLine("What's the weather like in Morocco ? \n");
            Coordonates Morocco = new Coordonates(39.099724f, -94.578331f);
            Root weatherMorocco = tp2.GetWeather(Morocco);
            //double temperature = weatherMorocco.data[0].temp;
            //string description = weatherMorocco.data[0].weather[0].description;
            Console.WriteLine(weatherMorocco.data[0]);

            //Question 2
            Console.WriteLine("When will the sun rise and set today in Oslo?");
            Coordonates Oslo = new Coordonates(4, 4);
            Root sunRiseOslo = tp2.GetWeather(Oslo);
            Console.WriteLine();
            
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