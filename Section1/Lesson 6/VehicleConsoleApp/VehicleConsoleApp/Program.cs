using System;
using VehicleConsoleApp.Models;

namespace VehicleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTripMethod2();

        }

        static void MyTripMethod2()
        {
            LandVehicle myCar = new LandVehicle("Toyota", "Corolla", 2015);
            Person me = new Person("Cary Baer");
            Trip myTrip = new Trip("Los Angeles", "Houston", DateTime.Now, me, myCar);
            myTrip.passengerList.Add(new Person("John Smith"));
            myTrip.passengerList.Add(new Person("Jane Doe"));
            string outString = string.Format("{0} is taking the {1} {2} {3} on a trip from {4} to {5}.",
                                    myTrip.driver.name, myTrip.vehicle.year, myTrip.vehicle.maker, myTrip.vehicle.model,
                                    myTrip.startLocation, myTrip.endLocation);

            Console.Write(outString);

            Console.WriteLine("These passengers also going:");

            foreach (Person p in myTrip.passengerList)
            {
                Console.WriteLine(p.name);
            }


            Console.ReadKey();
        }



        static void MyTripMethod1()
        {
            LandVehicle myCar = new LandVehicle();
            Person me = new Person();
            Person passenger1 = new Person();
            Person passenger2 = new Person();

            me.name = "Cary Baer";
            passenger1.name = "John Smith";
            passenger2.name = "Jane Doe";

            myCar.maker = "Toyota";
            myCar.model = "Corolla";
            myCar.year = 2015;

            Trip myTrip = new Trip();
            myTrip.driver = me;
            myTrip.vehicle = myCar;
            myTrip.startLocation = "Los Angeles";
            myTrip.endLocation = "Houston";

            myTrip.passengerList.Add(passenger1);
            myTrip.passengerList.Add(passenger2);

            string outputString = myTrip.driver.name + " is taking the " + myTrip.vehicle.year +
                " " + myTrip.vehicle.maker + " " + myTrip.vehicle.model + " on a trip from " +
                myTrip.startLocation + " to " + myTrip.endLocation;


            Console.WriteLine(outputString);

            Console.WriteLine("These passengers are also going ont the trip:");
            foreach (Person p in myTrip.passengerList)
                Console.WriteLine(p.name);


            Console.ReadKey();

        }

    }
}
