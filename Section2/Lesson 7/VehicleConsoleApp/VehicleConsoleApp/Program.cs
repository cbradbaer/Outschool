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

        static void MyTripMethod1()
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
                , myTrip.driver.name, myTrip.startLocation, myTrip.endLocation, myTrip.vehicle.year, myTrip.vehicle.maker, myTrip.vehicle.model);
            Console.WriteLine(outputStr);

            Console.WriteLine("Also going on the trip are:");
            foreach(Person p in myTrip.passengerList)
            {
                Console.WriteLine(p.name);

            }


            Console.ReadKey();


        }


        static void MyTripMethod2()
        {
            LandVehicle myCar = new LandVehicle("Toyota", "Corolla", "2015", "White");
            Person me = new Person("Cary Baer");
            Trip myTrip = new Trip("Los Angeles", "Toronto", myCar, me);
            myTrip.passengerList.Add(new Person("William Shakespeare"));
            myTrip.passengerList.Add(new Person("Captain Kirk"));


            string outputStr = string.Format("{0} is taking a trip from {1} to {2} in his {3} {4} {5} {6}."
            , myTrip.driver.name, myTrip.startLocation, myTrip.endLocation, myTrip.vehicle.year, (myTrip.vehicle as LandVehicle).Color, myTrip.vehicle.maker, myTrip.vehicle.model);
            Console.WriteLine(outputStr);

            Console.WriteLine("Also going on the trip are:");
            foreach (Person p in myTrip.passengerList)
            {
                Console.WriteLine(p.name);

            }


            Console.ReadKey();


        }




    }
}
