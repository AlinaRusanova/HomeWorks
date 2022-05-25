using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine
{
    public static class EnumRandom
    {
        public static Random random = new Random();
        public static T RandomEnum<T>()
        {
            var random = Enum.GetValues(typeof(T));
            return (T)random.GetValue(EnumRandom.random.Next(random.Length));
        }
    }
}
