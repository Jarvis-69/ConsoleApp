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
            WriteLine("Choisi un premier nombre");
            int PremierNombre = Convert.ToInt32(ReadLine());
            WriteLine("Choisi un deuxieme nombre");
            int DeuxiemeNombre = Convert.ToInt32(ReadLine());
            
            int Produit = PremierNombre * DeuxiemeNombre;
            while (Produit < 1000)
            {
                WriteLine("Choisi un autre nombre");
                int AutreNombre = Convert.ToInt32(ReadLine());
                Produit = Produit * AutreNombre;
>>>>>>> Stashed changes
            }
            WriteLine ("Le produit depasse 1000");
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