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
            Coordonates Morocco = new Coordonates(33.9715904, -6.8498129);
            Root weatherMorocco = tp2.GetWeather(Morocco);
            double temperature = weatherMorocco.data[0].temp;
            string description = weatherMorocco.data[0].weather[0].description;
            Console.WriteLine("The temperature is ", temperature);

            //Question 2

            //Question 3

            //Question 4

            //Question 5

        }
        
    }
}