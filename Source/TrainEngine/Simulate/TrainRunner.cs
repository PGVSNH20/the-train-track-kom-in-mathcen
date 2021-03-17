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
        private Thread simulatorThread;


        public TrainRunner(Train train, TrainTrack track)
        {
            

            this.trainToSimulate = train;
            this._track = track;
            //simulatorIsRunning = false;

        }


        public void Start(Station startStation, Station endStation)
        {
            //Skapar ny tråd
            
            Console.WriteLine($"Tåg: {trainToSimulate.Name}\nTågets startstation: {startStation.Name} \nTågets slutstation: {endStation.Name}");
            simulatorThread = new Thread(() => Simulate());
            simulatorThread.Start();


        }

        public void Stop()
        {
            throw new NotImplementedException();
        }


        public static void Simulate()
        {
            int distance = 0;

            var trackOrm = new TrainTrackOrm();
            var track = trackOrm.Load();




            


            foreach (var element in track.TrackElements)
            {
               

                Console.WriteLine(element);
                
                Thread.Sleep(500);

                /*
                if element = startstation; continue
                
                if element = rail {
                    writeline med delay 
                }
                if element =  endstation {
                    writline du e framme.
                }
                    

                   // if (track.TrackElements.Any(s => s.GetType() == ));


                */
            }

        } 
        /*
private static void Simulate(){
            while(simulatorIsRunning){
                
                int distanceDrived = tts.Speed * FakeClock.MinutesWhichHaveTicked;
                Console.WriteLine($"So far have {tts.Name} gone {distanceDrived} in {FakeClock.MinutesWhichHaveTicked} min");
                if(distanceDrived >= distanceToDrive){
                    simulatorIsRunning = false;
                    Console.WriteLine($"We have arrived at the station which is {distanceToDrive} km from starting point");
                }
                Thread.Sleep(200);
       */
    }
}
