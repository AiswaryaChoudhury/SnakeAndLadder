using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class GamePlay
    {

        static int STARTING_POSITION = 0;
        static int ENDING_POSITION = 100;
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
            int diceValue = 0, option, currentPosition, endPosition;
            diceValue = rollDice();
            option = random.Next(0, 3);
            endPosition = ENDING_POSITION;
            rollDice();
            for (currentPosition = STARTING_POSITION; currentPosition<= endPosition; currentPosition++)
            {
                if (currentPosition <= endPosition)
                {
                    switch (option)
                    {
                        case NOPLAY:
                            Console.WriteLine("No Play , Pass the chance");
                            break;
                        case LADDER:
                            if (currentPosition + diceValue <= ENDING_POSITION)
                            {
                                Console.WriteLine("You got Ladder");
                                currentPosition += diceValue;
                            }

                            Console.WriteLine("Your position is :" + currentPosition);
                            break;
                        case SNAKE:
                            if (currentPosition - diceValue >= STARTING_POSITION)
                            {
                                if (currentPosition < 0)
                                    Console.WriteLine("Your position is 0 ");
                                else
                                {
                                    Console.WriteLine("You got Snake");
                                    currentPosition -= diceValue;
                                    Console.WriteLine("Your position is :" + currentPosition);
                                }

                            }

                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid position");
                    currentPosition = currentPosition - diceValue;
                    Console.WriteLine("Your position is :" + currentPosition);

                }
            }

        }

    }
}
