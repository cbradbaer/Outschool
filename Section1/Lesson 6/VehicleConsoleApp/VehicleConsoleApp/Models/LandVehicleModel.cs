using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp.Models
{
    public class LandVehicleModel : VehicleModel
    {

        public int numWheels { get; set; }
        public int numDoors { get; set; }
        public string Color { get; set; }

        public LandVehicleModel() : base()
        {


        }
        public LandVehicleModel(string _maker, string _model, string _year) : base(_maker, _model, _year)
        {


        }


    }
}
