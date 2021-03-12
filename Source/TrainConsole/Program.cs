using System;
using System.Collections.Generic;
using System.IO;
using TrainEngine;
using TrainEngine.Datamodel;
using TrainEngine.ORM;
using System.Linq;

namespace TrainConsole
{
    public class Program
    {

        //private TrainTrack _traintrack;

        //public List<TimeTable> Timetables;

        static void Main(string[] args)
        {

            //Timetables = new List<TimeTable>();

            //Train train1 = new Train("Name of train");
            //Station station1 = new Station("Gothenburg");
            //Station station2 = new Station("Stockholm");

            //ITravelPlan travelPlan = new TrainPlaner(train1, station1)
            //        .HeadTowards(station2)
            //        .StartTrainAt("10:23")
            //        .StopTrainAt("14:53", station2)
            //        .GeneratePlan();
            //Console.WriteLine(travelPlan.Timetables);


            //var trackOem = new TrainTrackOrm();

            //var track = trackOem.Load();


            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mattias.lidbom\source\repos\the-train-track-kom-in-mathcen\Data\traintrack1.txt");

            

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                
                
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }












            //Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)

            // Step 2:
            // Make the trains run in treads

        }
    }
}
