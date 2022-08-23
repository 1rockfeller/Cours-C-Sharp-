// See https://aka.ms/new-console-template for more information


/*
 *  Ecrire un programme qui demande le nom de la personne au clavier, 
 *  demande ses 2 notes de Maths et affiche sa moyenne 
 *  
 *  On veut avoir un affichage comme tel : Votre nom est : #Nom# , vous avez #moyenne .
 * 
 * Votre nom est : Koffi , vous avez comme moyenne 14
 * 
 */



// Déclaration des variables 
string nom;
decimal note1, note2, moyenne=2;

// Affichage du message a l'ecran
Console.WriteLine("Saisissez votre nom SVP !");

// Récuperation du nom au clavier
nom = Console.ReadLine();

// Affichage du message a l'ecran
Console.WriteLine("Saisissez votre premiere note");

// Récuperation de la note au clavier
note1 = decimal.Parse(Console.ReadLine()) ;

// Affichage du message a l'ecran
Console.WriteLine("Saisissez votre deuxieme note");

// Récuperation de la note au clavier
note2 = decimal.Parse(Console.ReadLine());


//Calcul de la moyenne

moyenne = (note1 + note2) / 2;

// Console.WriteLine(nom ,+ "Vous avez comme moyenne " + moyenne);
// Console.WriteLine(nom, "Vous avez comme moyenne" moyenne);

//Votre nom est : Koffi , vous avez comme moyenne 14


// Affichage du message final a l'ecran

Console.WriteLine("Votre nom est : " + nom + " , Vous avez comme moyenne " + moyenne);


long nbre = 0;


/***
 * 
 * Ecrire un programme qui demande le nom de l'utilisateur et son année de naissance
 * 
 * Ensuite , le programme affiche le nom et l'age de la personne comme suit: 
 * 
 * 
 * exemple : Votre nom est : Koffi et vous avez 16 ans .
 * 
 * 
 */

