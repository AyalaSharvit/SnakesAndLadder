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
        const string Player1 = "Robbyn";
        const string Player2 = "Grethel";

        public static void ThePlay(ref int sumPlayer1, ref int sumPlayer2, string namePlayer1, string nameMorePlayer)//כל השאלות פה זה לבדוק האם המשבצת היא פה של נחש או ראש של סולם או תחילה של סולם או משבצת זהב
        {
            int chockeSqureFromSnake = Array.IndexOf(snake.MouthSnakes, sumPlayer1);//בדיקת המשבצת מפנ פה של נחש
            int chockeSqureFromStartLadder = Array.IndexOf(ladder.StartLadder, sumPlayer1);//בדיקת המשבצת מפני תחילת סולם
            if (chockeSqureFromSnake != -1)
            {
                sumPlayer1 = snake.TailSnakes[chockeSqureFromSnake];
                Console.WriteLine("'" + namePlayer1 + "'" + " has landed on a snake ");
                Console.WriteLine("'" + namePlayer1 + "'" + " is on " + sumPlayer1);
            }
            else
              if (chockeSqureFromStartLadder != -1)
            {
                sumPlayer1 = ladder.EndLadder[chockeSqureFromStartLadder];
                Console.WriteLine("'" + namePlayer1 + "'" + " has landed on a ladder ");
                Console.WriteLine("'" + namePlayer1 + "'" + " is on " + sumPlayer1);
            }
            
            else
              if (sumPlayer1 == goldenTiles.golden1 || sumPlayer1 == goldenTiles.golden2)// בדיקת המשבצת מפני משבצות זהב
            {
                if (sumPlayer2 > sumPlayer1)
                {
                    int tmp = sumPlayer1;
                    sumPlayer1 = sumPlayer2;
                    sumPlayer2 = tmp;
                    Console.WriteLine("'" + namePlayer1 + "'" + " landed on golden tile and switched with " + "'" + nameMorePlayer);
                }
            }

            else if(sumPlayer1 < 100)
                 
                Console.WriteLine("'" + namePlayer1 + "'" + " is on " + sumPlayer1);


        }


        public static void AllTheProcessOfTheGame()
        {

            int flag = 1;
            int sumPlayer1 = 0;
            int sumPlayer2 = 0;

            Random dice = new Random();

            int numRound = 1;

            while ((sumPlayer1 <= 100) && (sumPlayer2 <= 100))
            {
                Console.WriteLine("round " + numRound++);
                if (flag == 1)
                {
                    Random rand = new Random();
                    int diceOfUser1 = rand.Next(1, 13);
                    Console.WriteLine("'Robbyn' rolled " + diceOfUser1);
                    sumPlayer1 += diceOfUser1;
                    ThePlay(ref sumPlayer1, ref sumPlayer2, Player1, Player2);
                    flag = 2;
                }
                if (flag == 2)
                {
                    Random rand = new Random();
                    int diceOfUser2 = rand.Next(1, 13);
                    Console.WriteLine("'Grethel' rolled " + diceOfUser2);
                    sumPlayer2 += diceOfUser2;
                    ThePlay(ref sumPlayer2, ref sumPlayer1, Player2, Player1);

                    flag = 1;
                }
            }
            if (sumPlayer1 >= 100)
            {
                Console.WriteLine("'Robbyn' has won!");

            }
            else
              if (sumPlayer2 >= 100)
            {
                Console.WriteLine("'Grethel' has won!");

            }


        }
    }
}

