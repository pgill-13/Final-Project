using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsOfficial
{
    class CPU_Input
    {
        public static int ComputerWeapon()
        {
            Random weapon = new Random();
            int computer = weapon.Next(1, 4);
            if (computer == 1)
                Console.WriteLine("Computer chooses Rock");
            else
             if (computer == 2)
                        Console.WriteLine("Computer chooses Paper");
                    else
             if (computer == 3)
                Console.WriteLine("Computer chooses Scissors");
            return computer;
        }
    }
}
