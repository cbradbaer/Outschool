using System;

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
            string outputString = string.Format("{0} is take the  {1} {2} {3} on a trip from {4} to {5}",
                  myTrip.driver.Name, myTrip.vehicle.year, myTrip.vehicle.maker, myTrip.vehicle.model,
                  myTrip.startLocation, myTrip.endLocation);

            Console.WriteLine(outputString);
            Console.WriteLine("These people are also going on the trip:");
            foreach (Person p in myTrip.passengerList)
            {
                Console.WriteLine(p.Name);
            }


            Console.ReadKey();
             


        }





        static void MyTripMethod1()
        {

            LandVehicle myCar = new LandVehicle();
            Person me = new Person();
            Person passenger1 = new Person();
            Person passenger2 = new Person();
            Trip myTrip = new Trip();

            myCar.maker = "Toyota";
            myCar.model = "Corolla";
            myCar.year = 2015;

            me.Name = "Cary Baer";
            passenger1.Name = "John Smith";
            passenger2.Name = "Jane Doe";

            myTrip.startLocation = "Los Angeles";
            myTrip.endLocation = "Houston";
            myTrip.driver = me;
            myTrip.startTime = DateTime.Now;
            myTrip.passengerList.Add(passenger1);
            myTrip.passengerList.Add(passenger2);
            myTrip.vehicle = myCar;

            string outputString = myTrip.driver.Name + " is taking the " + myTrip.vehicle.year + " " +
                myTrip.vehicle.maker + " " + myTrip.vehicle.model + " on a trip from " +
                myTrip.startLocation + " to " + myTrip.endLocation;

            Console.WriteLine(outputString);
            Console.ReadKey();


        }



    }
}
