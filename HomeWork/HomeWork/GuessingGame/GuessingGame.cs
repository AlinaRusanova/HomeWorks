using System;
using System.Collections.Generic;
using HomeWork;
using System.Threading;
using System.Threading.Tasks;

namespace GuessingGame
{
    class GuessingGame
    {

        
        public const int min = 3;
        public const int max = 50;
   

        public static int guessNumber;    
        
        public static HashCollection hashSet = new HashCollection ();
        private static object _lock = new object();
        public static int leftPosition = 10;
        public static int countOfPlayers;
        // public  int topPosition = 10;
        private static int generalNumberForPos = 1;

        public static int RandomNumber()
        { 
            guessNumber = new Random().Next(min, max);
            Console.Write("The number is ");  $"{guessNumber}".PrintWithChoosenColor(ConsoleColor.DarkCyan) ;
            Console.WriteLine();
            return guessNumber;
        }


        public static void Start()
        { 
            RandomNumber();

            Console.WriteLine("Enter the number of participants:");

            countOfPlayers = int.Parse(Console.ReadLine());
            int typeOfPlayers;

            List<Player> PlayersList = new List<Player>(countOfPlayers);

            Console.WriteLine("Today in our game participate following players:");

            for (int i = 0; i < countOfPlayers; i++)
            {
                typeOfPlayers = new Random().Next(1, 6);
                PlayersList.Add(GeneratePlayer(typeOfPlayers, i+1));
                Console.WriteLine($"{PlayersList[i].PlayerName} - {PlayersList[i].GetType().Name}");

            }



            Console.WriteLine();
            Console.WriteLine("Let's start!");
            Console.WriteLine();

            var cancelToken = new CancellationTokenSource();

            Parallel.ForEach(PlayersList, new ParallelOptions
            {
                MaxDegreeOfParallelism = countOfPlayers
            }, player => 
            
            {
                Game(player, leftPosition, generalNumberForPos++, cancelToken);
                cancelToken.Cancel();
            }
            );

           
            //Console.WriteLine("In this game were used numbers:");
            //Console.WriteLine();
            //Console.WriteLine(hashSet.GetCollection());
            
            Console.ReadLine();
        }

        #region GeneratePlayer
        private static Player GeneratePlayer(int type, int name)
        {
            switch (type)
            {
                case 1:
                    return new HardTryingPlayer($"Player {name}",min, hashSet);

                case 2:
                    return new RandomPlayer($"Player {name}", hashSet);

                case 3:
                    return new RandomSmart($"Player {name}", hashSet);

                case 4:
                    return new RandomCheaterPlayer($"Player {name}", hashSet);

                case 5:
                    return new HardTryingCheater($"Player {name}", min, hashSet);

                default:
                    return null;

            }

        }
        #endregion


        static void Game(Player player, int leftPosition, int pos,  CancellationTokenSource tokenSource)
        {
            try
            {
                
                int result;
                int topPosition = 8 + countOfPlayers;
                int lPosition = leftPosition * pos;

                lock (_lock)
                {
                Console.SetCursorPosition(lPosition, topPosition++);
                $"{player.PlayerName}".PrintWithChoosenColor(ConsoleColor.Yellow);
                }
                
                
                int count = 0;
                do
                {
                    


                    if (tokenSource.IsCancellationRequested)
                        return;

                    else
                    {


                        lock (_lock)
                        {
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(lPosition, topPosition++);
                            result = player.Roll(min, max);
                            count++;
                            // topPosition++;
                            // Console.WriteLine(result);
                            if (result == guessNumber)
                            { $"{result}".PrintWithChoosenColor(ConsoleColor.DarkCyan); }
                            else { $"{result}".PrintWithChoosenColor(ConsoleColor.White); };
                        }
                    }
                }
                while (guessNumber != result);

                        tokenSource.Cancel();
                        Console.SetCursorPosition(0, topPosition + 6);
                        Console.WriteLine($"{player.PlayerName} guessed the secret number {guessNumber} after the {count} trying!!!!!!!");
                                  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
        
        
        
        }


    }
}
