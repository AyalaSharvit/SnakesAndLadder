using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaddersAndSnakes
{
  public static class goldenTiles
  {
    public static int golden1;
    public static int golden2;
    
    public static void CreateAGoldenTiles()
    {
      Random rand = new Random();
      do
      {
         golden1 = rand.Next(1, 101);
         golden2 = rand.Next(1, 101);

      }
      while (golden1==golden2 || ladder.StartLadder.Contains( golden1) || ladder.StartLadder.Contains( golden1) || ladder.EndLadder.Contains( golden1) || ladder.EndLadder.Contains(golden1) || snake.TailSnakes.Contains( golden1) || snake.TailSnakes.Contains(golden1) || snake.MouthSnakes.Contains(golden1) || snake.MouthSnakes.Contains(golden1)|| ladder.StartLadder.Contains(golden2) || ladder.StartLadder.Contains(golden2) || ladder.EndLadder.Contains(golden2) || ladder.EndLadder.Contains(golden2) || snake.TailSnakes.Contains(golden2) || snake.TailSnakes.Contains(golden2) || snake.MouthSnakes.Contains(golden2) || snake.MouthSnakes.Contains(golden2));

    }
    public static void PrintTheGoldenTiles()
    {
      CreateAGoldenTiles();
      Console.WriteLine("golden tiles  " + golden1 + "  " + golden2 );
    }

  }
}
