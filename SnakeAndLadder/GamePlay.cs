using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class GamePlay
    {

        static int STARTING_POSITION = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NOPLAY = 0;
        Random random = new Random();
        public int rollDice()
        {
            STARTING_POSITION = random.Next(1, 7);
            return (STARTING_POSITION == 0 ? 1 : STARTING_POSITION);
        }
        public void Play()
        {
            int diceValue = 0, option, position;
            position = STARTING_POSITION;
            diceValue = rollDice();
            option = random.Next(0, 3);

            switch (option)
            {
                case NOPLAY:
                    Console.WriteLine("No Play , Pass the chance");
                    break;
                case LADDER:
                    Console.WriteLine("You got ladder");
                    position += diceValue;
                    Console.WriteLine("Your position is :" + position);
                    break;
                case SNAKE:
                    Console.WriteLine("You got Snake");
                    position -= diceValue;
                    if (position < 0)
                        Console.WriteLine("Your position is 0 ");
                    else
                        Console.WriteLine("Your position is :" + position);
                    break;
                default:
                    break;
            }
        }
    }
}
