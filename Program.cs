using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
           int [] Tableau = new int [10] {1,2,3,4,5,6,7,8,9,10};

           for (int i = 0; i < Tableau.Length; i++)
           {
                Write (Tableau[i] + " ");
           }
        }
    }
}