using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITrainPlan
    {
        ITrainPlan HeadTowards (string HeadTowards);
        ITrainPlan StartTrainAt(string StartTrainAt);
        ITrainPlan StopTrainAt(string StopTrainAt);
        ITrainPlan GeneratePlan();
    }
}
