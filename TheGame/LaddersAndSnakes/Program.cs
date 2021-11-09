using System;

namespace LaddersAndSnakes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("You can choose a total of 49 ladders and snakes");
            Console.WriteLine("Enter the number of ladders");
            ladder.numOfLadders = Convert.ToInt32(Console.ReadLine());
            ladder.CheckNumLadders(ref ladder.numOfLadders);
            Console.WriteLine("Enter the number of Snakes");
            snake.numOfSnakes = Convert.ToInt32(Console.ReadLine());
            snake.CheckNumSnakes(ref snake.numOfSnakes);
            ladder.PrintTheLadders();
            snake.PrintTheSnakes();
            goldenTiles.PrintTheGoldenTiles();
            Console.WriteLine("Simulation Started");
            thePlay.AllTheProcessOfTheGame();
        }
    }
}




















