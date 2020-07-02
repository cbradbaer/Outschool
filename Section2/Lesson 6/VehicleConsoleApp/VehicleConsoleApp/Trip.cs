using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp
{
    public class Trip
    {
        public string startLocation { get; set; }
        public string endLocation { get; set; }
        public DateTime startTime { get; set; }
        public Person driver { get; set; }
        public List<Person> passengerList;
        public Vehicle vehicle;

        public Trip()
        {
            passengerList = new List<Person>();

        }


        public Trip(string _startLocation, string _endLocation, DateTime _startTime, Person _driver, Vehicle _vehicle)
        {
            passengerList = new List<Person>();

            startLocation = _startLocation;
            endLocation = _endLocation;
            startTime = _startTime;
            driver = _driver;
            vehicle = _vehicle;

        }



    }
}
