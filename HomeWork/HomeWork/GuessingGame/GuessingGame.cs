using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class GuessingGame
    {

        
        public const int min = 3;
        public const int max = 20;
      //  public const int count = max-min+1;
        public static int guessNumber;     

        public static int RandomNumber()
        { 
            guessNumber = new Random().Next(min, max);
            Console.WriteLine($"The number is {guessNumber}");
            return guessNumber;
        }


        public static void Start()
        {
            RandomNumber();
            HashCollection hashSet = new HashCollection ();
            RandomPlayer p2 = new RandomPlayer("Player1", hashSet);

            HardTryingCheater p1 = new HardTryingCheater ("Player1",min, hashSet);

            Console.WriteLine($"The number ====== {guessNumber}!!!!!!!");

            int result, count=0;

           int a = p2.Roll(min, max);
            Console.WriteLine(a);
            int b = p2.Roll(min, max);
            Console.WriteLine(b);
            int c = p2.Roll(min, max);
            Console.WriteLine(c);

            do
            {
                result= p1.Roll(min, max);
                count++;
                Console.WriteLine($"Попытка № {count}, предполагаемое число - {result} ");
                

            }

            while (guessNumber!=result);


            Console.WriteLine($"{p1.PlayerName} угадал секретное число {guessNumber} с {count} попытки!!!!!!!");

            Console.WriteLine(hashSet.GetCollection());

            //foreach (var item in hashSet)
            //{

            //}


        }


    }
}
