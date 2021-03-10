using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITrainPlaner
    {
        ITrainPlaner HeadTowards (string HeadTowards);
        ITrainPlaner StartTrainAt(string StartTrainAt);
        ITrainPlaner StopTrainAt(string StopTrainAt);
        ITravelPlan GeneratePlan();

    }
}
