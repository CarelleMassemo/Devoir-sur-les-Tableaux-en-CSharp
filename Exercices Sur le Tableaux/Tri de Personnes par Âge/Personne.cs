using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_de_Personnes_par_Âge
{
    public class Personne
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        public Personne(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public override string ToString()
        {
            return $"Nom: {Nom}, Âge: {Age}";
        }
    }
}
