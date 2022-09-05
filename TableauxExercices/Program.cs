
/*
 * Ecrire un programme qui cherche le plus grand nombre 
 * dans un tableau et l'affiche 
 * 
 * Tableau : 
 * 
 * int[] tableau = new int[5] { 90, 45, 12, 104, 5}
 *                               0   1   2   3   4
 * 
 * int[] tableau = new int[2] { 90, 45, 12}
 * 
 * Boucle
 * if 
 * 
 * 
 */
//int[] tableau = new int[7] { 17, 45, 1152, 0, 5, 78, 1259 };   //length = 5
//int nombreGrand = tableau[0] ;   // 104  index = 4

//for (int index = 0; index < tableau.Length - 1; index++)
//{
//    if (nombreGrand < tableau[index + 1])
//    {
//        nombreGrand = tableau[index + 1];
//    }
//}

//Console.WriteLine(nombreGrand);


/*
 * 
 * Ecrire un programme qui calcule la somme des prix et des quantites d'articles et affiche le total 
 * 
 * 
 * decimal[] tableauPrix = new decimal[5]      { 1000, 15000, 50, 700, 250}
 * decimal[] tableauQuantites = new decimal[5] { 10, 4, 25, 1, 1}
 * 
 * Calculer le total a payer : pour chaque article on fait prix * quantite
 * 
 * 
 * decimal[] tableauPrix = new decimal[1]      { 1000}
 * decimal[] tableauQuantites = new decimal[1] { 10}
 * 
 * total = tableauPrix[0] * tableauQuantites[0]
 * 
 * 
 * * decimal[] tableauPrix = new decimal[1]      { 1000, 15000}
 * decimal[] tableauQuantites = new decimal[1] { 10, 4}
 * 
 * total = (tableauPrix[0] * tableauQuantites[0]) + (tableauPrix[1] * tableauQuantites[1]) 
 * 
 */

decimal[] tableauPrix = new decimal[5] { 1000, 15000, 50, 700, 250 };   //7
decimal[] tableauQuantites = new decimal[7] { 10, 4, 25, 1, 1, 4, 8 };      // 5
decimal totalPaye = 0;

if (tableauPrix.Length < tableauQuantites.Length)
{
    for (int index = 0; index < tableauPrix.Length; index++)
    {
        totalPaye = totalPaye + (tableauPrix[index] * tableauQuantites[index]);
    }
}
else
{
    for (int index = 0; index < tableauQuantites.Length; index++)
    {
        totalPaye = totalPaye + (tableauPrix[index] * tableauQuantites[index]);
    }
}

int nombreDeTours = 0;

if(tableauPrix.Length < tableauQuantites.Length)
    nombreDeTours = tableauPrix.Length;
else
    nombreDeTours= tableauQuantites.Length;

for (int index = 0; index < nombreDeTours; index++)
{
    totalPaye = totalPaye + (tableauPrix[index] * tableauQuantites[index]);
}

Console.WriteLine(totalPaye);




/*
 * 
 * Ecrire un programme qui demande a l'utilisateur de saisir 5 nombres au clavier. 
 * Les nombres saisis doivent servir a remplir un tableau
 * 
 * boucle  
 * 
 * 
 * 
 * Ensuite on affiche le plus petit nombre du tableau
 * 
 * 
 * 
 */

int[] tabl = new int[5];
tabl[0] = int.Parse(Console.ReadLine()); ;
tabl[1] = int.Parse(Console.ReadLine()); ;
tabl[2] = 0;
tabl[3] = 0;
tabl[4] = 0;

for (int index = 0; index < tabl.Length; index++)
{
    Console.WriteLine("Sasir un nombre");
    int valeurSaisi = int.Parse(Console.ReadLine());
    tabl[index] = valeurSaisi;
}


