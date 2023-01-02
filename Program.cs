using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
<<<<<<< Updated upstream
            int [,] Tableau = new int [1,2];
            int [,,] Tableau1 = new int [5,2,3];

            for (int i = 0; i < Tableau1.GetLength(0); i++)
            {
                for (int j = 0; j < Tableau1.GetLength(1); j++)
                {
                    for (int k = 0; k < Tableau1.Length; k++)
                    {
                        Console.Write(Tableau1[i,j,k] + " ");
                    }
                }
                Console.WriteLine();
=======
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
>>>>>>> Stashed changes
            }
        }

            // int [][] Tableau = new int[2][];
            // Tableau[0] = new int [] {45,2};
            // Tableau[1] = new int [] {34,34,4};

            // // Parcours le tableau principal
            // for (int i = 0; i < Tableau.Length; i++)
            // {
            //     // Parcours les sous tableaux
            //     for (int j = 0; j < Tableau[i].Length; j++)
            //     {
            //         Console.Write(Tableau[i][j] + " ");
            //     }
            //     //Permet de sauter une ligne
            //     Console.WriteLine();
    }
}