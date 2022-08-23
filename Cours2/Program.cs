// See https://aka.ms/new-console-template for more information

if (condition1 || condition2)
{

}
else
{

}


switch(age)
{
    case 10:
        break;
    case 11:
        break;
    default
}


//int age = 19;

//if (age == 18)
//    Console.WriteLine("Vous avez 18 ans");
//else if(age == 19)
//    Console.WriteLine("Vous avez 19 ans");
//else if (age == 20)
//    Console.WriteLine("Vous avez 20 ans");
//else if (age == 21)
//    Console.WriteLine("Vous avez 21 ans");


//if (age == 18)
//    Console.WriteLine("Vous avez 18 ans");

//if (age == 19)
//    Console.WriteLine("Vous avez 19 ans");

//if (age == 20)
//    Console.WriteLine("Vous avez 20 ans");

//if (age == 21)
//    Console.WriteLine("Vous avez 21 ans");


//if (age == 18)
//{
//    Console.WriteLine("Vous avez 18 ans");
//    Console.WriteLine("Vous avez 18 ans");
//    Console.WriteLine("Vous avez 18 ans");
//    Console.WriteLine("Vous avez 18 ans");
//    Console.WriteLine("Vous avez 18 ans");
//}

//if (age == 18)    
//{
//    if(nom == "Koffi")
//    {
//        Console.WriteLine("Vous avez 18 ans");

//    }
//    else
//    {

//    }
//}

//if (age == 18) || (nom == "Koffi")
//{
//    Console.WriteLine("Vous avez 18 ans");
//}


//if (condition1) (condition2) (condition3)

//        &&   // ET  
//        ||   // OU

//string nomUser , Password;


//if (nomUser == "admin") && (Password == "1234")
//{

//}

//== // egalité
//<= // inferieur ou egale 
//< // inferieur 
//>= // superieur ou egale 
//!= // Different 



/* Exercice : Demander un nombre entre 1 et 10 a l'utilisateur 
 * 
 * Ensuite on verifie si le nombre entier saisi est vraiment compris entre 1 et 10. 
 * 
 * Ensuite on affiche une lette correspondante 
 * Exemple : 
 * 
 * 1 = A
 * 2= B
 * 3 = C 
 * etc
 * 
 * 
 */


// Déclaration de variable 

int nombreSaisi;

Console.WriteLine("Saisir un nombre compris entre 1 et 10 svp ");
nombreSaisi = int.Parse(Console.ReadLine());

// Ensuite on verifie si le nombre entier saisi est vraiment compris entre 1 et 10.



if(nombreSaisi >=1 && nombreSaisi <= 10)
{
    if(nombreSaisi == 1)
    {
        Console.WriteLine("A");
    }
    if (nombreSaisi == 2)
    {
        Console.WriteLine("B");
    }
    if (nombreSaisi == 3)
    {
        Console.WriteLine("C");
    }
    if (nombreSaisi == 4)
    {
        Console.WriteLine("D");
    }
    if (nombreSaisi == 5)
    {
        Console.WriteLine("E");
    }
    if (nombreSaisi == 6)
    {
        Console.WriteLine("F");
    }
    if (nombreSaisi == 7)
    {
        Console.WriteLine("G");
    }
    if (nombreSaisi == 8)
    {
        Console.WriteLine("H");
    }
    if (nombreSaisi == 9)
    {
        Console.WriteLine("I");
    }
    if (nombreSaisi == 10)
    {
        Console.WriteLine("J");
    }
}
else
{
    Console.WriteLine("Votre nombre n'est pas compris entre 1 et 10 ");
}






//***********************************************/////



if (nombreSaisi >= 1 && nombreSaisi <= 10)
{

    switch (nombreSaisi)
    {
        case 1:
            Console.WriteLine("A");
            break;
        case 2:
            Console.WriteLine("B");
            break;
        case 3:
            Console.WriteLine("C");
            break;
        case 4:
            Console.WriteLine("D");
            break;
        case 5:
            Console.WriteLine("E");
            break;
        case 6:
            Console.WriteLine("F");
            break;
        case 7:
            Console.WriteLine("G");
            break;
        case 8:
            Console.WriteLine("H");
            break;
        case 9:
            Console.WriteLine("I");
            break;
        case 10:
            Console.WriteLine("J");
            break;
        default:
            Console.WriteLine("AUtre");
            break;
    } 
}
else
{
    Console.WriteLine("Votre nombre n'est pas compris entre 1 et 10 ");
}



