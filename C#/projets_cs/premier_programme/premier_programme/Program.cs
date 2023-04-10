using System;
using System.Runtime.CompilerServices;

class Program
{

    static string DemanderNom(int i)
    {
        string name = "";

        while (name.Trim() == "")
        {
            Console.WriteLine("Quel est ton nom " + i + " ?");
            name = Console.ReadLine();
            if (name == "") { Console.WriteLine("Erreur : le nom ne doit pas être vide"); }
        }

        return name;
    }





    static int DemanderAge(string name)
    {
        string age;
        int age_num = 0;
        while (age_num <= 0)
        {


            Console.WriteLine(name + " quel est ton age ?");
            age = Console.ReadLine();

            try
            {
                age_num = int.Parse(age);

            }

            catch
            {
                Console.WriteLine("Rentrer un age valide (Positif et supérieur a 0)");
            }

        }
        return age_num;
    }

    static void Afficher(string name, int age)
    {

        Console.WriteLine("Bonjour " + name + ", vous avez " + age + " ans");

        if(age >= 60) 
        { 
            Console.WriteLine("Vous êtes un sénior"); 
        }
        else if (age < 10){ Console.WriteLine("Vous êtes enfant"); }
        
        
    }
     

  

    static void Main(string[] args)
    {

        string name1 = DemanderNom(1);
        string name2 = DemanderNom(2);

        int age1 = DemanderAge(name1);
        int age2 = DemanderAge(name2);



        Afficher(name1, age1);
        Afficher(name2, age2);  








    }
}