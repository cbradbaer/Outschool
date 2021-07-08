using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp.Models
{
    public class Vehicle
    {
        //private string _maker;
        //private string _model;
        //private int _topSpeed;

        //public string maker
        //{
        //    get { return _maker; }
        //    set { _maker = value; }
        //}

        public string maker { get; set; }
        public string model { get; set; }
        public int topSpeed { get; set; }
        public int year { get; set; }

        public Vehicle(string _maker, string _model, int _year)
        {
            maker = _maker;
            model = _model;
            year = _year;

        }

    }
}
