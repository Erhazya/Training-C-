using System;


namespace programme_collections
{
    class Program
    {

        /*
        static void AfficherTableaux(int[] t)
        {

            for(int i = 0 ; i < t.Length; i++)
            {
                Console.WriteLine($"[{i}]"+t[i]);
            }


        }
        static void AfficherValeurMax(int[] t)
        {

            int valeurMax = 0;

            for (int i = 0; i < t.Length; i++)
            {

                if (valeurMax < t[i])
                {
                    valeurMax = t[i];
                }
            }
            Console.WriteLine("Valeur max est " + valeurMax);

        }
        static void Tableaux()
        {
            Random rnd = new Random();
            const int TAILLE_TABLEAU = 20;
            int[] t = new int[TAILLE_TABLEAU];

            int valeurMax = 0;
            
            for(int i = 0 ;i < t.Length; i++)
            {
                t[i] = rnd.Next(0,100);

                if(valeurMax < t[i])
                {
                    valeurMax = t[i];
                }
            }



            AfficherTableaux(t);
            AfficherValeurMax(t);

            
        
        
        }


        static void AfficherNomGrand(List<string> liste)
        {
            string nomLong = "";
            
            for (int i = liste.Count - 1; i >= 0; i--)
            {
                string nom = liste[i];
                if (nom.Length > nomLong.Length)
                {
                    nomLong = liste[i];

                }
                
            }

            Console.WriteLine();
            Console.WriteLine("Nom le plus long : "+ nomLong);
        }
        static void AfficherListes(List<string> liste,bool ordreDescendant = false)
        {
            if (ordreDescendant) 
            {
                for (int i = liste.Count-1; i >= 0; i--)
                {
                    Console.WriteLine(liste[i]);
                }


            }
            else 
            { 

                for(int i = 0; i < liste.Count;i++)
                {
                    Console.WriteLine(liste[i]);
                }

            }
        }
        static void Listes() 
        {
        
            List<string> liste = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Donne un nom :");
                string name = Console.ReadLine();
                liste.Add(name);

                
            }



            AfficherListes(liste,true);


        
        }

        */

        /*
        static void Doublons(List<string> list1, List<string> list2)
        {

            for(int i = 0 ; i < list1.Count; i++)
            {
                string name = list1[i];
                if (list2.Contains(name)){

                    Console.WriteLine("La liste 2 contiens aussi " + list1[i]);

                }


            }


        }


        static void Listes()
        {

            var liste1 = new List<string>() { "Andy", "Lucas", "Loic","Lea","Henri"};
            var liste2 = new List<string>() { "Andy", "Julien", "Bléreau", "Lea","Julius","bernard","Henri" };

            Doublons(liste1, liste2);


        }
        */

        /*
        static void Listes()
        {

            var villes = new List<List<string>>();

            var france = new List<string> { "Paris", "Bordeau", "Lyon" };

            villes.Add(france);


            Console.WriteLine(villes[0][1]);


        }



        */


        static void Dictionnaire() { 
        
            var d = new Dictionary<string, string>();

            d.Add("Jean", "0684848848");
            d.Add("Aarie", "0684345838");

            var nomTries = d.OrderBy(key => key );

            foreach ( var key in nomTries)
            {
                Console.WriteLine( key.Key );
            }
            


        }



        static void Main(string[] args)
        {

           

            Dictionnaire();
            




        }

}
}



 

