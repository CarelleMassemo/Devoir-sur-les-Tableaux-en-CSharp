using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_d_un_tableau
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 5, 2, 9, 1, 5, 6 };

            for (int i = 0; i < tableau.Length - 1; i++)
            {
                for (int j = 0; j < tableau.Length - 1 - i; j++)
                {
                    if (tableau[j] > tableau[j + 1])
                    {
                        // Échange
                        int temp = tableau[j];
                        tableau[j] = tableau[j + 1];
                        tableau[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Tableau trié :");
            foreach (int nombre in tableau)
            {
                Console.WriteLine(nombre);
                Console.ReadKey();
            }
        }
    }
}
