using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesETObjets.Classes
{
    public class Cercle
    {
        // variables ou proprietes 
        public decimal Rayon { get; set; }   // prop + 2 x tab

        // constructeur 

        public Cercle(decimal rayon)     //  ctor + 2 x tab
        {
            Rayon = rayon;
        }

        // fonctions ou methodes 
        public decimal CalculDiametre()
        {
            //decimal diametre = Rayon * 2;
            //return diametre;
            return Rayon * 2;
        }

        public decimal CalculSurface()
        {
            return Rayon * Rayon * decimal.Parse("3,14");
        }

        public decimal RayonFoisRayon()
        {
            return Rayon * Rayon;
        }

        public decimal Surface(decimal resultatRayonfoisRayon)
        {
            return resultatRayonfoisRayon * decimal.Parse("3,14");
        }

    }
}
