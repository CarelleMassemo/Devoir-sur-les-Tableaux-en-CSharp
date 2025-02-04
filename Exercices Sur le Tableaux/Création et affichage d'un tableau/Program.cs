using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Création_et_affichage_d_un_tableau
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[10];
            for (int i=0; i<tableau.Length; i++)
            {
                tableau[i] = i + 1;
            }
            Console.WriteLine("Element du tableau:");
            for (int i=0;i<tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
                Console.ReadKey();
            }
        }
    }
}
