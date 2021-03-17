using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TrainEngine.Datamodel;
using TrainEngine.ORM;

namespace TrainEngine.Simulate
{
    public class TrainRunner : ITrainRunner
    {

        private Train trainToSimulate;
        private TrainTrack _track;
        private static bool simulatorIsRunning;
        



        private Thread simulatorThread;


        public TrainRunner(Train train, TrainTrack track)
        {

           
            this.trainToSimulate = train;
            this._track = track;
            simulatorIsRunning = false;
            
        }


        public void Start(Station startStation, Station endStation)
        {
            simulatorIsRunning = true;
            Console.WriteLine($"Tåg: {trainToSimulate.Name}\nTågets startstation: {startStation.Name} \nTågets slutstation: {endStation.Name}");
            simulatorThread = new Thread(() => Simulate(startStation, endStation));
            simulatorThread.Start();


        }

        public void Stop()
        {
            Console.WriteLine($"Stoppar tåg {trainToSimulate.Name}");
            //Thread.Sleep(5000);
            simulatorIsRunning = false;
        }


        public static void Simulate(Station startstation, Station slutStation)
        {
            

            var trackOrm = new TrainTrackOrm();
            var track = trackOrm.Load();
            
            int count = 1;

            while (simulatorIsRunning)
            {
                foreach (var element in track.TrackElements)
                {

                    var countRails = track.TrackElements.Where(x => x.GetType() == typeof(Rail)).Count();

                    if (element is Station)
                    {
                        var station = (Station)element;
                        
                        if (station.Id == startstation.Id)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Föreberedd avgång");
                            Console.WriteLine($"Avstånd {countRails} mil ");
                            Thread.Sleep(2000);
                        }
                        if (station.Name == startstation.Name)
                        {
                            Console.WriteLine($"Din resa börjar här på {station.Name}");
                            simulatorIsRunning = false;
                        }
                        

                        if (station.Name == slutStation.Name)
                        {
                            Console.WriteLine($"Du är nu på slutstation {station.Name}");
                            simulatorIsRunning = false;
                        }
                        
                        
                        if (station.EndStation == false)
                        {
                            Console.WriteLine($"Vi stannar på {station.Name}, innan resan fortsätter mot slutstationen...");
                            Thread.Sleep(2000);
                        }


                    }


                    if (element is Rail)
                    {
                        Console.WriteLine("Tuff tuff...");
                        Console.WriteLine($"{count++} mil");

                    }



                    if (element is Railwaycross)
                    {
                        Console.WriteLine("Tut tuuuuut, watch out for the railroad crossing ");

                    }



                    Console.WriteLine();

                    Thread.Sleep(500);

                }



            }
        }

            
        
    }
    
}
