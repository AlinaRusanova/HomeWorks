using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
  public abstract class Player
    {
        protected IHashCollection HashCollection; // экземпляр интерфейса коллекции ответов всех играков
        protected readonly Random RandomGenerator;

        public string PlayerName;

        public string Name { get; }

        public Player(string name, IHashCollection hashCollection)
        {
            PlayerName = name;
            HashCollection = hashCollection;
        }


        public abstract int Roll(int min,int max/*, int count*/);


        //public void ShowInfo()
        //{
        //    Console.WriteLine(GetType().Name);
        //}
    }
}
