using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITravelPlan
    {
        List<TimeTable> Timetables { get; }

        object Train { get; }

        void Save(string path);
        void Load(string path);

    }
}
