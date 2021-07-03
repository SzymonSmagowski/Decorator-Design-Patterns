using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX1
{
    abstract class Decorator : IToy
    {
    

        public IToy Toy { set; get; }
        public int countJump;
        public Decorator(IToy _toy)
        {
            Toy = _toy;
            
        }
        public virtual float Cost()
        {
            return Toy.Cost();
        }
        public virtual string Summary()
        {
            return Toy.Summary();
        }
        public virtual float Height()
        {
            return Toy.Height();
        }
        
    }

}
