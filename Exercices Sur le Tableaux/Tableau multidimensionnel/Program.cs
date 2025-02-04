using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_multidimensionnel
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matrice = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            Console.WriteLine("Matrice :");
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
