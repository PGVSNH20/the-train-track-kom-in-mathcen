using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITravelPlan
    {
        List<TimeTable> Timetables { get; set; }

        //object Train { get; }

        void Save(string path);
        void Load(string path);

    }
}
