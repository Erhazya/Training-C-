using System;
using BibliErhazya;


class Program
{








    static void Main(string[] args)
    {
        const int nombrePassword = 10;
        Random rnd = new Random();
        string password = "";
        string minuscules = "abcdefghijklmnopqrstuvwxyz";
        string majuscules = minuscules.ToUpper();
        string chiffres = "0123456789";
        string caracteresSpeciaux = "#&@+-";
        string alphabet;



        Console.WriteLine("Bonjour, bienvenu dans le générateur de mot de passe");



        int longueurPassword = outils.DemanderNombrePositifNonNull("De quel taille doit-être le mot de passe ?");
        int typeAlphabet = outils.DemanderNombreEntre("Vous voulez un mot de passe : \n" +
            "1 - Uniquement en minuscules \n" +
            "2 - Avec des minuscules et Majuscules \n" +
            "3 - Des caractères et des chiffres \n" +
            "4 - Caractères,chiffres et caractères spéciaux \n" +
            "Votre choix ?", 1, 4);




        if (typeAlphabet == 1)
            alphabet = minuscules;
        else if (typeAlphabet == 2)
            alphabet = minuscules + majuscules;
        else if (typeAlphabet == 3)
            alphabet = minuscules + majuscules + chiffres;
        else
            alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;




        for (int j = 0; j < nombrePassword; j++) {
            password = "";

            for (int i = 0; i < longueurPassword; i++) {
            int a = rnd.Next(alphabet.Length);
            password = password + alphabet[a];
        }
        
        Console.WriteLine("Mot de passe " + (j+1) + " : " + password);

        }





    }


}