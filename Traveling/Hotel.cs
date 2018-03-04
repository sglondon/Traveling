using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
    class Hotel:Travel
    {

    //constructors

        public Hotel()
        {
            //default constructor
        }

        //addt'l fields

        private double shoeSize;


        //addt'l property

        public double ShoeSize
        {
            get { return this.shoeSize; }
            set { this.shoeSize = value; }
        }

        //method

        public string GetHotel(double size, int location)
        {
            if ((size == 10.5) && (location == 1))
            {
                return "You'll be staying at the Marriott";
            }
            else if ((size == 10.5) && (location == 2))
            {
                return "You'll be staying at the Best Western";
            }
            else if ((size == 10.5) && (location == 3))
            {
                return "You'll be staying at the Travel Lodge Inn";
            }

            else if ((size == 6.5) && (location == 1))
            {
                return "You'll be staying at the Holiday Inn";
            }
            else if ((size == 6.5) && (location == 2))
            {
                return "you'll be staying at the Radisson";
            }
            else if ((size == 6.5) && (location == 3))
            {
                return "You'll be staying at the Hyatt";
            }
            else return "You'll be sleeping on the sand";
        }

        //override methods from base class - not used

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
