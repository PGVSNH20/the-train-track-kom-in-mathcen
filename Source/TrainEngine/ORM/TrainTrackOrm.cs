using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TrainEngine.Datamodel;

namespace TrainEngine.ORM
{
    public class TrainTrackOrm
    {


        public TrainTrack Load()
        {
            var trainTrack = new TrainTrack();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mattias.lidbom\source\repos\the-train-track-kom-in-mathcen\Data\traintrack1.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (var teckenInLine in lines)
            {
                
                

                if (teckenInLine.Contains("-")) 
                {
                    trainTrack.TrackElements.Add(new Rail());
                }

                

                

                //if (teckenInLine.Contains("3")) 
                //{
                //    trainTrack.TrackElements.Add(new Station());
                //}

                
                // Use a tab to indent each line of the file.
               // Console.WriteLine("\t" + line);
            }

     

                return trainTrack;
            
        }


        


    }
}
