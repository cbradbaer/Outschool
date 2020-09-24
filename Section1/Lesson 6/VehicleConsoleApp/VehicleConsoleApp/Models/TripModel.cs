using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp.Models
{
    public class TripModel
    {
        public string startLocation { get; set; }
        public string endLocation { get; set; }
        public DateTime startTime { get; set; }
        public PersonModel driver { get; set; }
        public VehicleModel vehicle { get; set; }

        public List<PersonModel> passengerList { get; set; }

        public TripModel()
        {

            passengerList = new List<PersonModel>();

        }


        public TripModel(string _startLocaiton, string _endLocation, PersonModel _driver, VehicleModel _vehicle )
        {

            passengerList = new List<PersonModel>();

            startLocation = _startLocaiton;
            endLocation = _endLocation;
            driver = _driver;
            vehicle = _vehicle;

        }


    }
}
