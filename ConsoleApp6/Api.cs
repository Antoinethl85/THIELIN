using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ConsoleApp6.API;
using Newtonsoft.Json;


namespace ConsoleApp6
{
    public class Api
    {
        private HttpClient _client;
        private static string _url = "https://api.openweathermap.org/data/3.0/onecall";
        private string _key;

        //A MODIFIER
        public Api(Api _api)
        {
            _client = new HttpClient();
        }

        public Root getWeatherMaroco(string lat, string lon)
        {
            Dictionary<string, string> content = new Dictionary<string, string>
            {
                { "lat", lat },
                { "lon", lon }
            };
            
            var json = Request(_client, content).GetAwaiter().GetResult();
            Root data = JsonConvert.DeserializeObject<Root>(json);

            return data;
        }

        private async Task<string> Request(HttpClient client, Dictionary<string, string> parameters)
        {
            //A MODIFIER (chaquer avec API Marketstack
            string url = "";
            var reponse = await client.GetAsync(url);
            if (reponse.IsSuccessStatusCode)
            {
                return await reponse.Content.ReadAsStringAsync();
            }
            throw new Exception(await reponse.Content.ReadAsStringAsync());
        }
    }
}