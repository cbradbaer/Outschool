using System;
using VehicleConsoleApp.Models;

namespace VehicleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //LandVehicle myCar = new LandVehicle();
            //myCar.maker = "Toyota";
            //myCar.model = "Corolla";
            //myCar.year = 2015;
            //myCar.topSpeed = 80;
            //myCar.color = "green";
            //myCar.numWheels = 4;

            LandVehicle myCar = new LandVehicle("Toyota", "Corolla", 2015);


            Person driver = new Person();
            driver.Name = "Cary Baer";

            Person passenger1 = new Person();
            passenger1.Name = "Drake";
            Person passenger2 = new Person();
            passenger2.Name = "Madonna";


            Trip myTrip = new Trip();
            myTrip.vehicle = myCar;
            myTrip.driver = driver;
            myTrip.passengerList.Add(passenger1);
            myTrip.passengerList.Add(passenger2);
            myTrip.startLocation = "Los Angeles";
            myTrip.endLocation = "Connecticut";

            //string outString = myTrip.driver.Name + " is taking a trip from " + myTrip.startLocation + " to " + myTrip.endLocation + " in his " + myTrip.vehicle.model + ".";

            string outString = string.Format("{0} is taking a trip from {1} to {2} in his {3}.", myTrip.driver.Name, myTrip.startLocation, myTrip.endLocation, myTrip.vehicle.model);

            Console.WriteLine(outString);

            foreach (Person p in myTrip.passengerList)
            {
                Console.WriteLine(p.Name);
            }

                Console.ReadKey();

        }
    }
}
