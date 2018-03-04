using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiate derived classes
            Beach loc1 = new Beach();
            Hotel loc2 = new Hotel();
            RentalCar rCar = new RentalCar();

            //loc1.GetBeachLoc(loc1.SetEyeValue(color));
            //get user input

            Console.WriteLine("Welcome to our automated Travel Center application!");
            Console.WriteLine();
            Console.WriteLine("Your trip details will be assigned to you based on your answers to the following questions:");
            Console.WriteLine();
            Console.WriteLine("What is your eye color?");
            string color = Console.ReadLine().ToLower();
            int location = loc1.SetEyeValue(color);
            string vacSpot = loc1.GetBeachLoc(location);

            Console.WriteLine("What is your shoe size?");
            double size = Convert.ToDouble(Console.ReadLine());

            string hotel = loc2.GetHotel(size, location);
            int newValue = rCar.CarValue(location, size);            
            string car = rCar.CarName(newValue);
            Console.WriteLine("You'll be vacationing at " + vacSpot + " " + hotel + " and you'll be driving a " + car + " rental car.");


        }






    }
}

