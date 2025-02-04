using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_d_un_tableau
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 1, 2, 3, 4 };
            int temp;

            for (int i = 0; i < tableau.Length / 2; i++)
            {
                temp = tableau[i];
                tableau[i] = tableau[tableau.Length - 1 - i]; // Échange
                tableau[tableau.Length - 1 - i] = temp;
            }

            Console.WriteLine("Tableau inversé :");
            foreach (int nombre in tableau)
            {
                Console.WriteLine(nombre);
                Console.ReadKey();
            }
        }
    }
}
