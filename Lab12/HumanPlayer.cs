using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer:Player
    {
        public override string generateRoshambo()
        {
            Console.WriteLine("Rock, paper, or scissors? (R/P/S?)");
            string HumanChoice = Console.ReadLine().ToLower();
            
            if (HumanChoice == "R" || HumanChoice == "r")
            {
                return "Rock";
            }

            else if (HumanChoice == "P" || HumanChoice== "p")
            {
                return "Paper";
            }

            else if (HumanChoice == "S" || HumanChoice == "s")
            {
                return "Scissors";
            }

            else
            {
                return "Please enter valid action"; //correct validation here
            }

        }
    }
}
