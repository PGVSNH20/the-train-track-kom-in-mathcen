using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine.Datamodel
{
    public class Station : TrackElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool EndStation { get; set; }

    }
}
