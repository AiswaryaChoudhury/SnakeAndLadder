using System;

namespace SnakeAndLadder
{
    class Program
    { 
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Snake and Ladder game Player");
            GamePlay game = new GamePlay();
            game.Play();
        }
    }
}
