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
        public Vehicle vehicle { get; set; }
        public Person driver { get; set; }

        public List<Person> passengerList;


        public Trip()
        {
            passengerList = new List<Person>();
        }


    }
}
