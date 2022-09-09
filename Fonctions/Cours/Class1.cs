using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions.Cours
{
    class Class1
    {
        public string Nom { get; set; }
        public int Age { get; set; }


        static Class1()
        {

        }

        //Constructeur
        public Class1()
        {
            
        }

        public Class1(int age)
        {

        }
        public void NomProc()
        {
            Console.WriteLine();
        }

        public void NomProc(int age)
        {
            Console.WriteLine();
        }

        public void NomProc(int age, string nom)
        {
            int somme;
            Console.WriteLine();
        }

        public string NomFonction()
        {
            
            return "Koffi";
        }
    }
}
