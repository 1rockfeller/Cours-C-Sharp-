

//type[] nomTableau = new type[taille];

int[] monPremierTableau = new int[3];

monPremierTableau[0] = 2;
monPremierTableau[1] = 7;



//Console.WriteLine("Le premier élément est : " + monPremierTableau[0]);
//Console.WriteLine("Le deuxieme élément est : " + monPremierTableau[1]);
//Console.WriteLine("Le troisieme élément est : " + monPremierTableau[2]);

//case 0
//case 1
//case 2


//type[] nomTableau = new type[taille];

//bool[] monTableauDeBooleen = new bool[2];

//Console.WriteLine(monTableauDeBooleen[0]);
//Console.WriteLine(monTableauDeBooleen[1]);

//// Apres affectation 

//monTableauDeBooleen[0] = true;

//Console.WriteLine(monTableauDeBooleen[0]);
//Console.WriteLine(monTableauDeBooleen[1]);


//type[] nomTableau = new type[taille] { valeurs };


//int[] nomTableau = new int[4] { 7, 2, 4, 87 };

//Console.WriteLine(nomTableau[2]);


//string[] nomTableaudenom = new string[3] { "Serge", "Coco", "Rock" };

//Console.WriteLine(nomTableaudenom[0]);

//// Utilisation de Length 

//Console.WriteLine("La taille du tableau est : "+nomTableaudenom.Length);




// Un programme qui recoit un tableau et calcul la somme de tous les elements du tableau 

//int[] tableau = new int[10] { 45, 12, 4, 7, 7, 9, 6, 150, 45, 65 };
//int somme = 0;
//for (int index = 0; index < tableau.Length; index++)
//{
//    somme = somme + tableau[index]; 
//}

//Console.WriteLine(somme);


// Tableau qui contient des string de noms . On veut verifier si le nom toto se trouve dans le tableau. 
// SI oui, affichez Oui , sinon afficher Non


string[] tabNom = new string[7] { "titi", "tata", "tutu", "tete", "tyty", "toto", "tito" };


//prendre chaque element et comparer avec toto 
//si on trouve dire oui 
//sinon dire non 

//tabNom[0] == "toto"
//tabNom[1] == "toto"
//tabNom[2] == "toto"
//    ...
//tabNom[6] == "toto"

//bool totoExiste = false;
//int Existe = -1;

//for (int index = 0; index < tabNom.Length; index++)
//{
//    if (tabNom[index] == "toto")
//        Existe = 1;
//}

//if (Existe == 1)
//    Console.WriteLine("Oui");
//else
//    Console.WriteLine("Non");



//// Un programme qui recoit un tableau et calcul la MOYENNE de tous les elements du tableau 
////decimal
////moyenne = somme / nombreElements

//decimal[] tab = new decimal[4] { 10, 12, 12, 11 };

//decimal somme = 0;
//decimal moyenne = 0;
//for (int index = 0; index < tab.Length; index++)
//{
//    somme = somme + tab[index];
//}

//moyenne = somme / tab.Length;

//Console.WriteLine("Moyenne :" + moyenne);


/// On nous donne un tableau et on veut que le programme nous affiche l'index de la valeur 10 
/// 

int[] tableau = new int[10] { 45, 12, 4, 7, 1, 9, 6, 10, 45, 65 };

/*tableau[0] = 10
 * tableau[7] 
 * 
 * Parcourir le tableau   okay
 * 
 * chercher la valeur 10  - comparer chque element du tableau avk la valeur 10   okay
 * 
 * si on trouve 10 on affiche son index
 * 
 * sinon on ne fait rien 
 * 
 * 
 * 
 * Resulat = 7
 */

//for (int index = 0; index < tableau.Length; index++)
//{
//    if (tableau[index] == 10)
//    {
//        Console.WriteLine("L'index est : " + index);  
//    }
//}

//index[0] = 0;
//for (int index = 0; index < tableau.Length; index++)
//{
//    Console.WriteLine(index[0]);
//    if()
//}




/*
 * 
 *  tableau de string , afficher le nombre de fois qu'on trouve le nom toto dans le tableau 
 *  
 *  
    string[] tabNom = new string[7] { "titi", "tata", "tutu", "tete", "tyty", "toto", "tito" };

    Le total est : 1

    string[] tabNom = new string[7] { "titi", "toto", "tutu", "toto", "tyty", "toto", "tito" };

    Le total est : 3
 * 
 * 
 * Coco 
 * 
 * comparer chaque element avec toto 
 * si c'est le cas on fait un total
 * 
 * afficher le total 
 * 
 * 
 */

string[] tabNomCoco = new string[7] { "titi", "tata", "tutu", "tete", "tyty", "toto", "tito" };

for (int toto = 0; toto < tabNom.Length; toto++)
{
    if (tabNomCoco[toto] == "toto")
    {

    }
}


/*
 * 
 * Serge 
 * 
 * int toto = 1 
 * 
 * for ou foreach
 * 
 */

//for (int index = 0; index < tabNom.Length; index++)
//{
//    if (tabNom[index] == "toto")
//    {
//        Console.WriteLine("Le nombre est : " +index);
//    }
//}


string[] tableauDePrenom = new string[7] { "toto", "tata", "tutu", "toto", "tyty", "toto", "tito" };

/**
 * 
 * tableau de string , afficher le nombre de fois qu'on trouve le nom toto dans le tableau 
 * 
 *  boucle okay
 *  
 *  comparaison 
 *  1 + 1 = 2 +1 = 3 +1 = 4 
 */

int totalNombreDeToto = 0;
for (int index = 0; index < tableauDePrenom.Length; index++)
{
    if (tableauDePrenom[index] == "toto")
    {
        totalNombreDeToto = totalNombreDeToto + 1;
    }
}

Console.WriteLine("Le total est :" + totalNombreDeToto);


foreach (var item in tableauDePrenom)
{
    if(item == "toto")
    {
        totalNombreDeToto = totalNombreDeToto + 1;
    }
}

Console.WriteLine("Le total est :" + totalNombreDeToto);