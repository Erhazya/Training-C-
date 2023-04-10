using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Net.Security;

class Program
{


    enum e_Operateur 
    { 
        ADDITION = 1 , MULTIPLICATION = 2, SOUSTRACTION = 3 , DIVISION = 4
    }

    static void game(int nombre_calcul, int points)
    {
        Random random = new Random();

        string resultat = "";
        int resultat_int = 0;


        int reponse = 0;


        int nb1 = 0;
        int nb2 = 0;




        
        





        for(int i = 0 ; i < nombre_calcul ; i++) {
            
                nb1 = random.Next(1,10);
            nb2 = random.Next(1,10);
            e_Operateur choix_signe = (e_Operateur)random.Next(1,4);

            Console.WriteLine("Question n°"+ (i+1) + " sur " + nombre_calcul);

            if(choix_signe == e_Operateur.ADDITION)
            {
                Console.WriteLine(nb1 + " + " + nb2 + " = ");
                reponse = nb1 + nb2; 

            }
            else if (choix_signe == e_Operateur.MULTIPLICATION)
            {
                Console.WriteLine(nb1 + " * " + nb2 + " = ");
                reponse = nb1 * nb2;

            }
            else if (choix_signe == e_Operateur.SOUSTRACTION)
            {
                Console.WriteLine(nb1 + " - " + nb2 + " = ");
                reponse = nb1 - nb2;

            }
            else if (choix_signe == e_Operateur.DIVISION)
            {
                Console.WriteLine(nb1 + " / " + nb2 + " = ");
                reponse = nb1 / nb2;

            }



                
                    resultat = Console.ReadLine();
                    
                



                try
                {
                    
                    resultat_int = int.Parse(resultat);

                    if (resultat_int == reponse)
                    {
                        Console.WriteLine("Bravo !");
                    }

                    points += 1;

                   

                }
                catch
                {
                    Console.WriteLine("Erreur, vous devez entrer un nombre");
                    
                }
            




        }

        Console.WriteLine("Vous avez eu "+ points + "/"+nombre_calcul);




    }


    static int nb_evalutation()
    {
        


        int nb_calcul_int = 0;

        while (nb_calcul_int == 0)
        {

            try
            {
                Console.WriteLine("Combien de calcul voulez vous ?");
                string nb_calcul = Console.ReadLine();
                nb_calcul_int = int.Parse(nb_calcul);
            }
            catch { Console.WriteLine("Erreur : le nombre entrer n'est pas valide"); }



            
        }
        return nb_calcul_int;
    }



    static void Main(string[] args)
    {
        string nb_calcul = "";


        Console.WriteLine("Bonjour,");
        Console.WriteLine("Bienvenue dans le jeu de math");



        game(nb_evalutation(),0);



    }


}