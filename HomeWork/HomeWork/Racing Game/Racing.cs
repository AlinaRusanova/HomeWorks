using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HomeWork;

namespace Racing
{
    public class Racing
    {
        //  static object block = new object();
        //  static Random rn = new Random();
        private const int Distance = 1000;

        //internal void Start()
        //{
        //    throw new NotImplementedException();
        //}

        private static CancellationTokenSource _cts = new();

        public static List<Car> _raceCars; // создаем список машин используя конструктор класса 
        private static readonly char[] carSymbol = { '%', '$', '#', '8', 'O', '&', '@', '+' };   // массив из символв как будет выглядеть машина



        public static int position = 2;

        public void StartRacing()
        {
            Field();
            var tasks = new List<Task>();

            foreach (var raceCar in _raceCars)
            {
                var pos = position;
                tasks.Add(new Task(() => raceCar.Appear(pos, Distance, _cts.Token)));
                position += 2;
            }

            tasks.ForEach(t => t.Start());  // запускаем потоки
            Task.WaitAny(tasks.ToArray());  // ожидае когда какой либо из потоков придет к финишу чтобі закончить програму
            _cts.Cancel();


        }

        public /*static void*/ Racing(string[] namePlayers)
        {
            _raceCars = new List<Car>(namePlayers.Length);

            for (int i = 0; i < namePlayers.Length; i++)
            {
                _raceCars.Add(new Car(namePlayers[i], GetRandomBetween(40, 120), (ConsoleColor)GetRandomBetween(1, 15), carSymbol[i])
                {
                    //_name = namePlayers[i],
                    //_carSymbol = carSymbol[i]
                });
            }
        }



        public static void Field()
        {
            //  var tasks = new List<Task>();
            //  int position = 2;
            int position2 = position * 40;

           '_'.GetStrWithLength(100).PrintAt(0,0,ConsoleColor.DarkRed);

            '_'.GetStrWithLength(100).PrintAt(0, 15, ConsoleColor.DarkRed);

        }

        public static int GetRandomBetween(int start, int end)
        {
            return new Random().Next(start, end);
        }

    }

}
// создать массив из имен
// 