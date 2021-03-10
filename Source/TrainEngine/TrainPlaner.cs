using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class TrainPlaner : ITrainPlaner
    {

        private Station _station;
        private Train _train;
        private List<TimeTable> Timetables;


        public TrainPlaner(Train train, Station station1)
        {
            _train.Name = train.ToString();
            _station.Name = station1.ToString();

            Timetables = new List<TimeTable>();

        }


      
        public ITrainPlaner HeadTowards(Station station2)
        {
            Timetables.Add(new TimeTable() { EndStation = station2.ToString() });
            return this;
            //   throw new NotImplementedException();
        }

        public ITrainPlaner StartTrainAt(string startTrainAt)
        {
            Timetables.Add(new TimeTable() { DepartureTime = startTrainAt });
            return this;
            //throw new NotImplementedException();
        }

        public ITrainPlaner StopTrainAt(string stopTrainAt, Station station2)
        {
            Timetables.Add(new TimeTable() { ArrivalTime = stopTrainAt, EndStation = station2.ToString() });
            return this;
            //throw new NotImplementedException();
        }

        public ITravelPlan GeneratePlan()
        {
            foreach(var travelplan in Timetables)
            {
                Console.WriteLine($"{travelplan.EndStation} {travelplan.DepartureTime} {travelplan.ArrivalTime} {travelplan.EndStation}");
            }
            throw new NotImplementedException();
        }
    }

    /*
    Train train1 = new Train("Name of train");
    Station station1 = new Station("Gothenburg");
    Station station2 = new Station("Stockholm");

    ITravelPlan travelPlan = new TrainPlaner(train1, station1)
            .HeadTowards(station2)
            .StartTrainAt("10:23")
            .StopTrainAt(station2, "14:53")
        .GeneratePlan();
    */
}
