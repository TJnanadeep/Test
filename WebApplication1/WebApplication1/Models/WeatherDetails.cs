using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Models
{
        public class WeatherDetails
        {
            public string Address { get; set; }
            public string Description { get; set; }
            public List<DayDetails> days { get; set; }
            public string weathericon { get; set; }

        }

        public class DayDetails
        {
            public string datetime { get; set; }
            public string tempmax { get; set; }
            public string tempmin { get; set; }
            public string Icon { get; set; }


        }


        public class Rootobject
        {
            public int queryCost { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public string resolvedAddress { get; set; }
            public string address { get; set; }
            public string timezone { get; set; }
            public float tzoffset { get; set; }
            public string description { get; set; }
            public Day[] days { get; set; }
            public object[] alerts { get; set; }
            public Stations stations { get; set; }
            public Currentconditions currentConditions { get; set; }
        }

        public class Stations
        {
            public VOHS VOHS { get; set; }
            public VOHY VOHY { get; set; }
        }

        public class VOHS
        {
            public int distance { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public int useCount { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public int quality { get; set; }
            public int contribution { get; set; }
        }

        public class VOHY
        {
            public int distance { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public int useCount { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public int quality { get; set; }
            public int contribution { get; set; }
        }

        public class Currentconditions
        {
            public string datetime { get; set; }
            public int datetimeEpoch { get; set; }
            public int temp { get; set; }
            public float feelslike { get; set; }
            public float humidity { get; set; }
            public int dew { get; set; }
            public object precip { get; set; }
            public int precipprob { get; set; }
            public int snow { get; set; }
            public int snowdepth { get; set; }
            public object preciptype { get; set; }
            public object windgust { get; set; }
            public float windspeed { get; set; }
            public int winddir { get; set; }
            public float pressure { get; set; }
            public int visibility { get; set; }
            public int cloudcover { get; set; }
            public int solarradiation { get; set; }
            public float solarenergy { get; set; }
            public int uvindex { get; set; }
            public string conditions { get; set; }
            public string icon { get; set; }
            public string[] stations { get; set; }
            public string source { get; set; }
            public string sunrise { get; set; }
            public int sunriseEpoch { get; set; }
            public string sunset { get; set; }
            public int sunsetEpoch { get; set; }
            public float moonphase { get; set; }
        }

        public class Day
        {
            public string datetime { get; set; }
            public int datetimeEpoch { get; set; }
            public float tempmax { get; set; }
            public float tempmin { get; set; }
            public float temp { get; set; }
            public float feelslikemax { get; set; }
            public float feelslikemin { get; set; }
            public float feelslike { get; set; }
            public float dew { get; set; }
            public int humidity { get; set; }
            public int precip { get; set; }
            public int precipprob { get; set; }
            public int precipcover { get; set; }
            public object preciptype { get; set; }
            public int snow { get; set; }
            public int snowdepth { get; set; }
            public float windgust { get; set; }
            public int windspeed { get; set; }
            public int winddir { get; set; }
            public float pressure { get; set; }
            public float cloudcover { get; set; }
            public float visibility { get; set; }
            public float solarradiation { get; set; }
            public float solarenergy { get; set; }
            public int uvindex { get; set; }
            public int severerisk { get; set; }
            public string sunrise { get; set; }
            public int sunriseEpoch { get; set; }
            public string sunset { get; set; }
            public int sunsetEpoch { get; set; }
            public float moonphase { get; set; }
            public string conditions { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
            public string[] stations { get; set; }
            public string source { get; set; }
            public Hour[] hours { get; set; }
        }

        public class Hour
        {
            public string datetime { get; set; }
            public int datetimeEpoch { get; set; }
            public float temp { get; set; }
            public float feelslike { get; set; }
            public float humidity { get; set; }
            public float dew { get; set; }
            public int precip { get; set; }
            public int precipprob { get; set; }
            public int snow { get; set; }
            public int snowdepth { get; set; }
            public object preciptype { get; set; }
            public float windgust { get; set; }
            public float windspeed { get; set; }
            public float winddir { get; set; }
            public int pressure { get; set; }
            public float visibility { get; set; }
            public int cloudcover { get; set; }
            public int solarradiation { get; set; }
            public float solarenergy { get; set; }
            public int uvindex { get; set; }
            public int severerisk { get; set; }
            public string conditions { get; set; }
            public string icon { get; set; }
            public object stations { get; set; }
            public string source { get; set; }
        }
}
