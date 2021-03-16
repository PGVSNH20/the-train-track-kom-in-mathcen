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
            var stationOrm = new StationOrm();
            var stations = stationOrm.Load();
            
            var trainOrm = new TrainOrm();
            var trains = trainOrm.Load();
            
            Train train1 = trains.FirstOrDefault(t => t.Id == 3);
            Station station1 = stations.FirstOrDefault(s => s.Id == 0);
            Station station2 = stations.FirstOrDefault(s => s.Id == 2);
            
            Console.WriteLine($"Detta ar din reseplan:");
           
            var travelPlan1 = new TrainPlaner(train1, station1)
                    .HeadTowards(station2)
                    .StartTrainAt("10:23")
                    .StopTrainAt("14:53", station2)
                    .GeneratePlan();
            Console.WriteLine($"{travelPlan1.Timetables}");
            
            //Console.WriteLine($"Detta ar din reseplan:");

            //Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)

            // Step 2:
            // Make the trains run in treads

        }
    }
}
