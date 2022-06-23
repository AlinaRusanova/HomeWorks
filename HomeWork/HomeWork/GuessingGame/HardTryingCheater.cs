using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class HardTryingCheater : Player
    {
        private int _currentPosition;
      
        public HardTryingCheater(string name, int CurPos, IHashCollection hashCollection) : base(name, hashCollection)
        {

            _currentPosition = CurPos;

        }

        public override int Roll(int min, int max)
        {

            int result = _currentPosition;
            do
            {
                if (_currentPosition < max)
                      _currentPosition++; 
            }
            while (HashCollection.Contains(_currentPosition));
           

            HashCollection.AddToCollection(result);
            return result;


        }
    }
}
