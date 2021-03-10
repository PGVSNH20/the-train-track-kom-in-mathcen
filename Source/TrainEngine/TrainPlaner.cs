using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    class TrainPlaner : ITrainPlan
    {
        public List<TimeTable> timeTables { get; set; }

        public TrainPlaner()
        {
            timeTables = new List<TimeTable>();
        }

        public ITrainPlan HeadTowards(string HeadTowards)
        {
            timeTables.Add(new TimeTable() { StationID = HeadTowards });
            return this;
        }

        public ITrainPlan StartTrainAt(string StartTrainAt)
        {
            timeTables.Add(new TimeTable() { DepartureTime = StartTrainAt });
            return this;
        }

        public ITrainPlan StopTrainAt(string StopTrainAt)
        {
            timeTables.Add(new TimeTable() { StationID = StopTrainAt });
            return this;
        }

        public ITrainPlan GeneratePlan()
        {
          
            return this;
        }
        

    }
}
