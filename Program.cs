using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRental
{
    // This app is intended to run a small auto rental business.
    // This business specializes in muscle cars from the 70s and 80s
    // Customers should be able to rent a car for day or multiple days.
    // The Car as an object will figure heavily in the software functionality
    // of the app. So we should have a Car class.
    internal class Program
    {
        // main is simply the test driver for us to test the car class and other
        // elements of the auto rental system.
        static void Main(string[] args)
        {
            // I want to be able to make a car object when a customer rents one.
            Car chuxCar = new Car();
            Car bobzCar = new Car(1967, "Black", "Ford Mustang 2+2", 59.99m);
            Car cindyzCar = new Car(1981, "Red", "Ferrari Boxer Berlinetta", 129.99m);
            Car alanzCar = new Car(1969, "Blue", "Chevrolet Chevelle", 79.99m);

            // I want to rent a 1979 silver porsche 930 turbo, rents for 119.99 per day
            chuxCar.YearModel = 1979;
            chuxCar.PaintColor = "Silver";
            chuxCar.MakeModel = "Porsche 930 Turbo";
            chuxCar.RentalPrice = 119.99m;

            //// for now, manually print out the C# props that are in a "car" obj
            //Console.WriteLine("******************************************");
            //Console.WriteLine($" Year: {chuxCar.YearModel}");
            //Console.WriteLine($"Color: {chuxCar.PaintColor}");
            //Console.WriteLine($"Model: {chuxCar.MakeModel}");
            //Console.WriteLine($"Price: {chuxCar.RentalPrice}");


            // I want to be able to "print out" chuxCar as an object
            Console.WriteLine(bobzCar);
            Console.WriteLine(chuxCar);
            Console.WriteLine(cindyzCar);
            Console.WriteLine(alanzCar);

            // block running program at the end - Enter key
            Console.ReadLine();

        }
    }
}
