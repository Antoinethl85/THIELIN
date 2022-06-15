using System;
using System.Net.Http;


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
    }
}