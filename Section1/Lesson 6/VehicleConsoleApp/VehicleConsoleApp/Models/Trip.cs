using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApp.Models
{
    class Trip
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
    }
}
