using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp
{
    public class LandVehicle : Vehicle
    {
        public int numWheels { get; set; }
        public int numDoors { get; set; }
        public string Color { get; set; }


        public LandVehicle(string _maker, string _model, int _year, string _color)
        {
            maker = _maker;
            model = _model;
            year = _year;
            Color = _color;

        }


    }
}
