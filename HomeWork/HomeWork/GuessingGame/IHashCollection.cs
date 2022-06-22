using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
  public interface IHashCollection
    {
        void AddToCollection(int number);

        bool Contains(int number);

        string GetCollection();



    }
}
