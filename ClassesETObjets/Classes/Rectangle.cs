using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesETObjets.Classes
{
    public class Rectangle
    {
        // Variable ou proprietes 
        public decimal Longueur { get; }
        public decimal Largeur { get; }
        // Constructeur 
        public Rectangle()
        {

        }
        public Rectangle(decimal longue, decimal larg)
        {
            Longueur = longue;
            Largeur = larg;
        }

        // Fonctions ou methodes 
        public void AffichePerimetre()
        {
            decimal perimetre = (Longueur + Largeur) / 2;
            Console.WriteLine("Le prérimetre est :" +perimetre);
        }

        public decimal GetPerimetre()
        {
            decimal perimetre = (Longueur + Largeur) / 2;
            return perimetre;
        }

        



    }
}
