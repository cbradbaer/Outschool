using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp.Models
{
    public class Trip
    {
        public string startLocation { get; set; }
        public string endLocation { get; set; }
        public DateTime startTime { get; set; }
        public Person driver { get; set; }

        public List<Person> passengerList { get; set; }
        public Vehicle vehicle { get; set; }

        public Trip()
        {
            passengerList = new List<Person>();
        }
        public Trip(string _startLocation, string _endLocation, DateTime _startTime, Person _driver, Vehicle _vehicle)
        {
            passengerList = new List<Person>();

            vehicle = _vehicle;
            startLocation = _startLocation;
            endLocation = _endLocation;
            startTime = _startTime;
            driver = _driver;
        }

    }
}
