using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            OpponentSelect();

            RandomPlayerSharks Opponent1 = new RandomPlayerSharks();
            RockPlayerJets Opponent2 = new RockPlayerJets();
            HumanPlayer User = new HumanPlayer();

            string Player1 = Opponent1.generateRoshambo();
            string Player2 = Opponent2.generateRoshambo();
            string Player3 = User.generateRoshambo();

            if (Player3 == Player1 || Player3 == Player2 || Player1 == Player2)
            {
                Console.WriteLine("It's a tie!");
            }

            else if (Player3 == "Rock" && Player2 == "Scissors" || Player3 == "Rock" && Player1 == "Scissors" || Player3 == "Scissors" && Player2 == "Paper" || Player3 == "Scissors" && Player1 == "Paper")
            {
                Console.WriteLine("You win!");
            }

            else if (Player2 == "Rock" && Player3 == "Scissors" || Player2 == "Rock" && Player1 == "Scissors" || Player2 == "Scissors" && Player3 == "Paper" || Player2 == "Scissors" && Player1 == "Paper")
            {
                Console.WriteLine("Player two wins!");
            }
            
            else if (Player1 == "Rock" && Player2 == "Scissors" || Player1 == "Rock" && Player3 == "Scissors" || Player1 == "Scissors" && Player2 == "Paper" || Player1 == "Scissors" && Player3 == "Paper")
            {
                Console.WriteLine("Player three wins!");
            }

        }

        public static void OpponentSelect()
        {
            Console.WriteLine("Would you like to play against The Jets or The Sharks? (J/S?):");

            string choice = Console.ReadLine().ToLower();

            RandomPlayerSharks Opponent1 = new RandomPlayerSharks();
            RockPlayerJets Opponent2 = new RockPlayerJets();

            string Player1 = Opponent1.generateRoshambo();
            string Player2 = Opponent2.generateRoshambo();


            if (choice == "J")
            {
                Opponent2.generateRoshambo();
            }
            
            if (choice == "S")
            {
                Opponent1.generateRoshambo();
            }
}
    }
}