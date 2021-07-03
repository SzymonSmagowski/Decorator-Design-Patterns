using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskX1
{
    class Warrior : IToy
    {
        public Warrior()
        {
            
        }
        public float Cost()
        {
            return 150f;
        }

        public string Summary()
        {
            return "I am a warrior!\n" + "I have " + Height() + " cm height\n";
        }
        
        public float Height()
        {
            return 160f;
        }
    }
}
