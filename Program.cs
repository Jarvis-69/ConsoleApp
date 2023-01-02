using static System.Console;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main (string[] args)
        {
            WriteLine("Quel est ton premier chiffre ?");
            int PremierNumero = Convert.ToInt32(ReadLine());
            WriteLine("Quel est ton deuxième chiffre ?");
            int DeuxiemeNumero = Convert.ToInt32(ReadLine());

            if (PremierNumero > DeuxiemeNumero)
            {
                System.Console.WriteLine("Votre Nombre le plus grand est le premier");
            }
            else
            {
                System.Console.WriteLine("Votre Nombre le plus grand est le deuxième");
            }
        }
    }
}