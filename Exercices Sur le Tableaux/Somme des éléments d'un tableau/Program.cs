using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somme_des_éléments_d_un_tableau
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[5];
            int Somme = 0;

            Console.WriteLine("Entrez les 5 valeurs:");
            for(int i = 0; i < tableau.Length; i++) { 
            Console.Write($"Valeur{i+1}:");
                tableau[i] = int.Parse(Console.ReadLine());
                Somme += tableau[i];
                 }
            Console.WriteLine($"La Somme des éléments est:{Somme}");
            Console.ReadKey();
        }
    }
}
