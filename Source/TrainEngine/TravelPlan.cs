using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    class TravelPlan : ITravelPlan
    {
       

        public List<TimeTable> Timetables { get; set; } 

        public void Load(string path)
        {
            throw new NotImplementedException();
        }

        public void Save(string path)
        {
            throw new NotImplementedException();
        }
    }
}
