using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX1
{
    class JumpPossibility : Decorator
    {
        public JumpPossibility(IToy _toy) : base(_toy)
        {
            countJump = 5;
            
        }
        public override float Cost()
        {
            
            return base.Cost() + 20f;
        }
        public override string Summary()
        {
            
            string jumping = "";
            if (countJump != 0)
            {
                jumping = "I can jump! I have just jumped " + (countJump) * 0.1 * Height() + " cm\n";
                countJump--;
            }
            return base.Summary() + jumping;
        }
    }
}
