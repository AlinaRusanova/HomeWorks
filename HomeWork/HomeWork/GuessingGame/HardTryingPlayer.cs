using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class HardTryingPlayer : Player
    {
        private int _currentPosition;

        public HardTryingPlayer(string name, int CurPos, IHashCollection hashCollection) : base(name, hashCollection)
        {
        
        _currentPosition = CurPos;

        }

    public override int Roll(int min, int max)
        {
            
            int result = _currentPosition;

                if (_currentPosition < max)
                _currentPosition++;

            HashCollection.AddToCollection(result);
            return result;

           
        }
    }
}
