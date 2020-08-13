using System;

namespace VehicleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            LandVehicle myCar = new LandVehicle("Toyota", "Corolla", 2015, "White");



            Person me = new Person();
            me.name = "Cary Baer";

            Person passenger1 = new Person();
            passenger1.name = "John Smith";

            Person passenger2 = new Person();
            passenger2.name = "David Lee Roth";


            Trip myTrip = new Trip();
            myTrip.startLocation = "Los Angeles";
            myTrip.endLocation = "Hawaii";
            myTrip.driver = me;
            myTrip.startTime = DateTime.Now;
            myTrip.vehicle = myCar;
            myTrip.passengerList.Add(passenger1);
            myTrip.passengerList.Add(passenger2);


            Console.WriteLine(myTrip.driver.name + " is taking a trip in his "
                    + myTrip.vehicle.year + " " + myTrip.vehicle.maker + " "
                    + myTrip.vehicle.model + " from " + myTrip.startLocation
                    + " to " + myTrip.endLocation + " at " + myTrip.startTime);

            Console.Write("Also going on the trip are the passengers:\r\n");
            Console.Write("");
            foreach(Person p in myTrip.passengerList)
            {
                Console.WriteLine(p.name);

            }

            Console.ReadKey();



        }
    }
}
