using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    //public static  Random rn = new Random();
    public class RandomPlayer : Player
    {

        public RandomPlayer(string name, IHashCollection hashCollection) : base(name, hashCollection)
        {

        }


        public override int Roll(int min, int max/*, int count*/)
        {
            // int result = RandomGenerator.Next(min, max);
            Random rn = new Random();
            int result = rn.Next(min, max);
            HashCollection.AddToCollection(result);
            return result;

        }
    }     
}
