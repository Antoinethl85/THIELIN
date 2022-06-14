using System;
using System.Net.Http;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage();
            
            Console.WriteLine("Hello World!");
        }
    }
}