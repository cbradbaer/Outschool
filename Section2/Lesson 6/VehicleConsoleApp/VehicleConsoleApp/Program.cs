using System;
using VehicleConsoleApp.Models;

namespace VehicleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LandVehicle myCar = new LandVehicle();
            myCar.maker = "Toyota";
            myCar.model = "Corolla";
            myCar.year = "2015";
            myCar.numDoors = 4;

            Person me = new Person();
            me.name = "Cary";

            Person passenger1 = new Person();
            passenger1.name = "William Shakespeare";
            Person passenger2 = new Person();
            passenger2.name = "Elvis Presley";

            Trip myTrip = new Trip();
            myTrip.startLocation = "Los Angeles";
            myTrip.endLocation = "Toronto";
            myTrip.driver = me;
            myTrip.passengerList.Add(passenger1);
            myTrip.passengerList.Add(passenger2);
            myTrip.vehicle = myCar;

            string outputStr = string.Format("{0} is taking a trip from {1} to {2} in his {3} {4} {5}."
                ,myTrip.driver.name, myTrip.startLocation, myTrip.endLocation, myTrip.vehicle.year, myTrip.vehicle.maker, myTrip.vehicle.model);
            Console.WriteLine(outputStr);
            Console.ReadKey();


        }
    }
}
