using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaddersAndSnakes
{
  public static class ladder
  {
    public static int numOfLadders;
    public static int[] StartLadder = null;
 
    public static int[] EndLadder = null;
    public static int start=0;
    public static int end=0;
    public static void CreateALadders(int numOfLadders)
    {
      

      Random rand = new Random();

      while (numOfLadders >= 49)
      {
        Console.WriteLine("The number of ladders is too large");
        Console.WriteLine("Enter another number of ladders");
        numOfLadders = Convert.ToInt32(Console.ReadLine());
      }
      StartLadder = new int[numOfLadders];
      EndLadder = new int[numOfLadders];
      Console.WriteLine("ladders");
      for (int i = 0; i < numOfLadders; i++)
      {
        do
        {
          start = rand.Next(1, 90);
          end = rand.Next(((start / 10 + 1) * (10))+1, 100);
        }
        while (StartLadder.Contains(start) || StartLadder.Contains(end) || EndLadder.Contains(start) || EndLadder.Contains(end));
        //// לעשות פונקציה שעוברת על שתי המערכים ובודקת אם השתמשו כבר במספר
        //וגם המספר לא מופיע אף פעם תבדוק אם יש סולם שהוא פחות מ10 צעדים וגם זה לא שסוף הסולם זה 1 ותחילת הסולם זה 0 וגם ששתי המספרים הם לא באותה שורה 
        StartLadder[i] = start;
        EndLadder[i] = end;
        //כך יוצא ששתי המערכים מלאים בתחילת הסולם ובסוף הסולם בהתאמה- האיבר הראשון בשתי המערכים שייך לסולם הראשוןו- במערך 1 לתחילת הסולם ובמערך השני לסוף הסולם.
       
      }
    
    }
    public static void PrintTheLadders()
    {
      CreateALadders(numOfLadders);
      int length = StartLadder.Length;
      for (int i = 0; i < length; i++)
      {
        Console.WriteLine(EndLadder[i] + " <= " + StartLadder[i] );
      }
    
    }

  }
}



