﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TrainEngine;

namespace TrainConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Train train1 = new Train("Name of train");
            Station station1 = new Station("Gothenburg");
            Station station2 = new Station("Stockholm");

            ITravelPlan travelPlan = new TrainPlaner(train1, station1)
                    .HeadTowards(station2)
                    .StartTrainAt("10:23")
                    .StopTrainAt("14:53", station2)
                    .GeneratePlan();
            Console.WriteLine(travelPlan.Timetables);

            string filepath = @"C:\Users\drunn\Documents\GitHub\the-train-track-kom-in-mathcen\Data\train.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
             

            // iterate through each element within the array and
            // print it out
            //
            





            //Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)

            // Step 2:
            // Make the trains run in treads

        }
    }
}
