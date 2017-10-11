using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RandomPlayerSharks:Player
    {
        public override string generateRoshambo()
        {
            Random choice = new Random();
            for (int i = 0; i < 4; i++)
            {
                if (choice = 1)
                {
                    return "Rock";
                }
                else if (choice = 2)
                {
                    return "Paper";
                }
                else if (choice = 3)
                {
                    return "Scissors";
                }
                
            }
            // return random value of 1, 2, or 3. If 1, return Rock, if 2, return Paper, if 3, return Scissors
        }
    }
}
