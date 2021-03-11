using System;
using System.IO;
using TrainEngine;
using TrainEngine.ORM;
using System.Linq;

namespace TrainConsole 
{
    class Program 
    {
        static void Main(string[] args)
        {
            var orm = new TrainOrm();
            var trains = orm.Load();

            Train train1 = trains.FirstOrDefault(x => x.Id == 2);
            Station station1 = new("Gothenburg");
            Station station2 = new("Stockholm");

            ITravelPlan travelPlan = new TrainPlaner(train1, station1)
                    .HeadTowards(station2)
                    .StartTrainAt("10:23")
                    .StopTrainAt("14:53", station2)
                    .GeneratePlan();
            Console.WriteLine(travelPlan.Timetables);

            
         
            
            







            //Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)

            // Step 2:
            // Make the trains run in treads

        }
    }
}
