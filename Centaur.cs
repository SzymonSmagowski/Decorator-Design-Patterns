using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX1
{
    class Centaur : IToy
    {
        private readonly int age;
        private readonly string name;
        private readonly string hasBeard;
        public Centaur(string _name)
        {
            name = _name;
            Random rnd = new();
            age = rnd.Next(1, 11);
            if (rnd.Next() % 2 == 0)
            {
                hasBeard = "I do have a beard";
            }
            else
            {
                hasBeard = "I do not have a beard";
            }
        }
        public float Cost()
        {
            return 250f;
        }

        public string Summary()
        {
            return "I am a Centaur \nI am " + Height() + " cm high.\n" +
                "My age is "+age+"\nMy name is "+name+"\n"+hasBeard+"\n";
        }
        public float Height()
        {
            return 180f;
        }

    }
}

