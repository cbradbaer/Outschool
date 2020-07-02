using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp
{
    public class AirVehicle : Vehicle
    {
        public int numWings { get; set; }
        public int numPropellers { get; set; }
        public int maxAltitude { get; set; }


        public AirVehicle() : base()
        {


        }

        public AirVehicle(string _maker, string _model, int _year) : base(_maker, _model, _year)
        {


        }

    }
}
