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
            
            if (HumanChoice == "R")
            {
                return "Rock";
            }

            else if (HumanChoice == "P")
            {
                return "Paper";
            }

            else if (HumanChoice == "R")
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
