using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    //public static  Random rn = new Random();
    public class SimplePlayers : GeneralPlayer
    {

        public  override void Roll(/*int min, int max, int count*/)
        {
            int[] simleAnswerArray = new int[count];
            int simpleAnswer = min;

            do
            {
                for (int i = min; i < max; i++)
                {
                    simleAnswerArray[i] = simpleAnswer;
                    Console.WriteLine(simleAnswerArray[i]);
                    simpleAnswer++;
                }

            }
            while (simpleAnswer != max);
           // return simpleAnswer;

        }
}
}
