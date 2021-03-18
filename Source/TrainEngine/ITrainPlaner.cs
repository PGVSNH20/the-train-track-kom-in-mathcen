using System;
using System.Collections.Generic;
using System.Text;
using TrainEngine.Datamodel;

namespace TrainEngine
{
    public interface ITrainPlaner
    {
        ITrainPlaner LoadTrainTrack(TrainTrack track);
        ITrainPlaner HeadTowards (Station Station2);
        ITrainPlaner StartTrainAt(string StartTrainAt);
        ITrainPlaner StopTrainAt(string StopTrainAt, Station Station2);
        ITravelPlan GeneratePlan();

    }
}
