using System;
using System.IO;
using TrainEngine;
using TrainEngine.ORM;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TrainEngine.Datamodel;
using TrainEngine.Simulate;
using System.Threading;

namespace TrainConsole 
{
    public class Program
    {

        

        static void Main(string[] args)
        {
            
            
            var stationOrm = new StationOrm();
            var stations = stationOrm.Load();

            var trainOrm = new TrainOrm();
            var trains = trainOrm.Load();

            var trackOrm = new TrainTrackOrm();
            var track = trackOrm.Load();

            var trainTrack = new TrainTrack();
            
            
            //Extract 
            
            

            ITrainRunner runner = new TrainRunner(trains[0], track);
            runner.Start((Station)track.TrackElements[0], (Station)track.TrackElements[27]);
            Thread.Sleep(20000);
            //Console.WriteLine("Times up");
            runner.Stop();
            /*ITrainRunner runner2 = new TrainRunner(trains[0], track);
            runner.Start((Station)track.TrackElements[27], (Station)track.TrackElements[0]);
            Thread.Sleep(3000);
            Console.WriteLine("Times up");
            runner.Stop(); */
           


           

            Train train1 = trains.FirstOrDefault(t => t.Id == 2);
            Station station1 = stations.FirstOrDefault(s => s.Id == 1);
            Station station2 = stations.FirstOrDefault(s => s.Id == 3);

            Console.WriteLine($"Detta ar din reseplan:");

            ITravelPlan travelPlan1 = new TrainPlaner(train1)
                        .LoadTrainTrack(track)
                        .HeadTowards(station2)
                        .StartTrainAt("10:23")
                        .StopTrainAt("14:53", station2)
                        .GeneratePlan();


            //var train = new TrainTrackOrm();

            //var track = train.Load();


    

        }


            //Console.WriteLine($"Detta ar din reseplan:");

            //Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)

            // Step 2:
            // Make the trains run in treads

        
    }
}
