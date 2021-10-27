using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    class Tiger : Tanks
    {
        public override void tankModel()
        {
            Console.WriteLine("Tier VII Tank: Tiger II");
        }
    }
}
