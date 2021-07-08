using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp.Models
{
    public class LandVehicle : Vehicle
    {
        public int numWheels { get; set; }
        public int numDoors { get; set; }
        public string color { get; set; }

        public LandVehicle(string _maker, string _model, int _year) : base(_maker, _model, _year)
        {

        }

    }
}
