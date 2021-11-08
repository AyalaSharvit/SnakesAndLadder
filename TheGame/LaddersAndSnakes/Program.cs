using System;

namespace LaddersAndSnakes
{
  class Program
  {
    public static void Main(string[] args)
    {
      //גם זה הוסף בתכנית החדשה
     
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



      //int user1 = 0;
      //int user2 = 0;
      //int flag = 1;
      //int sumUser1 = 0;
      //int sumUser2 = 0;
      //Random dice = new Random();
      //Console.WriteLine("Enter the number of ladders");
      //int numOfLadders = Console.ReadLine();
      //ladder.CreateALadders(numOfLadders);
      //Console.WriteLine("Enter the number of Snakes");
      //int numOfSnakes = Console.ReadLine();
      //snake.CreateASnakes(numOfSnakes);
      //goldenTiles.CreateAGoldenTiles();
      //while (sumUser1 || sumUser2 <= 100)
      //{
      //  if (flag = 1)
      //  {
      //    int diceOfUser1 = rand.Next(0, 13);//יגריל מספר בין 1 ל 12 כמספר שיצא בקוביות לשחקן הראשון
      //    sumUser1 += diceOfUser1;
      //    thePlay.ThaPlay(sumUser1, sumUser2);
      //    flag = 2;
      //  }
      //  if (flag = 2)
      //  {
      //    int diceOfUser2 = rand.Next(0, 13);//יגריל מספר בין 1 ל 12 כמספר שיצא בקוביות לשחקן הראשון
      //    sumUser2 += diceOfUser2;
      //    thePlay.ThaPlay(sumUser2, sumUser1);
      //    flag = 1;




         
         











        }
      }


   
    //public void CreateALadders(int numOfLadders)
    //{
    //  int[] StartLadder = new int[];
    //  int[] EndLadder = new int[];
    //  for (int i = 0; i < numOfLadders; i++)
    //  {
    //    do
    //    {
    //      Random rand = new Random();
    //      int start = rand.Next(1, 100);
    //      int end = rand.Next(1, 100);
    //      if (start > end)// אם יצא שראש הסולם יותר גדול מהסוף שלו אז תחליף בינהם
    //      {
    //        int temp = start;
    //        start = end;
    //        end = temp;
    //      }

    //    } while (end - start < 10 && end % 10 > start % 10 && end % 10 != 1 && start % 10 != 0 || StartLadder.find(start) || StartLadder.find(end) || EndLadder.find(start) || EndLadder.find(end));// לעשות פונקציה שעוברת על שתי המערכים ובודקת אם השתמשו כבר במספר
    //                                                                                                                                                                                                //וגם המספר לא מופיע אף פעם תבדוק אם יש סולם שהוא פחות מ10 צעדים וגם זה לא שסוף הסולם זה 1 ותחילת הסולם זה 0 וגם ששתי המספרים הם לא באותה שורה 
    //    StartLadder[i] = start;
    //    EndLadder[i] = end;
    //    //כך יוצא ששתי המערכים מלאים בתחילת הסולם ובסוף הסולם בהתאמה- האיבר הראשון בשתי המערכים שייך לסולם הראשוןו- במערך 1 לתחילת הסולם ובמערך השני לסוף הסולם.
    //  }
    //}


    //public void CreateASnakes(int numOfSnakes)
    //{
    //  int[] TailSnakes = new int[];
    //  int[] MouthSnakes = new int[];
    //  for (int i = 0; i < numOfSnakes; i++)
    //  {
    //    do
    //    {
    //      Random rand = new Random();
    //      int tail = rand.Next(1, 100);
    //      int mouth = rand.Next(1, 100);
    //      if (tail > mouth)// אם יצא שזנב הנחש יותר גדול מהפה שלו אז תחליף בינהם
    //      {
    //        int temp = tail;
    //        tail = mouth;
    //        mouth = temp;
    //      }

