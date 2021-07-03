using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX1
{
    class Minotaur : IToy
    {
        private readonly int age;
        private readonly string name;
        private readonly int mass;
        public Minotaur(string _name)
        {
            name = _name;
            Random rnd = new();
            age = rnd.Next(1, 11);
            mass = rnd.Next(1, 71);
        }
        public float Cost()
        {
            return 250f;
        }

        public string Summary()
        {
            return  "I am a Minotaur \nI am " + Height() + " cm high.\n"
                +"My age is " + age + "\nMy name is " + name + "\nI weight " + mass + " kg\n";
        }
        public float Height()
        {
            return 200f;
        }
    }
}

