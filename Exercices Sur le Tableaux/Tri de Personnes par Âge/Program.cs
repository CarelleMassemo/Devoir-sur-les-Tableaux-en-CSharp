using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_de_Personnes_par_Âge
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Personne> personnes = new List<Personne>();
            string continuer;

            do
            {
                Console.Write("Entrez le nom de la personne : ");
                string nom = Console.ReadLine();

                Console.Write("Entrez l'âge de la personne : ");
                int age = Convert.ToInt32(Console.ReadLine());

                personnes.Add(new Personne(nom, age));

                Console.Write("Voulez-vous ajouter une autre personne ? (o/n) : ");
                continuer = Console.ReadLine();

            } while (continuer.ToLower() == "o");

            // Tri des personnes par âge, puis par nom
            var personnesTriees = personnes
                .OrderBy(p => p.Age)
                .ThenBy(p => p.Nom)
                .ToList();

            // Affichage du résultat
            Console.WriteLine("\nListe des personnes triées :");
            foreach (var personne in personnesTriees)
            {
                Console.WriteLine(personne);
            }
        }
    }
}
