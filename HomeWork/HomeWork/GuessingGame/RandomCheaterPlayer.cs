using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class RandomCheaterPlayer : Player
    {
        public RandomCheaterPlayer(string name, IHashCollection hashCollection) : base(name, hashCollection)
        {

        }


        public override int Roll(int min, int max/*, int count*/)
        {
            // int result = RandomGenerator.Next(min, max);
            int result;
            do
            {
                result = new Random().Next(min, max);
            }
            while (HashCollection.Contains(result));

            HashCollection.AddToCollection(result);

            return result;
        }
    }
}

