using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class TimeTable
    {
        public string TrainId { get; set; }
        public string StationID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

    }
}
