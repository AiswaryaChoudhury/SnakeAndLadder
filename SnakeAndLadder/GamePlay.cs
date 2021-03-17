using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class GamePlay
    {
        static int STARTING_POSITION = 0;
        public int rollDice()
        {
            Random random = new Random();
            STARTING_POSITION = random.Next(1, 7);
            return (STARTING_POSITION == 0 ? 1 : STARTING_POSITION);
        }
    }
}
