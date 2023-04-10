using System;
using System.Reflection.Emit;

using AsciiArt;

namespace jeu_du_pendu
{
    class Program
    {


        static void AfficherMot(string mot, List<char> lettres)
        {

            string motCacher_PATTERN = "_ ";
            string motCacher = "";


            for (int i = 0; i < mot.Length; i++)
            {
                char lettre = mot[i];





                if (lettres.Contains(lettre))
                {


                    Console.Write(lettre);

                } else
                {
                    Console.Write("_");
                }

            }
            Console.WriteLine();



        }


        static char DemanderUneLettre()
        {

            while (true) {
                Console.Write("Donner une lettre du mot : ");
                string reponse = Console.ReadLine();
                if (reponse.Length == 1)
                {
                    reponse = reponse.ToUpper();
                    return reponse[0];
                }
                Console.WriteLine("Erreur, vous devez rentre une lettre");
            }


        }


        static string[] ChargerLesMots(string nomfichier)
        {

            try
            {
                return File.ReadAllLines(nomfichier);

            }catch(Exception ex) {

                Console.WriteLine("Erreur dans le chargement du fichier " + ex.Message);
            
            }
            return null; 





        }

        static void DevinerMot(string mot)
        {


            



            var lettres = new List<char>();
            var lettresErronees = new List<char>();
            const int NB_vies = 6;
            int vieRestantes = NB_vies;


            while (vieRestantes > 0)
            {

                Console.WriteLine(Ascii.PENDU[NB_vies-vieRestantes]);

                bool statut = TouteLettresDevinees(mot, lettres);

                if (statut is true)
                {
                    Console.WriteLine("Vous avez GAGNER !");
                    break;
                }

                AfficherMot(mot, lettres);
                Console.WriteLine();
                var lettre = DemanderUneLettre();
                Console.Clear();
                if (mot.Contains(lettre))
                {
                    Console.WriteLine("Cette lettre est dans le mot");
                    lettres.Add(lettre);

                }
                else
                {
                    if (lettresErronees.Contains(lettre)) {



                    }
                    else
                    {
                        lettresErronees.Add(lettre);
                        vieRestantes--;
                    }

                    Console.WriteLine("Cette lettre n'est pas dans le mot, Tu as déja rentrer ces lettres ci : " + String.Join(", ", lettresErronees));
                    Console.WriteLine("Il vous reste "+ vieRestantes + " vies");

                }

         

            }
            if (vieRestantes == 0)
            {

                Console.WriteLine(Ascii.PENDU[NB_vies]);
                Console.WriteLine("Vous avez PERDU ! Le mot était "+ mot);

            }
            


        }


        
        static bool TouteLettresDevinees (string mot,List<char> lettres)
        {
            foreach(var lettre in lettres) { 
                mot = mot.Replace(lettre.ToString(), "");

            }
            if (mot == "") { return true; }
            else { return false; }
            


            
        }





            static void Main(string[] args)
        {



            var mots = ChargerLesMots("mots.txt");


            if((mots == null) || (mots.Length == 0)) {
                Console.WriteLine("La liste de mot est vide");
            }
            else { 
                string mot = mots[0].Trim();

                DevinerMot(mot);
            }


        }




    }
}