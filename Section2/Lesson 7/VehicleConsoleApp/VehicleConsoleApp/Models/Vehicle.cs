using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp.Models
{
    public class Vehicle
    {
        //private string _maker;
        //public string maker
        //{
        //    get { return _maker; }
        //    set { _maker = value; }
        //}

        public string maker { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string topSpeed { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string _maker, string _model, string _year)
        {
            maker = _maker;
            model = _model;
            year = _year;

        }




    }
}
