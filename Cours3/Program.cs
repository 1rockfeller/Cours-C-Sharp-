
/*
 * 
 *  Ecrire un programme qui fait la somme des 10 premers nombres entiers et affiche le resultat
 * 
 * 
 */


//int limite = 10;

//int compteur = 1;
//int somme = 0;
//while (compteur <= 10)      
//{
//    Console.WriteLine("Bonjour");
//    somme = somme + compteur;       
//    compteur = compteur + 1;       

//}

//Console.WriteLine("La somme est : " +somme);



//do
//{
//    somme = somme + compteur;
//    compteur = compteur + 1;
//} while (compteur <= 10);


//Console.WriteLine("La somme est : " + somme);



//for (compteur = 1; compteur <= 10; compteur++)
//{
//    somme = somme + compteur;
//}

//Console.WriteLine("La somme est : " + somme);





/*
 * 
 * 
 *  Demandez a l'utilisateur de saisir un nom. Tant que le nom n'est pas egal a toto, lui demander de resaisir le nom une nouvelle fois
 * 
 * 
 */

//string nom;
//Console.WriteLine("Saisir un nom");
//nom = Console.ReadLine();


string nom = "";

//while (nom != "toto")
//{
//    Console.WriteLine("Merci de resaisir le nom une nouvelle fois");
//    nom = Console.ReadLine();
//}





//do
//{
//    Console.WriteLine("Merci de resaisir le nom une nouvelle fois");
//    nom = Console.ReadLine();

//} while (nom != "toto");




/*
 * 
 * 
 *  Saisir un nombre a l'ecran, on fait -1 de ce nombre jusqu'a atteindre 0
 *  Ex : 10 
 *  
 *  10
 *  9
 *  8
 *  7
 *  6
 *  
 *  
 *  
 *  
 *  
 *  0
 * 
 * 
 */


int nombreSaisi;
Console.WriteLine("Saisissez un nombre");
nombreSaisi = int.Parse(Console.ReadLine());   // 10


for (int nombre = nombreSaisi; nombre >= 0; nombre--)
{
    Console.WriteLine(nombre);
}