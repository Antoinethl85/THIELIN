using System;
using System.Net.Http;
using System.Threading.Tasks;
using ConsoleApp6.API;
using Newtonsoft.Json;

namespace ConsoleApp6
{
    public class Api
    {
        
        private HttpClient _client = new HttpClient();
        private static string _url = "https://api.openweathermap.org/data/2.5/onecall";
        private string _key = "624c4ed18365308ce225acee2b5c2bd2";
        

        public Root GetWeather(Coordonates coordinates)
        {
            var json = Request(coordinates).GetAwaiter().GetResult();
            Root data = JsonConvert.DeserializeObject<Root>(json);

            return data;
        }

        private async Task<string> Request(Coordonates coordinates)
        {
            string url = $"{_url}?lat={coordinates.lat}&lon={coordinates.lon}&units=metric&appid={_key}";
            var reponse = await _client.GetAsync(url);

            if (reponse.IsSuccessStatusCode)
            {
                return await reponse.Content.ReadAsStringAsync();
            }

            throw new Exception(await reponse.Content.ReadAsStringAsync());
        }
    }
}