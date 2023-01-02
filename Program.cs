using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteLine ("Entre un Nombre");
            int Nb1 = Convert.ToInt32(ReadLine());
            WriteLine ("Entre un Nombre");
            int Nb2 = Convert.ToInt32(ReadLine());
            WriteLine ("Entre un Nombre");
            int Nb3 = Convert.ToInt32(ReadLine());
            WriteLine ("Entre un Nombre");
            int Nb4 = Convert.ToInt32(ReadLine());
            WriteLine ("Entre un Nombre");
            int Nb5 = Convert.ToInt32(ReadLine());
            WriteLine ("Entre un Nombre");
            int Nb6 = Convert.ToInt32(ReadLine());
            WriteLine ("Entre un Nombre");
            int Nb7 = Convert.ToInt32(ReadLine());
            WriteLine ("Entre un Nombre");
            int Nb8 = Convert.ToInt32(ReadLine());
            WriteLine ("Entre un Nombre");
            int Nb9 = Convert.ToInt32(ReadLine());
            WriteLine ("Entre un Nombre");
            int Nb10 = Convert.ToInt32(ReadLine());

            int [] Tableau = new int [10] {Nb1,Nb2,Nb3,Nb4,Nb5,Nb6,Nb7,Nb8,Nb9,Nb10};

           for (int i = 0; i < Tableau.Length; i++)
           {
                Write (Tableau[i] + " ");
           }
        }
    }
}