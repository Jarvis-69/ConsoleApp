using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int NbADeviner = aleatoire.Next(1, 101);

            int reponse;
            WriteLine("Devine le nombre entre 1 et 100");
            do
            {
                reponse = Convert.ToInt32(ReadLine());

                if (reponse > NbADeviner)
                {
                    WriteLine("Incorrect, try again. C'est plus petit");
                }
                else if (reponse < NbADeviner)
                {
                    WriteLine("Incorrect, try again. C'est plus grand");
                }
            } 
            while (reponse != NbADeviner);
            {
                WriteLine("Correct!");
            }
        }
    }
}