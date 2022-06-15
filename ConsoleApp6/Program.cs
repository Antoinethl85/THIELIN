using System;
using System.Net.Http;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var requestMaroco = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.openweathermap.org/data/3.0/onecall?lat={lat}&lon={lon}&exclude={part}&appid=624c4ed18365308ce225acee2b5c2bd2"),
            };
            
        }
    }
}