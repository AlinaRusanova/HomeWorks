using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary
{
    class Dictionary
    {
        public static void WordList()
        {
            string text = File.ReadAllText(@"C:\Users\alina\source\repos\Dictionary\Text.txt");
            List<string> wordList = new List<string>(text.ToLower().Split(' ', ',', '.', '?', '!', ':'));

            Dictionary<string, uint> dictionary = new Dictionary<string, uint>();

            foreach (string wordInList in wordList)
            {
                if (!dictionary.ContainsKey(wordInList))
                {

                    dictionary.Add(wordInList, 1);
                }
                else
                {
                    dictionary[wordInList] += 1;
                }
            }

            List<string> forTXTFile = new List<string>();


            Console.WriteLine("WORD\tFREQUENCY");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} \t {item.Value}");
                forTXTFile.Add(item.ToString());
            }

            Console.ReadLine();

            string pathText2 = @"C:\Users\alina\source\repos\Dictionary\Test.txt";
            File.WriteAllLines(pathText2, forTXTFile);

            Console.WriteLine($"Text was saved in file: {pathText2}");
        }

    }
}
