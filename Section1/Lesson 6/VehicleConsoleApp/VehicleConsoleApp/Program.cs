using System;
using VehicleConsoleApp.Models;

namespace VehicleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            MyTripMethod1();
            MyTripMethod2();




        }



        static void MyTripMethod2()
        {
            LandVehicleModel myCar = new LandVehicleModel("Toyota", "Corolla", "2015");
            PersonModel me = new PersonModel("Cary");
            TripModel myTrip = new TripModel("Los Angeles", "Houston", me, myCar);

            myTrip.passengerList.Add(new PersonModel("Donald Trump"));
            myTrip.passengerList.Add(new PersonModel("Hillary Clinton"));


            string outputString = $"{myTrip.driver.name} is taking the {myTrip.vehicle.year} {myTrip.vehicle.maker} {myTrip.vehicle.model} on a trip from {myTrip.startLocation} to {myTrip.endLocation}";


            Console.WriteLine(outputString);

            Console.WriteLine("Also going on the trip are:  ");

            foreach (PersonModel p in myTrip.passengerList)
                Console.WriteLine(p.name);




            Console.ReadKey();


        }



        static void MyTripMethod1()
        {
            LandVehicleModel myCar = new LandVehicleModel();
            PersonModel me = new PersonModel();
            PersonModel pass1 = new PersonModel();
            PersonModel pass2 = new PersonModel();
            TripModel myTrip = new TripModel();

            myCar.year = "2015";
            myCar.maker = "Toyota";
            myCar.model = "Corolla";

            me.name = "Cary";
            pass1.name = "Donald Trump";
            pass2.name = "Hillary Clinton";

            myTrip.vehicle = myCar;
            myTrip.driver = me;
            myTrip.startLocation = "Los Angeles";
            myTrip.endLocation = "Houston";
            myTrip.passengerList.Add(pass1);
            myTrip.passengerList.Add(pass2);

            string outputString = $"{myTrip.driver.name} is taking the {myTrip.vehicle.year} {myTrip.vehicle.maker} {myTrip.vehicle.model} on a trip from {myTrip.startLocation} to {myTrip.endLocation}";


            Console.WriteLine(outputString);

            Console.WriteLine("Also going on the trip are:  ");
            
            foreach (PersonModel p in myTrip.passengerList)
                Console.WriteLine(p.name);


            
            
            Console.ReadKey();
        }


    }
}
