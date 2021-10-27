using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanks myTank = new Tanks();
            Tanks tankDeathSatr = new DeathStar();
            Tanks tankTiger = new Tiger();
            Tanks tankDracula = new Dracula();

            myTank.tankModel();
            tankDeathSatr.tankModel();
            tankTiger.tankModel();
            tankDracula.tankModel();

            Console.ReadKey();
        }
    }
}
