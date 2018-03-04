using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
  public class Beach :Travel
    {
        //addt'l fields

        private int eyeValue;


        //addt'l property

        public int EyeValue
        {
            get { return this.eyeValue; }
            set { this.eyeValue = value; }
        }

        public Beach()
        {
            //default constructor
        }


        public Beach(string eyeColor, string beachName, int eyeValue)
        {
            EyeColor = eyeColor;
            BeachName = beachName;
            EyeValue = eyeValue;
        }
        //methods



        //void method, if true return consolewriteline

        public override string GetBeachLoc(int loc)
        {
            //   Console.WriteLine(loc);
            if (loc == 1)
            {
                return "Siesta Beach.";

            }
            else if (loc == 2)
            {
                return "Lido Beach.";

            }

            else if (loc == 3)
            {
                return "Venice Beach.";
            }
            else return "Lake Erie.";
        }
        // public override int seteyevalue(string color) should be returning an int



        public override int SetEyeValue(string color)
        {
            //    Console.WriteLine(color);
            if (color == "blue")
            {

                //    Console.WriteLine("returned 1");
                return 1;
            }
            else if (color == "brown")
            {
                return 2;
            }
            else if (color == "green")
            {
                return 3;
            }
            //      else Console.WriteLine("you're not returning any value");
            return 0;

        }


        

    }
}
