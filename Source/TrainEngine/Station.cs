using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class Station
    {
        public int Id { get; set; }
        public string StartStation { get; set; }
        public string EndStation { get; set; }

        public Station(string stationName)
        {
            StartStation = stationName;
        }

    }
}
