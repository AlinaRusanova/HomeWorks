using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Wine
{

    class WineStorage : IEnumerable, IEnumerator   // коллекция склад вина
    {
        //    private static Wine[] _bottle;                   // массив с элементами типа Wine  (то есть это наши бутылки вина, которые описаны в классе Wine)    _wine - собственный массив коллекции
        //    private static int position = -1;

        //    public WineStorage(Wine[] bottleDescription)                // конструктор: из вне принимает массив типа Wine    
        //    {
        //        _bottle = new Wine[bottleDescription.Length];                // а в теле конструктора происходит копирование элементов из массива, который передается в качестве арггументов в массив _wine
        //        for (var i = 0; i < bottleDescription.Length; i++)
        //        {
        //            _bottle[i] = bottleDescription[i];
        //        }
        //    }

        private static List<Wine> _bottle;
        private static int position = -1;

        public WineStorage(List<Wine> bottleDescription)
        {
            _bottle = new List<Wine>(bottleDescription.ToArray().Length);
            for (var i = 0; i < bottleDescription.ToArray().Length; i++)
            {
                _bottle[i] = bottleDescription[i];
            }
        }




        public static /*List<Wine>*/void wineArray(/*WineColor randomColor, WineType randomType, int randomYear, int randomStrong*/)
        {

            var bottleDiscription = new Wine[100];

            for (int i = 0; i < bottleDiscription.Length; i++)
            {
                bottleDiscription[i] = new(EnumRandom.RandomEnum<WineColor>(), EnumRandom.RandomEnum<WineType>(), EnumRandom.random.Next(1980, 2022), EnumRandom.random.Next(6, 14));
            }



            var winelist = new List<Wine>(bottleDiscription);


            foreach (var wine in winelist)
            {
                wine.Appear();
            }
            // return winelist;
            //   var wineList = new WineStorage (wineArray);





        }

        public static void Appear(/*List<Wine> winelist*/)
        {


        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public Wine Current
        {
            get
            {
                try
                {
                    return _bottle[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < _bottle.ToArray().Length;
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current => Current; 
        public WineStorage GetEnumerator()
        {
            return new WineStorage(_bottle);
        }
    }



}

