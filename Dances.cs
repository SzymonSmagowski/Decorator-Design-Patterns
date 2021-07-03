using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX1
{
    class Breakdance : Decorator
    {
        public Breakdance(IToy _toy) : base(_toy)
        {
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 50f;
        }
        public override string Summary()
        {
            
            return base.Summary() + "I can dance breakdance\n";
        }
    }
    class SoloCapoeira : Decorator
    {
        public SoloCapoeira(IToy _toy) : base(_toy)
        {
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 70f;
        }
        public override string Summary()
        {
            
            return base.Summary() + "I can dance solo capoeira\n";
        }
    }
    class GangnamStyle : Decorator
    {
        public GangnamStyle(IToy _toy) : base(_toy)
        {
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 100f;
        }
        public override string Summary()
        {
            
            return base.Summary() + "I can dance gangnam style\n";
        }
    }
}
