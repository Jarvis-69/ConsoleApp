using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [] Tableau = new int [10];

            for (int i = 0; i < Tableau.Length; i++)
            {
                WriteLine($"Entrez un nombre ({i + 1}/10) :");
                Tableau[i] = Convert.ToInt32(ReadLine());
            }

            foreach (int nombre in Tableau)
            {
                Write(nombre + " ");
            }
        }
    }
}