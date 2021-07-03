using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskX1
{
    class Doll : IToy
    {
        public Doll()
        {
            
        }
        public float Cost()
        {
            return 100f;
        }

        public string Summary()
        {
            
            return "I am a Doll\n" + "I have " + Height() + " cm height\n";
        }
        public float Height()
        {
            return 100f;
        }
    }
}
