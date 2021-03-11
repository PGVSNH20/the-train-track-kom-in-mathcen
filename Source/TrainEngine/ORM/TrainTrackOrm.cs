using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TrainEngine.Datamodel;

namespace TrainEngine.ORM
{
    class TrainTrackOrm
    {


        public TrainTrack Load()
        {
            var trainTrack = new TrainTrack();

                String line;

                StreamReader sr = new StreamReader(@"C:\\Users\mattias.lidbom\source\repos\the-train-track-kom-in-mathcen\Data\traintack1.txt");

                line = sr.ReadLine();

                while (line != null)
                {

                    Console.WriteLine(line);

                    line = sr.ReadLine();


                    foreach (var lines in line)
                    {
                        if (lines == '-')
                        {
                        trainTrack.TrackElements.Add(new Rail());
                        }



                    }
                    


                {
                    


                }

                    

                }

                sr.Close();
                Console.ReadLine();


            return trainTrack;
            
        }


        


    }
}
