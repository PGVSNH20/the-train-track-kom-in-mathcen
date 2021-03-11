using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    class TravelPlan : ITravelPlan
    {

        // Skapa klass traintrackORM - Ska returnera en traintrack
        // Skapa Traintrack datamodell
        // 


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
