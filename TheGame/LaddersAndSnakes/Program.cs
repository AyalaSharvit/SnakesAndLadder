using System;

namespace LaddersAndSnakes
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of ladders");
            ladder.numOfLadders = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Snakes");
            snake.numOfSnakes = Convert.ToInt32(Console.ReadLine());
            ladder.PrintTheLadders();
            snake.PrintTheSnakes();
            goldenTiles.PrintTheGoldenTiles();
            Console.WriteLine("Simulation Started");
            thePlay.AllTheProcessOfTheGame();
        }
    }
}




















