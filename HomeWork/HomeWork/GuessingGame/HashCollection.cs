using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class HashCollection : IHashCollection
    {
        private static HashSet<int> _hashCollection = new HashSet<int>();
        private readonly object _lock = new object();


        public void AddToCollection(int number)
        {
            lock (_lock)
            {
                 if (!_hashCollection.Contains(number))
                            {
                                _hashCollection.Add(number);
                            }
            }
          
        }

        public bool Contains(int number)
        {
            lock (_lock)
            {
                return _hashCollection.Contains(number);
            }


        }

        public string GetCollection()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var number in _hashCollection.OrderBy(x => x))
            {
                sb.AppendLine($"{number}");
            }
            return sb.ToString();
        }
    }
}
