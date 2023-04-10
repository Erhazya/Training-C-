using System;
using System.Text;

namespace Program
{
    class PizzaPersonnalisee : Pizza
    {

        int nbI;
        string ingredientPerso;
        static int nbPizzasPersonnalisee = 0;



        public PizzaPersonnalisee() : base("Personnalisee", 5, false, null)
        {
            nbPizzasPersonnalisee++;

            nom = "Pizza Personnalisée " + nbPizzasPersonnalisee;
            

            ingredients = new List<string>();

            Console.WriteLine("Appuyez sur ENTER pour finir votre pizza");


            while (true) {
                nbI++;

                Console.WriteLine("Donner l'ingredients numero " + nbI + " : ");

                if (ingredients.Count > 0)
                {

                    Console.WriteLine(string.Join(",", ingredients));

                    


                }

                ingredientPerso = Console.ReadLine().ToLower();


                if (string.IsNullOrWhiteSpace(ingredientPerso))
                {
                    break;
                    
                }

                if (ingredients.Contains(ingredientPerso))
                {
                    Console.WriteLine("Vous avez deja rentrer cette ingrédients");

                }else
                {
                    ingredients.Add(ingredientPerso);

                }

            }

            foreach (var i in ingredients)
            {
                prix += 1.5f;
            }

        }



    }

    class Pizza
    {

        public float prix { get; protected set; }
        public string nom { get; protected set; }
        public bool vegetarienne { get; init; }
        string nomAfficher;
        public List<string> ingredients { get; protected set; }
        List<string> ingredientsAfficher;


        public Pizza(string nom = "", float prix = 0, bool vegetarienne = false, List<string> ingredients = null)
        {


            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
            this.ingredients = ingredients;



        }


        public void Afficher()
        {

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
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;





            var listePizza = new List<Pizza>() {

            new Pizza("4 Fromages",9.5f,false,new List<string>() { "mozarella","comté","gruyeres","pecorrino"}),
            new Pizza("Aubergine",11.5f,true,new List<string>() { "aubergine", "olive", "tomates", "fromages" }),
            new Pizza("Carbo",9f,false,new List<string>() { "mozarella", "lardon", "jambon", "sauce tomates creme" }),
            new Pizza("Vegetarienne",14.5f,true,new List<string>() { "olive", "epinard", "tomates", "basilic" }),
            new PizzaPersonnalisee(), 
            new PizzaPersonnalisee()

            };

            var a  = listePizza.Where(p => p.ingredients.Where(i => i.Contains("tomate")).ToList().Count > 0).ToList();

            Console.WriteLine(a);

            foreach (var pizza in listePizza)
            {
                pizza.Afficher();

            }












        }
    }
}