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
            Random rnd = new Random(Guid.NewGuid().GetHashCode()); //generates a new sequence each time the method is called
            int RandomPlay = rnd.Next(1, 3);

            if (RandomPlay == 1)
                {
                    return "Rock";
                }
                else if (RandomPlay == 2)
                {
                    return "Paper";
                }
                else if (RandomPlay == 3)
                {
                    return "Scissors";
                }

            return generateRoshambo();
            // return random value of 1, 2, or 3. If 1, return Rock, if 2, return Paper, if 3, return Scissors
        }
    }
}
