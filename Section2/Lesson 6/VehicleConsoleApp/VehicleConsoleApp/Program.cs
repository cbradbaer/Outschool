using System;

namespace VehicleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            landvehicle myCar = new landvehicle();
            myCar.maker = "Toyota";
            myCar.model = "Corolla";
            myCar.year = 2015;
            myCar.color = "white";

            person me = new person();
            me.name = "Cary Baer";
            person pass1 = new person();
            pass1.name = "John Smith";
            person pass2 = new person();
            pass2.name = "Steve Buscemi";

            trip myTrip = new trip("LA","Houston",DateTime.Now,myCar,me);
            myTrip.passengerList.Add(pass1);
            myTrip.passengerList.Add(pass2);

            //Console.WriteLine(myTrip.driver.name + " is taking the " + myCar.year +
            //        " " + myCar.maker + " " + myCar.model + " on a trip from " +
            //        myTrip.startLocation + " to " + myTrip.endLocation + " at " +
            //        myTrip.startTime);

            string outputStr = string.Format("{0} is taking the {1} {2} {3} on a trip from {4} to {5} at {6}",
                                myTrip.driver.name, myCar.year, myCar.maker, myCar.model, myTrip.startLocation,
                                myTrip.endLocation, myTrip.startTime);

            Console.WriteLine(outputStr);


            Console.WriteLine("Also going on the trip are: ");
            foreach(person p in myTrip.passengerList)
            {
                Console.WriteLine(p.name);
            }

            Console.ReadKey();


        }
    }
}
