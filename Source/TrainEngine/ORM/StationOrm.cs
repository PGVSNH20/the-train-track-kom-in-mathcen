using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TrainEngine.Datamodel;

namespace TrainEngine.ORM
{
   public class StationOrm
    {
        public List<Station> Load()
        {
            string filePath = @".\Data\stations.txt";

            List<Station> stations = new List<Station>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split('|');
                if (entries[0] == "Id") continue;

                Station newStation = new Station
                {
                    Id = Convert.ToInt32(entries[0]),
                    Name = entries[1],
                    EndStation = Convert.ToBoolean(entries[2])
                };
                stations.Add(newStation);
            }

            foreach (var station in stations)
            {
               // Console.WriteLine($"{ station.Id} { station.Name} { station.EndStation} ");
            }
            

            return stations;
        }
    } 
}
