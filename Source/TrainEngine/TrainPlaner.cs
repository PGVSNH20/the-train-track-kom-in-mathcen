using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    class TrainPlaner : ITrainPlaner
    {

        private Station _station;
        private Train _train;


        public TrainPlaner(Train train, Station startStation)
        {
            _train.Name = train.ToString();
            _station.StartStation = startStation.ToString();
            

        }


      
        public ITrainPlaner HeadTowards(string HeadTowards)
        {
            throw new NotImplementedException();
        }

        public ITrainPlaner StartTrainAt(string StartTrainAt)
        {
            throw new NotImplementedException();
        }

        public ITrainPlaner StopTrainAt(string StopTrainAt)
        {
            throw new NotImplementedException();
        }

        public ITravelPlan GeneratePlan()
        {
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
