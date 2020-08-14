using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp
{
    public class trip
    {
        public string startLocation { get; set; }
        public string endLocation { get; set; }
        public DateTime startTime { get; set; }
        public person driver { get; set; }
        public vehicle vehicle { get; set; }

        public List<person> passengerList { get; set; }

        public trip(string _startLocation, string _endLocation,
                    DateTime _startTime, vehicle _vehicle, person _driver)
        {
            passengerList = new List<person>();

            startLocation = _startLocation;
            endLocation = _endLocation;
            startTime = _startTime;
            vehicle = _vehicle;
            driver = _driver;


        }




    }
}
