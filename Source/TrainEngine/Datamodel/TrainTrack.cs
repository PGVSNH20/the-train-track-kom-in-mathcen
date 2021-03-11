using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine.Datamodel
{
    public class TrainTrack
    {

        public List<TrackElement> TrackElements { get; set; }



        public TrainTrack()
        {

            TrackElements = new List<TrackElement>();

        }



    }
}
