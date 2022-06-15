using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ConsoleApp6.API;


namespace ConsoleApp6
{
    public class Api
    {
        private HttpClient _client;
        private static string _url = "";
        private string _key;

        public Api(Api _api)
        {
            _client = new HttpClient();
        }

        /*public Root getWeatherMaroco(string lat, string lon)
        {
            var json = 
        }*/

        private async Task<string> Request(HttpClient client, Dictionary<string, string> parameters)
        {
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