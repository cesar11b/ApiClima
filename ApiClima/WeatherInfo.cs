using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClima
{
    class WeatherInfo
    {

        public class Coord
        {

            double lon { get; set; }
            double lat { get; set; }

        }



        public class Weather
        {

            string Main { get; set; }
            string Description { get; set; }
            string Icon { get; set; }
        }

        public class Main
        {

            double Temp { get; set; }
            double Pressure { get; set; }
            double Humidity { get; set; }

          
        }

        public class Wind
        {
            double Speed { get; set; }


        }

        public class Sys
        {

            long Sunrise { get; set; }
            long Sunset { get; set; }

        }


        public class Root
        {

            public Coord coord { get; set; }
            public List<Weather> weather { get; set; }
            public Main main { get; set; }
            public Wind wind { get; set; }
            public Sys sys { get; set; }

        }



    }
}
