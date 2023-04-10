using System;
using System.Net.NetworkInformation;

namespace programme_fichiers // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {



            var path = "out";

            string filename = "monFichier.txt" ;


            string pathAndFile = Path.Combine(path, filename);


            if (File.Exists(pathAndFile))
            {
                File.Delete(pathAndFile);
            }

            string ligne = "";

            int nb = 50000;

            Console.WriteLine("Prepa données en cours ");

            for(int i = 0; i < nb; i++)
            {

                ligne += "Ligne " + i + "\n";

            }

            Console.WriteLine("Terminer");

            Console.WriteLine("Ecriture données");
            File.AppendAllText(pathAndFile, ligne);

            /*
            var nom = new List<string>() {

                "Jean",
                "Paul",
                "Belmondo"
            
            
            };

            File.AppendAllLines(pathAndFile, nom);

            try{
                

                var resultat = File.ReadAllLines(pathAndFile);

                foreach(string s in resultat)
                {
                    Console.WriteLine(s);
                }







            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }

           
            */


        }
    }
}