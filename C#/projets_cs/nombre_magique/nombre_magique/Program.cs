using System;

class nombre_magique
{

    static int DemanderVie()
    {

        string nb_vie = "";
        int nb_vie_num = 0;


        while (nb_vie_num == 0)
        {
            Console.WriteLine("Bonjour, combien souhaites-tu avoir de vie ? ");
            nb_vie = Console.ReadLine();

            try
            {
                nb_vie_num = int.Parse(nb_vie);
            }
            catch
            {
                Console.WriteLine("Erreur : Le nombre de vie doit être supérieur a 0");
            }
        }
        return nb_vie_num;

    }

    static int DevinerNombre(int vie)
    {

        Random random = new Random();

        const int nb_min = 1;
        const int nb_max = 10;

        int nombre = random.Next(nb_min,nb_max);



        string nombre_deviner;
        int nombre_deviner_int = 0;
        //int nb_vie = vie;


        //for(nb_vie = vie ; nb_vie > 0;nb_vie--)

        while (vie != 0 )
        {
            vie--;

            Console.WriteLine($"Essaye de deviner le nombre !(entre {nb_min} et {nb_max})");
            nombre_deviner = Console.ReadLine();

            try
            {
                nombre_deviner_int = int.Parse(nombre_deviner);


                if (nombre_deviner_int < nb_min || nombre_deviner_int > nb_max)
                {
                    Console.WriteLine("Erreur, le nombre entrée n'est pas compris dans la plage a deviner");
                    vie++;
                }
                else 
                
                {
                    if (nombre_deviner_int == nombre)
                    {
                        Console.WriteLine("Vérification....");
                        Console.WriteLine("Félicitations !!! Vous avez trouvez ");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Vérification....");
                        if (nombre_deviner_int < nombre) { Console.WriteLine("Le nombre a deviner est plus grand"); }
                        else { Console.WriteLine("Le nombre a deviner est plus petit"); }

                        Console.WriteLine("Numéro éronné vous pouvez réessayer encore " + vie + " fois");
                    }


                }

            }
            catch { 
                Console.WriteLine("Erreur, le numéro n'est pas valide, réessayer, cette erreur ne vous a pas enlevez de vie");
                vie++; 
            }




        }

        if (nombre_deviner_int != nombre && vie == 0) { Console.WriteLine("Dommage, vous navez pas trouver"); };



        return nombre_deviner_int;
    }

    



        static void Main(string[] args)
        {

        


        int vie = DemanderVie();

        DevinerNombre(vie);
        




        
        

        






        }
    }
