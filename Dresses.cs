using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX1
{
    class DottedDress : Decorator
    {
        public DottedDress(IToy _toy) : base(_toy)
        {
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 19.99f;
        }
        public override string Summary()
        {
            
            return base.Summary() + "I have a dotted dress.\n";
        }
    }
    class FlowerDress : Decorator
    {
        public FlowerDress(IToy _toy) : base(_toy)
        {
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 20f;
        }
        public override string Summary()
        {
            
            return base.Summary() + "I have a flower dress.\n";
        }
    }
}
