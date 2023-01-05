using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderUC2
{
    public  class SnakeAndLadder
    {
        public static void DieRoll()
        {
            int Position1 = 0;
            int DieRoll=0;
            Console.WriteLine("Initial Position Of Player1 is:" + Position1);

            //Random Function To Roll Die 1 To 6
            Random random = new Random();
            //Range Taken From 1 To 7 Due To Die Have 1 to 6 Number 
            int empCheck = random.Next(1, 7);
            Console.WriteLine("Die Roll :" + DieRoll);
            Position1 = DieRoll;
            Console.WriteLine("Position of Player1 after DieRoll is :" + Position1);
            Console.ReadLine();
        }
    }
}
