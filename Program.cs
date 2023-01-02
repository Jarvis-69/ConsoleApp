using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Choisi un nomrbe");
            int Nombre = Convert.ToInt32(ReadLine());

            for (int i = 1; i < 12; i++)
            {
                int Resultat = Nombre * i;
                WriteLine($"{Nombre} * {i} = {Resultat}");
            }
        }
    }
}