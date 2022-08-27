//Écrire un programme qui demande a l'utilisateur de saisir un mot et affiche le nombre de voyelles de ce mot.
//On suppose que le mot est écrit tout en minuscule et sans caractère accentué.


//while (true)
//{

//}

//do
//{

//} while (true);

//for (int i = 0; i < length; i++)
//{

//}

//foreach (var item in collection)
//{

//}




using System;
using System.Xml.Serialization;

//string mot;
//// Saisir un mot : abalo = 3   : franck = 1

//Console.WriteLine("Saisissez votre mot");
//mot = Console.ReadLine();

//// liste de voyelles : a , e, u, i, y, o

//// parcourir le mot abalo   5    mot.Length   mot[0]  mot[1]
//// 
//int totalVoyelle = 0;
//for (int index = 0; index < mot.Length; index++)
//{
//    // serge
//    // 01234
//    switch (mot[index])
//	{
//		case 'a':
//            totalVoyelle = totalVoyelle + 1;
//			break;
//        case 'e':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        case 'u':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        case 'i':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        case 'y':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        case 'o':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        default:
//			break;
//	}
//}

//Console.WriteLine("Le total de voyelle est : " + totalVoyelle);
// comparer chaque caractere avec ma liste de voyelle 

//total de voyelle 

//si je trouve une voyelle 
// +1 total de voyelle

//sinon je ne fais rien, je ne compte pas 


//foreach (var caractere in mot)
//{
//    switch (caractere)
//    {
//        case 'a':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        case 'e':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        case 'u':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        case 'i':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        case 'y':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        case 'o':
//            totalVoyelle = totalVoyelle + 1;
//            break;
//        default:
//            break;
//    }
//}





// serge
// 01234     


//longueur = 5 

//serge[2]  = r
// serge[3] = g






/// Demander a l'utilisateur de saisir 2 nombres nombre1 et nombre2 et ensuite inverse les 2 et affiche : 
/// Exemple nombre1 = 4 ; nombre2 = 6 
/// Le nombre 1 = 6 
/// le nombre 2 = 4;

//int nombre1, nombre2;
//Console.WriteLine("Saisissez le nombre 1");
//nombre1 = int.Parse(Console.ReadLine());     

//Console.WriteLine("Saisissez le nombre 2");
//nombre2 = int.Parse(Console.ReadLine());     

//int variableTemporaire;

//variableTemporaire = nombre2;

//nombre2 = nombre1;    

//nombre1 = variableTemporaire;

//Console.WriteLine(nombre1);
//Console.WriteLine(nombre2);



/*
 *  Ecire un programme qui demande a un utilisateur de saisir toutes ses notes de maths 
 *  Ensuite appuyer sur la touche 0 pour arreter la saisie . 
 *  Ensuite en fonction des notes qu'il a saisi on lui affiche sa moyenne
 * 
 *  Ex : 12 11 10 19 14 0  / 5   
 *  Votre moyenne est : 
 *  
 *  12 11 0 
 *  
 */


// Boucle 

//for X 
//foreach 


//while 
//    do while
// condition d arret note == 0
// moyenne = sommeNote / nombreDeNotes



//int note, moyenne, variableTemporaire;
//Console.WriteLine("Saisissez vos notes");

//do
//{
//    note = int.Parse(Console.ReadLine());
//} while (note != 0);





decimal note = -1, moyenne, variableTemporaire, nombreDeNotesSaisi = 0, sommeDesNotes = 0;
Console.WriteLine("Saisissez vos notes");

while (note != 0)
{
    note = decimal.Parse(Console.ReadLine()); 
    
    if(note != 0)
    {
        nombreDeNotesSaisi = nombreDeNotesSaisi + 1;
        sommeDesNotes = sommeDesNotes + note;
    }
        
}

moyenne = sommeDesNotes / nombreDeNotesSaisi;

Console.WriteLine("La moyenne est : " +moyenne);



//14 11 12 14 10 

//sommeDesNotes / nombredeNombreSaisi
