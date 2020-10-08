using System;
using System.IO;
using TriesLogic;

namespace Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../assets/wordlist.txt";
            AutoComplete autoComplete = new AutoComplete();

            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    autoComplete.AddWord(streamReader.ReadLine());
                }
            }

            // Try to write tests to verify your code!
            Console.WriteLine(autoComplete.GetCompletions("spectro"));
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
