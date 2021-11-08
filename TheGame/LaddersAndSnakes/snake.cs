using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaddersAndSnakes
{
  public static class snake
  {
    public static int numOfSnakes;
    public static int[] TailSnakes = null ;
    public static int[] MouthSnakes = null ;
    public static int mouth=0;
    public static int tail=0;

   
      public static void CreateASnakes(int numOfSnakes)
    {
      Random rand = new Random();
     while ((ladder.numOfLadders+numOfSnakes)>=49)
      {
        Console.WriteLine("The number of ladders or snakes is too large");
        //Console.WriteLine("Enter another number of ladders");
        //ladder.numOfLadders = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter anouther number of Snakes");
        numOfSnakes = Convert.ToInt32(Console.ReadLine());
      }

      TailSnakes = new int[numOfSnakes];
      MouthSnakes = new int[numOfSnakes];

      Console.WriteLine("snakes");

      for (int i = 0; i < numOfSnakes; i++)
      {
        do
        {
          tail = rand.Next(1, 90);
          mouth = rand.Next(((tail / 10 + 1) * (10) )+1, 100);
        }

        while (ladder.StartLadder.Contains(mouth) || ladder.StartLadder.Contains(tail) || ladder.EndLadder.Contains(mouth) || ladder.EndLadder.Contains(tail) || TailSnakes.Contains(tail) || TailSnakes.Contains(mouth) || MouthSnakes.Contains(tail) || MouthSnakes.Contains(mouth));// לעשות פונקציה שעוברת על שתי המערכים ובודקת אם השתמשו כבר במספר
                                                                                                                                                                                                                                                                                                                                           //וגם המספר לא מופיע אף פעם תבדוק אם יש סולם שהוא פחות מ10 צעדים וגם זה לא שסוף הסולם זה 1 ותחילת הסולם זה 0 וגם ששתי המספרים הם לא באותה שורה 
        TailSnakes[i] = tail;
        MouthSnakes[i] = mouth;
        //כך יוצא ששתי המערכים מלאים בתחילת הסולם ובסוף הסולם בהתאמה- האיבר הראשון בשתי המערכים שייך לסולם הראשוןו- במערך 1 לתחילת הסולם ובמערך השני לסוף הסולם.
      }
    }
    public static void PrintTheSnakes()
    {
      CreateASnakes(numOfSnakes);
      int length = MouthSnakes.Length;
      for (int i = 0; i < length; i++)
      {
        Console.WriteLine(TailSnakes[i] + " <= " + MouthSnakes[i] );
      }
         
    }

  }
}
