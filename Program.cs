using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int NbADeviner = aleatoire.Next(1, 101);

            int reponse;
            do
            {
                WriteLine("Devine le nombre entre 1 et 100");
                reponse = Convert.ToInt32(ReadLine());

                if (reponse > NbADeviner)
                {
                    WriteLine("C'est plus petit");
                }
                else if (reponse < NbADeviner)
                {
                    WriteLine("C'est plus grand");
                }
            } 
            while (reponse != NbADeviner);
            {
                WriteLine("Bravo ! Tu as trouvé la bonne réponse.");
            }
        }
    }
}