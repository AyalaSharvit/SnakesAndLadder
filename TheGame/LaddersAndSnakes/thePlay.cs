using LaddersAndSnakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaddersAndSnakes
{
  public static class thePlay
  {
   

    public static (int, int) ThePlay(int sumUser1, int sumUser2, string name, string moreName)//כל השאלות פה זה לבדוק האם המשבצת היא פה של נחש או ראש של סולם או תחילה של סולם או משבצת זהב
    {
      int chockeSqureFromSnake = Array.IndexOf(snake.MouthSnakes, sumUser1);//בדיקת המשבצת מפנ פה של נחש
      int chockeSqureFromStartLadder = Array.IndexOf(ladder.StartLadder, sumUser1);//בדיקת המשבצת מפני תחילת סולם
      int chockeSqureFromEndLadder = Array.IndexOf(ladder.EndLadder, sumUser1);//בדיקת המשבצת מפני סוף סולם

      if (chockeSqureFromSnake != -1)
      {
        sumUser1 = snake.TailSnakes[chockeSqureFromSnake];
        Console.WriteLine("'" + name + "'" + " has landed on a snake ");
        Console.WriteLine("'" + name + "'" + " is on " + sumUser1);
      }
      else
        if (chockeSqureFromStartLadder != -1)
      {
        sumUser1 = ladder.EndLadder[chockeSqureFromStartLadder];
        Console.WriteLine("'" + name + "'" + " has landed on a ladder ");
        Console.WriteLine("'" + name + "'" + " is on " + sumUser1);
      }
      else
        if (chockeSqureFromEndLadder != -1)
      {
        sumUser1 = ladder.StartLadder[chockeSqureFromEndLadder];
        Console.WriteLine("'" + name + "'" + " has landed on a ladder ");
        Console.WriteLine("'" + name + "'" + " is on " + sumUser1);
      }
      else
        if (sumUser1 == goldenTiles.golden1 || sumUser1 == goldenTiles.golden2)// בדיקת המשבצת מפני משבצות זהב
      {
        if (sumUser2 > sumUser1)
        {
          int tmp = sumUser1;
          sumUser1 = sumUser2;
          sumUser2 = tmp;
          Console.WriteLine("'" + name + "'" + " landed on golden tile and switched with " + "'" + moreName );
        }
      }

      else
        Console.WriteLine("'" + name + "'" + " is on " + sumUser1);
      return (sumUser1, sumUser2);


    }



    public static void AllTheProcessOfTheGame()
    {
      int user1 = 0;
      int user2 = 0;
      int flag = 1;
      int sumUser1 = 0;
      int sumUser2 = 0;
      string name1 = "Robbyn";
      string name2 = "Grethel";
      Random dice = new Random();
      //Console.WriteLine("Enter the number of ladders")
      //  int numOfLadders = Console.ReadLine(); הועבר למיין
      // ladder.CreateALadders(ladder.numOfLadders);
      //Console.WriteLine("Enter the number of Snakes");
      //int numOfSnakes = Console.ReadLine();
      // snake.CreateASnakes(snake.numOfSnakes);
      // goldenTiles.CreateAGoldenTiles();
      int numRound = 1;

      while ((sumUser1 <= 100) && (sumUser2 <= 100))
      {
        Console.WriteLine("round " + numRound++);
        if (flag == 1)
        {
          Random rand = new Random();
          int diceOfUser1 = rand.Next(1, 13);//יגריל מספר בין 1 ל 12 כמספר שיצא בקוביות לשחקן הראשון
          Console.WriteLine("'Robbyn' rolled " + diceOfUser1);
          sumUser1 += diceOfUser1;
          ThePlay(sumUser1, sumUser2, name1, name2);
          // Console.WriteLine("'Robbyn' is on " + sumUser1);
          flag = 2;
        }
        if (flag == 2)
        {
          Random rand = new Random();
          int diceOfUser2 = rand.Next(1, 13);//יגריל מספר בין 1 ל 12 כמספר שיצא בקוביות לשחקן הראשון
          Console.WriteLine("'Grethel' rolled " + diceOfUser2);
          sumUser2 += diceOfUser2;
          ThePlay(sumUser2, sumUser1, name2, name1);
          // Console.WriteLine("'Grethel' is on " + sumUser2);
          flag = 1;
        }
      }
        if (sumUser1 >= 100)
        {
          Console.WriteLine("'Robbyn' has won!");

        }
        else
          if (sumUser2 >= 100)
        {
          Console.WriteLine("'Grethel' has won!");
         
        }
       
        //switch (sumUser1 >= 100 || sumUser2 >= 100)
        //{
        //  case (sumUser1 >= 100)?:
        //    Console.WriteLine("'Robbyn' has won!");
        //    break;
        //  case
        //  if( sumUser2 >= 100):
        //    Console.WriteLine("'Grethel' has won!");
        //    break;

        //  default:
        //    Console.WriteLine("You have a problem! No one won!");
        //    break;
        //}
      }
    }
  }

