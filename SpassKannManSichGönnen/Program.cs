using System;
using System.Threading;

namespace SpassKannManSichGönnen
{
    class Program
    {
        public static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            for (int i = 1; i < 101; i++)
            {
                Thread.Sleep(800);
                Console.WriteLine(i);
            }
        }
    }
}
