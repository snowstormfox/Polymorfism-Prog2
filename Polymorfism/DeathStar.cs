using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    class DeathStar : Tanks
    {
        public override void tankModel()
        {
            Console.WriteLine("Tier X Tank: FV215b 183");
        }
    }
}
