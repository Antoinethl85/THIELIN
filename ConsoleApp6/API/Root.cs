using System.Collections.Generic;

namespace ConsoleApp6.API
{
    public class Root
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public Datum current { get; set; }
    }
}