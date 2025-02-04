using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recherche_d_un_élément_dans_un_tableau
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] noms = { "Carelle", "Dimitri", "Massemo", "Jospin", "Daina" };
            Console.Write("Entrez un nom:");
            string nomSaisi = Console.ReadLine();
            bool trouve = false;

            foreach (string nom in noms)
            {
                if (nom.Equals(nomSaisi, StringComparison.OrdinalIgnoreCase))
                {
                    trouve = true;
                }
                if (trouve)
                {
                    Console.Write("Nom trouvé dans le tableau.");
                }

                else
                {
                    Console.WriteLine("Nom non trouvé dans le tableau");
                    Console.ReadKey();  
                }
            }

        }
    }
}

