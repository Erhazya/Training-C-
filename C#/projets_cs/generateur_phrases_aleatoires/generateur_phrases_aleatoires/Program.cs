using System;


namespace generateur_phrases_aleatoires
{

    class Program
    {

        static string ObtenirElements(string[] t)
        {
            Random rnd = new Random();

          

            int nb1 = rnd.Next(t.Length);
           


            string phrase = t[nb1];

            


            return phrase;
           
        }


        static void Main(string[] args)
        {
            int count = 50;

            int countDoublons = 0;

            var sujets = new string[] {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fee",
                "Un magicien",
                "Une tortue",
            };

            var verbes = new string[] {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "avale",
                "néttoie",
                "se bat avec",
                "s'accoche à",
            };

            var complements = new string[] {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud",
            };
            List<string> listPhrases = new List<string>();


            while (listPhrases.Count < count) {

                var tab1 = ObtenirElements(sujets);
                var tab2 = ObtenirElements(verbes);
                var tab3 = ObtenirElements(complements);

                string phrase = tab1 + " " + tab2 +  " " + tab3;



                if (listPhrases.Contains(phrase))
                {
                    listPhrases.Remove(phrase);
                    countDoublons++;


                }
                else { listPhrases.Add(phrase); }

                


            }
            for (int i = 0;i < listPhrases.Count;i++) {

                Console.WriteLine(i+ "  " + listPhrases[i]);
            }
            Console.WriteLine("Il y a eu " + countDoublons);

            Console.WriteLine(listPhrases.Count);




    }












    }








}