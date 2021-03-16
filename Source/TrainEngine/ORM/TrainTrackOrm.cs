using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TrainEngine.Datamodel;

namespace TrainEngine.ORM
{
    public class TrainTrackOrm
    {


        public TrainTrack Load()
        {
            var trainTrack = new TrainTrack();


            string filePath = @"C:\Users\mattias.lidbom\source\repos\the-train-track-kom-in-mathcen\Data\traintrack1.txt";

            string lines = File.ReadAllText(filePath);

            var station = new StationOrm();
            var stations = station.Load();

            foreach (char element in lines){

                if(element == '-')
                {
                    trainTrack.TrackElements.Add(new Rail());
                }

                if(element == '1')
                {
                    var startStation = stations.FirstOrDefault(s => s.Id == 1);
                    trainTrack.TrackElements.Add(startStation);
                }

                if(element == '2')
                {
                    var middleStation = stations.FirstOrDefault(s => s.Id == 2);
                    trainTrack.TrackElements.Add(middleStation);
                }

                if (element == '3')
                {
                    var endStation = stations.FirstOrDefault(s => s.Id == 3);
                    trainTrack.TrackElements.Add(endStation);
                }

                if(element == '=')
                {
                    trainTrack.TrackElements.Add(new Railwaycross());
                }

            }



           
            return trainTrack;

        }


        }

     

                
            
        


        


    
}
