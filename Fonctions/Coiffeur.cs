using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions
{
    internal class Coiffeur
    {

        // Variables 

        public string Nom { get; set; }
        public string Cle { get; set; }
        public int AnneExperience;
        public int AnneeDebutCoiffure;
        public string NumeroDeTelephone;

        // Fonctions 

        public void Coiffer()
        {
            Console.WriteLine("Je sais coiffer");
        }

        public void Tresser()
        {
            Console.WriteLine("Je sais tresser");

        }

        public void CouperBarbe()
        {
            Console.WriteLine("Je sais couper une barbe");
        }

        public int CalculerAnneeExperience()
        {
            int resultat = 2022 - AnneeDebutCoiffure;
            return resultat;
        }

    }
}
