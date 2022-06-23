using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HomeWork;


namespace Racing
{
    public class Car
    {
        public string _name;
        public int _speed;
        public ConsoleColor _carColor;
        public char _carSymbol;

        public int _carPosition;
        private int _progress;
        private static readonly object _syncLock = new();
        public Car(string name, int speed, ConsoleColor carColor, char carSymbol)
        {
            _name = name;
            _speed = speed;
            _carColor = carColor;
            //  _carPosition = carPosition;
            _carSymbol = carSymbol;
        }


        public Task Appear(int position, int distance, CancellationToken token = default)
        {
            lock (_syncLock)
            {
                $"Driver : {_name}".PrintAt(_progress, position - 1, _carColor);
                "|".PrintAt(distance / 10 + 1, position, ConsoleColor.White);
            }

            while (!token.IsCancellationRequested)
            {
                lock (_syncLock)
                {
                    var sb = new StringBuilder();

                    for (var j = 0; j <= _progress; j++) sb.Append(_progress != j ? " " : _carSymbol);

                    sb.ToString().PrintAt(0, position, _carColor);
                    _progress++;

                    if (distance < _progress * 10) break; // 
                }

                Thread.Sleep(distance / _speed * 20);
            }

            return Task.CompletedTask;
        }

        public void AppearParallel(int position, int distance, CancellationToken token = default)
        {
            lock (_syncLock)
            {
                $"Driver : {_name}".PrintAt(_progress, position - 1, _carColor);
                "|".PrintAt(distance / 10 + 1, position, ConsoleColor.White);
            }

            while (!token.IsCancellationRequested)
            {
                lock (_syncLock)
                {
                    var sb = new StringBuilder();

                    for (var j = 0; j <= _progress; j++) sb.Append(_progress != j ? " " : _carSymbol);

                    sb.ToString().PrintAt(0, position, _carColor);
                    _progress++;

                    if (distance < _progress * 10) break; // 
                }

                Thread.Sleep(distance / _speed * 20);
            }

           // return Task.CompletedTask;
        }


    }
}
//Console.SetCursorPosition(_carPosition, 0);
//Console.Write(_name);

//for (int i = 1; i < 10; i++)
//{

//    Thread.Sleep(100000 / _speed);
//    Console.ForegroundColor = (ConsoleColor)_carColor;
//    Console.SetCursorPosition(_carPosition, i);
//    Console.Write(_carSymbol);
//    Console.ResetColor();
//    // Console.Clear();