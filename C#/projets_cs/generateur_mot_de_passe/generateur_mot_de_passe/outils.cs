using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliErhazya
{
    static class outils
    {

        public static int DemanderNombrePositifNonNull(string question)
        {

            /*int nombre = longueur_pass();
            if (nombre > 0)
            {

                return nombre;
            }
            else
            {
                Console.WriteLine($"Erreur, le mot de passe doit etre supérieur a 0");
                return DemanderNombrePositifNonNull();
            }*/

            return DemanderNombreEntre(question,1, int.MaxValue);

        }


        public static int DemanderNombreEntre(string question,int min, int max)
        {

            Console.WriteLine(question);

            string nombre = Console.ReadLine();
            int nb = int.Parse(nombre);
            
            if ((nb >= min) && (nb <= max))
            {

                return nb;
            }
            else
            {
                Console.WriteLine($"Erreur, le mot de passe doit etre entre {min} caractères et {max}");
                return DemanderNombreEntre(question,min, max);
            }





        }

        public static int longueur_pass()
        {
            string longueur = "";
            int longueur_int = 0;
            Console.Write("Quelle longueur souhaitez vous pour le mot de passe ?");

            while (true)
            {

                try
                {
                    longueur = Console.ReadLine();
                    longueur_int = int.Parse(longueur);
                    return longueur_int;
                }
                catch
                {
                    Console.WriteLine("Erreur, veuillez entrer un nombre");
                }


            }

        }

        public static int DemanderTypeDeCaractere() { return 0; }





    }
}
