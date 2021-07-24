﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp.Models
{
    public class LandVehicle : Vehicle
    {
        public int numWheels { get; set; }
        public int numDoors { get; set; }

        public string Color { get; set; }


        public LandVehicle() : base()
        {

        }


        public LandVehicle(string _maker, string _model, string _year, string _color) : base(_maker, _model, _year)
        {
            Color = _color;
        }



    }
}
