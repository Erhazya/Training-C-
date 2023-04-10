using Newtonsoft.Json;
using Program;
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Net;



namespace Program
{
    class PizzaPersonnalisee : Pizza
    {


        //variable pizza perso

        int nbI;
        string ingredientPerso;
        static int nbPizzasPersonnalisee = 0;



        public PizzaPersonnalisee() : base("Personnalisee", 5, false, null)
        {
            nbPizzasPersonnalisee++; //nombre pizza perso

            nom = "Pizza Personnalisée " + nbPizzasPersonnalisee;


            ingredients = new List<string>();

            Console.WriteLine("Appuyez sur ENTER pour finir votre pizza");


            while (true)
            {
                //Boucle demande ingrédients


                nbI++;

                Console.WriteLine("Donner l'ingredients numero " + nbI + " : ");

                if (ingredients.Count > 0)
                {
                    //Ajoute virgule si liste sup 1
                    Console.WriteLine(string.Join(",", ingredients));




                }

                ingredientPerso = Console.ReadLine().ToLower();


                if (string.IsNullOrWhiteSpace(ingredientPerso))
                {

                    //break la boucle si null ou espace
                    break;

                }

                if (ingredients.Contains(ingredientPerso))
                {
                    //Testeur si ingrédients déja présent
                    Console.WriteLine("Vous avez deja rentrer cette ingrédients");

                }
                else
                {
                    ingredients.Add(ingredientPerso);

                }

            }

            foreach (var i in ingredients)
            {
                //Ajout prix par ingrédient 
                prix += 1.5f;
            }

        }



    }

    class Pizza
    {
        //Variable principale 
        public float prix { get; protected set; }
        public string nom { get; protected set; }
        public bool vegetarienne { get; init; }


        //Nom Afficher, formatage premiere lettre MAJ
        string nomAfficher;
        public List<string> ingredients { get; protected set; }
        List<string> ingredientsAfficher;


        public Pizza(string nom = "", float prix = 0, bool vegetarienne = false, List<string> ingredients = null)
        {
            //Constructeur principal avec tout les param avec valeur de base

            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
            this.ingredients = ingredients;



        }


        public void Afficher()
        {
            //Affichage Pizza


            nomAfficher = FormaPremiereLettreMajuscule(nom);
            ingredientsAfficher = new List<string>();

            foreach (string s in ingredients)
            {
                ingredientsAfficher.Add(FormaPremiereLettreMajuscule(s));
            }





            Console.WriteLine("Pizza choisie : " + nomAfficher);
            if (vegetarienne)
            {
                Console.Write(" (V) ");
            }


            Console.WriteLine(string.Join(", ", ingredientsAfficher));

            Console.WriteLine("Prix : " + prix + " €");



        }


        private static string FormaPremiereLettreMajuscule(string s)
        {
            //Formatage Premiere lettre MAJ

            if (string.IsNullOrEmpty(s))
            {

                return s;
            }

            string nomMinuscules = s.ToLower();
            string nomMajuscules = s.ToUpper();
            string resultat = nomMajuscules[0] + nomMinuscules[1..];

            return resultat;

        }




    }












    class Program
    {
        static List<Pizza> GetPizzaFromCode()
        {
            List<Pizza> listePizza = new List<Pizza>() {

            new Pizza("4 Fromages",9.5f,false,new List<string>() { "mozarella","comté","gruyeres","pecorrino"}),
            new Pizza("Aubergine",11.5f,true,new List<string>() { "aubergine", "olive", "tomates", "fromages" }),
            new Pizza("Carbo",9f,false,new List<string>() { "mozarella", "lardon", "jambon", "sauce tomates creme" }),
            new Pizza("Vegetarienne",14.5f,true,new List<string>() { "olive", "epinard", "tomates", "basilic" }),
            //new PizzaPersonnalisee(),
            //new PizzaPersonnalisee()

            };
            return listePizza;

            

        }

        static List<Pizza> GetPizzaFromFile(string filename)
        {


            string file = filename; 

            string json = null;

            List<Pizza> listePizza = null;


            try
            {
                json = File.ReadAllText(file);

                //Testeur si fichier existe
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
                //Message erreur + Break

            }

            try
            {
                return listePizza = JsonConvert.DeserializeObject<List<Pizza>>(json);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans la Déserialisation");

                return null;

            }






            

        }
        static void GeneratePizzaJsonFile(List<Pizza> listePizza , string filename)
        {

            var listPizzaJson = JsonConvert.SerializeObject(listePizza);
            string fileName = filename;


            File.WriteAllText(fileName, listPizzaJson);


        }


        static List<Pizza> GetPizzaFromUrl(string url)
        {

            var webClient = new WebClient();




            string response = webClient.DownloadString(url);


            var json = JsonConvert.DeserializeObject<List<Pizza>>(response);

            return json; 

            

        }










            static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            string filename = "out/pizza.json";

            //var pizzas = GetPizzaFromCode();
            //var pizzas = GetPizzaFromFile(filename);
            //GeneratePizzaJsonFile(pizzas, filename);




            var pizzas = GetPizzaFromUrl("https://codeavecjonathan.com/res/pizzas2.json");



            foreach (var pizza in pizzas)

            {

                pizza.Afficher();
            }




        }
    }
}
