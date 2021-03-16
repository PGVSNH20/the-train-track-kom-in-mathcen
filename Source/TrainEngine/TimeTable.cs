using System;
using System.Collections.Generic;
using System.Text;
using TrainEngine.Datamodel;

namespace TrainEngine
{
    public class TimeTable
    {
        public int TrainId { get; set; }
        public int StationID { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string StartStation { get; set; }
        public Station EndStation { get; set; }

    }
}
