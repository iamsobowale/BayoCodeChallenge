using System;
namespace BayoChallenge
{
    public class Question1
    {
        public static void Anwser()
        {
         int coins=8;
         Console.WriteLine(N(coins));
        }
       public static int N(int coins)
        {
            int stairs=1;
            while (stairs<=coins)
            {
                coins-=stairs;
                stairs++;
            }
            return stairs-1;
        }
    }
}