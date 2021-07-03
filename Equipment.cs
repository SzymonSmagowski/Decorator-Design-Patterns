using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX1
{
    class Sword : Decorator
    {
        public Sword(IToy _toy) : base(_toy)
        {
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 15f;
        }
        public override string Summary()
        {
            
            return base.Summary() + "I have a sword.\n";
        }
    }
    class Helmet : Decorator
    {
        public Helmet(IToy _toy) : base(_toy)
        {
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 10f;
        }
        public override string Summary()
        {
            
            return base.Summary() + "I have a helmet on my head.\n";
        }
    }
}
