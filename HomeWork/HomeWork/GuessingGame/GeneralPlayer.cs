using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
  abstract class GeneralPlayer
    {

        private string _name;
        public GeneralPlayer(string name)
        {
            _name = name;
        }
        public abstract int Roll(int min,int max);
      

        public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
