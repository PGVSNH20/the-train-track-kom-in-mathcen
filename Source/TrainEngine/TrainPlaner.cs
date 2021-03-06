using System;
using System.Collections.Generic;
using System.Text;
using TrainEngine.Datamodel;

namespace TrainEngine
{
    public class TrainPlaner : ITrainPlaner
    {

        private Station _station;
        private Train _train;
        private List<TimeTable> Timetables;





        public TrainPlaner(Train train1)
        {
            _train = train1;
            //_station = station1;

            Timetables = new List<TimeTable>();

        }

        public ITrainPlaner LoadTrainTrack(TrainTrack track)
        {
            Timetables.Add(new TimeTable() { ActualTrack = track });
            return this; 
        }


        public ITrainPlaner HeadTowards(Station station2)
        {
            Timetables.Add(new TimeTable() { EndStation = station2});
            return this;

        }

        public ITrainPlaner StartTrainAt(string startTrainAt)
        {
            Timetables.Add(new TimeTable() { DepartureTime = startTrainAt });
            return this;

        }

        public ITrainPlaner StopTrainAt(string stopTrainAt, Station station2)
        {
            Timetables.Add(new TimeTable() { ArrivalTime = stopTrainAt, EndStation = station2});
            return this;


        }


        public ITravelPlan GeneratePlan()
        {
            foreach(var element in Timetables)
            {
                Console.WriteLine($"This is what's in your plan: {element.ActualTrack} {element.DepartureTime} {element.ArrivalTime} {element.StartStation} {element.EndStation} ");
            }
            
            return new TravelPlan() { Timetables = Timetables };

            
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
    

