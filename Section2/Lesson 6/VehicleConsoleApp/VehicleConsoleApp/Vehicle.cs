using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp
{
    public class Vehicle
    {
        //private string _maker;


        //public string maker
        //{
        //    get { return _maker; }
        //    set {_maker = value; }
        //}

        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public int topSpeed { get; set; }


        public Vehicle()
        {


        }

        public Vehicle(string _maker, string _model, int _year)
        {
            maker = _maker;
            model = _model;
            year = _year;
        }


    }
}
