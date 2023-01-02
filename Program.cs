using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Quelle est ta note ?");
            int Note = Convert.ToInt32(ReadLine());

            if (Note > 60)
            {
                WriteLine("Pass !");
            }
            else
            {
                WriteLine("Fail");
            }
        }
    }
}