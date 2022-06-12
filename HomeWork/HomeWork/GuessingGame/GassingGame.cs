using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class GassingGame
    {

        
       public const int min = 1;
        public const int max = 9;
         public static int guessNumber;     

        public static int RandomNumber()
        { 
            guessNumber = new Random().Next(min, max);
            Console.WriteLine($"The number is {guessNumber}");
            return guessNumber;
        }


    }
}
