using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    class Dracula : Tanks
    {
        public override void tankModel()
        {
            Console.WriteLine("Tier VII Special Halloween Edition Tank: Dracula");
        }
    }
}
