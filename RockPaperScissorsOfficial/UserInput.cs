using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsOfficial
{
    class UserInput
    {
        public static int UserWeapon()
        {
            Console.Write("Player, choose a weapon (1=Rock, 2=Paper, 3=Scissor): ");
            string player = Console.ReadLine();
            if (player == "")
            {
                Console.WriteLine("Player, You must select a Weapon");
                Environment.Exit(0);
            }
            int p = int.Parse(player);
            if (p < 1 | p > 3)
            {
                Console.WriteLine("Player, " + player + " - is not a valid weapon type");
                Environment.Exit(0);
            }
            return p;
        }
    }
}
