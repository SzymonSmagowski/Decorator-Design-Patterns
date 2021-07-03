using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskX1
{
    class RaceDriver : IToy
    {
        
        public RaceDriver()
        {
           
        }
        public float Cost()
        {
            return 200f;
        }

        public string Summary()
        {
            return "I am a Race Driver\n" + "I have " + Height() + " cm height\n";
        }
        public float Height()
        {
            return 120f;
        }
    }
}