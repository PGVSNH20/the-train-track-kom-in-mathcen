using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace TrainEngine.ORM
{ 
    public class TrainOrm
    {
        public List<Train> Load()
        {
                       
            string filePath = @".\Data\trains.txt";

            List<Train> trains = new List<Train>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                if (entries[0] == "Id") continue;
                
                Train newTrain = new Train
                {
                    Id = Convert.ToInt32(entries[0]),
                    Name = entries[1],
                    MaxSpeed = entries[2],
                    Operated = Convert.ToBoolean(entries[3])
                };

                trains.Add(newTrain);
            }

            foreach (var train in trains )
            {
                Console.WriteLine($"{ train.Id} { train.Name} { train.MaxSpeed} { train.Operated}");
            }
            
            return trains;
        }

    }
}