    //    } while (mouth - tail < 10 && mouth % 10 > tail % 10 && mouth % 10 != 1 && tail % 10 != 0 || StartLadder.find(start) || StartLadder.find(end) || EndLadder.find(start) || EndLadder.find(end) || TailSnakes.find(tail) || TailSnakes.find(mouth) || MouthSnakes.find(tail) || MouthSnakes.find(mouth));// לעשות פונקציה שעוברת על שתי המערכים ובודקת אם השתמשו כבר במספר
    //                                                                                                                                                                                                                                                                                                           //וגם המספר לא מופיע אף פעם תבדוק אם יש סולם שהוא פחות מ10 צעדים וגם זה לא שסוף הסולם זה 1 ותחילת הסולם זה 0 וגם ששתי המספרים הם לא באותה שורה 
    //    TailSnakes[i] = tail;
    //    MouthSnakes[i] = mouth;
    //    //כך יוצא ששתי המערכים מלאים בתחילת הסולם ובסוף הסולם בהתאמה- האיבר הראשון בשתי המערכים שייך לסולם הראשוןו- במערך 1 לתחילת הסולם ובמערך השני לסוף הסולם.
    //  }
    //}
    //public void CreateAGoldenTiles()
    //{
    //  Random rand = new Random();
    //  do
    //  {
    //    int golden1 = rand.Next(1, 100);
    //    int golden2 = rand.Next(1, 100);

    //  } while (StartLadder.find(start) || StartLadder.find(end) || EndLadder.find(start) || EndLadder.find(end) || TailSnakes.find(tail) || TailSnakes.find(mouth) || MouthSnakes.find(tail) || MouthSnakes.find(mouth));

    //}
  //  public (int,int) ThePlay(int sumUser1, int sumUser2)//כל השאלות פה זה לבדוק האם המשבצת היא פה של נחש או ראש של סולם או תחילה של סולם או משבצת זהב
  //  {
  //    int chockeSqureFromSnake = MouthSnakes.findindex(sumUser1);
  //    if (chockeSqure)
  //      sumUser1 = tailSnakes[chockeSqure];

  //    int chockeSqureFromStartLadder = StartLadder.findindex(sumUser1);
  //    if (chockeSqureFromStartLadder)
  //      sumUser1 = EndLadder[chockeSqureFromStartLadder];

  //    int chockeSqureFromEndLadder = EndLadder.findindex(sumUser1);
  //    if (chockeSqureFromEndLadder)
  //      sumUser1 = StartLadder[chockeSqureFromEndLadder];

  //    if (sumUser1 = golden1 || golden2)
  //    {
  //      if (sumUser2 > sumUser1)
  //      {
  //        int tmp = sumUser1;
  //        sumUser1 = sumUser2;
  //        sumUser2 = tmp;
  //      }
  //    }
  //    return (sumUser1,sumUser2);


  //  }




  //}

  //public void Play()
  //{
  //  int user1 = 0;
  //  int user2 = 0;
  //  int flag = 1;
  //  int sumUser1 = 0;
  //  int sumUser2 = 0;
  //  Random dice = new Random();
  //  Console.WriteLine("Enter the number of ladders");
  //  int numOfLadders = Console.ReadLine();
  //  CreateALadders(numOfLadders);
  //  Console.WriteLine("Enter the number of Snakes");
  //  int numOfSnakes = Console.ReadLine();
  //  CreateASnakes(numOfSnakes);
  //  CreateAGoldenTiles();
  //  while (sumUser1 || sumUser2 <= 100)
  //  {
  //    if (flag = 1)
  //    {
  //      int diceOfUser1 = rand.Next(0, 13);//יגריל מספר בין 1 ל 12 כמספר שיצא בקוביות לשחקן הראשון
  //      sumUser1 += diceOfUser1;
  //      ThaPlay(sumUser1, sumUser2);
  //      flag = 2;
  //    }
  //    if (flag = 2)
  //    {
  //      int diceOfUser2 = rand.Next(0, 13);//יגריל מספר בין 1 ל 12 כמספר שיצא בקוביות לשחקן הראשון
  //      sumUser2 += diceOfUser2;
  //      ThaPlay(sumUser2, sumUser1);
  //      flag = 1;
  //    }
  //  }







        
   
 


