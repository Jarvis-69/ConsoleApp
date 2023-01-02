using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
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
            }
            WriteLine ("Le produit depasse 1000");
        }
    }
}