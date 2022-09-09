using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesETObjets
{
    public class Personne
    {
        // Variables 
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int AnneeDeNaissance { get; set; }

        // Constructeur
        // 
        public Personne()
        {
            
        }
        public Personne(string nom, string prenom, int anneDeNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            AnneeDeNaissance = anneDeNaissance;
        }

        // Fonctions
        public void AfficheNometPrenoms()
        {
            Console.WriteLine("Vous vous appelez :" + Nom + " " + Prenom);
        }

        public int CalculAge()
        {
            return DateTime.Now.Year - AnneeDeNaissance;
        }
    }
}
