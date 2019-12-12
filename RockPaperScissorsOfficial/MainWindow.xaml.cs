using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsOfficial
{
    class Program
    {
       

        private int player = 1;
        private string playGame;
        private int computer = 2;

        public void Main(string[] args)
        {
            Console.Write("Would you like to play Rock, Paper, Scissors?");
            playGame = Console.ReadLine();
            playGame = playGame.ToLower();

            while (playGame == "yes")
            {
                player = UserInput.UserWeapon();
                computer = CPU_Input.ComputerWeapon();
                result.Outcome(computer, player);
                Console.Write("Would you like to play again?");
                playGame = Console.ReadLine();
                playGame = playGame.ToLower();
            }
            Console.WriteLine("Thank you for playing Rock, Paper, Scissors!");

        }
    }
}
