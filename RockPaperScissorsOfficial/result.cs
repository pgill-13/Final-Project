using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsOfficial
{
    class result
    {
        public static void Outcome(int computer, int player)
        {
            if (computer == player)
                Console.WriteLine("We have a draw, neither player wins or loses!");
            else
            if (computer == 1 && player == 3)
                Console.WriteLine("Rock smashes Scissors, Computer wins!");
            else
            if (computer == 2 && player == 1)
                Console.WriteLine("Paper covers Rock, Computer wins!");
            else
            if (computer == 3 && player == 2)
                Console.WriteLine("Scissors cut Paper, Computer wins!");
            else
            if (computer == 3 && player == 1)
                Console.WriteLine("Rock smashes Scissors, Player wins!");
            else
            if (computer == 1 && player == 2)
                Console.WriteLine("Paper covers Rock, Player wins!");
            else
            if (computer == 2 && player == 3)
                Console.WriteLine("Scissors cut Paper, Player wins!");
        }
    }
}
