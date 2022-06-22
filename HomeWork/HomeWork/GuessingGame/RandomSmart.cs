using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class RandomSmart : Player
    {
        private List<int> _answers = new List<int>();

        public RandomSmart(string name, IHashCollection hashCollection) : base(name, hashCollection)
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
            while (_answers.Contains(result));

            _answers.Add(result);
            HashCollection.AddToCollection(result);
            
            return result;

        }
    }
}
