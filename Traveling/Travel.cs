using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
    public abstract class Travel
    {

        //invisible fields

        //properties

        public string EyeColor { get; set; }
        public string BeachName { get; set; }
        

        //abstract methods
        public abstract int SetEyeValue(string color);
        public abstract string GetBeachLoc(int loc);
        

    }

    


}
