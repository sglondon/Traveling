using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
    class RentalCar : Travel
    {
        public RentalCar()
        {
            //default constructor
        }

        //addt'l fields

        private int newValue;
        private string car;


        //addt'l property

        public int NewValue
        {
            get { return this.newValue; }
            set { this.newValue = value; }
        }

        public string Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        //new methods 



        public int CarValue(int location, double size)
        {
            if ((size + location) % 2 == 0)
            {
                //Console.WriteLine("the number was evenly divisible by 2");
                return 2;
            }

            else if ((size + location) % 3 == 0)
            {
                //Console.WriteLine("the number was evenly divisible by 3");
                return 3;
            }
            else
            {
                return 0;
            }
        }

        public string CarName(int newValue)
        {
            if (newValue == 2)
            {
                return "yellow Honda Fit";
            }
            else if (newValue == 3)
            {
                return "black & white Range Rover";
            }
            else return "blue Jeep Cherokee";

        }


        //    override methods from base class - not used

        public override int SetEyeValue(string color)
        {
            return 0;

        }
        public override string GetBeachLoc(int loc)
        {
            return "";
        }








    }
}
