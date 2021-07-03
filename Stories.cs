using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX1
{
    class ScaryStory : Decorator
    {
        public ScaryStory(IToy _toy) : base(_toy)
        {
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 30f;
        }
        public override string Summary()
        {
            
            return base.Summary() + "I can tell scary stories!\n";
        }
    }
    class FunnyJoke : Decorator
    {
        public FunnyJoke(IToy _toy) : base(_toy)
        {
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 30f;
        }
        public override string Summary()
        {
            
            return base.Summary() + "I can tell really funny jokes!\n";
        }
    }
}
