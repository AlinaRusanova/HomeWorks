using System;
using System.Diagnostics;
using Racing;


namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            var sw = Stopwatch.StartNew();

            try
            {
                new Racing.Racing(new[] { "Dima", "Nata", "Alina", "Tanya", "Simba", "Den", "Anton" }).StartRacingTask();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            finally
            {
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }

            Console.WriteLine(sw.Elapsed);

            Console.ReadLine();

            
        }
    }
}

