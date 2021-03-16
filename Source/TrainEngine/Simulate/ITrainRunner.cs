using System;
using System.Collections.Generic;
using System.Text;
using TrainEngine.Datamodel;

namespace TrainEngine.Simulate
{
    public interface ITrainRunner
    {
        void Start(Station startStation, Station endStation);
        void Stop();
        

    }
}
