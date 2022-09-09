using ClassesETObjets.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesETObjets
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Syntaxe 
            // NomClasse nomObjet = new Constrcuteur();

            //Personne personne = new Personne();
            //personne.Nom = "Abalo";
            //personne.Prenom = "Koffi";
            //personne.AnneeDeNaissance = 2020;

            //personne.AfficheNometPrenoms();
            //personne.CalculAge(2023);

            //personne.Nom = "Affi";

            //personne.AfficheNometPrenoms();



            //personne.Nom = "ADI";
            //personne.Prenom = "Kodjo";
            //personne.AfficheNometPrenoms();

            //Syntaxe 
            // NomClasse nomObjet = new Constrcuteur();

            //Personne personne2 = new Personne("Abalo", "Koffi", 2020);
            //personne2.AfficheNometPrenoms();
            //personne.CalculAge();


            //Rectangle rect = new Rectangle(150,25);

            //rect.AffichePerimetre();


            //decimal resulat = rect.GetPerimetre() * 2;
            //Console.WriteLine("PERIMETRE : " +resulat);

            //Cercle notreCercle = new Cercle(15);
            //decimal diametre = notreCercle.CalculDiametre();
            //Console.WriteLine(diametre);

            //decimal surface = notreCercle.CalculSurface();
            //Console.WriteLine(surface);


            Cercle notreCercle = new Cercle(15);
            decimal resultat1 = notreCercle.RayonFoisRayon();

            decimal surface = notreCercle.Surface(resultat1);
            Console.WriteLine(surface);
        }
    }
}