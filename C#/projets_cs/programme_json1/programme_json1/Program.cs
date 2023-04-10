using Newtonsoft.Json;
using System;
using System.Runtime.InteropServices;

class Personne
{
    public string Name { get; set; }
    public int Age { get; set; }


   

    public void Afficher()
    {
        Console.WriteLine(Name + " " + Age);
    }
}



class Program
{
        
     






        static void Main(string[] args)
        {
        /*var personne1 = new Personne { Name = "Jean", Age = 18 };

        personne1.Afficher();

        var json = JsonConvert.SerializeObject(personne1);


        List<string> noms = new List<string>() { "Jean", "Paul", "Claire" } ;


        var jsonList = JsonConvert.SerializeObject(noms);

        Console.WriteLine(jsonList);*/


        /*
        List<Personne> list = new List<Personne>();

        list.Add(new Personne{ Name = "Jean",Age = 20});
        list.Add(new Personne{ Name = "Paul", Age = 18 });
        list.Add(new Personne{ Name = "Claire", Age = 22 });

        var jsonList = JsonConvert.SerializeObject(list);





        var path = "out";

        string filename = "personne.json";


        string pathAndFile = Path.Combine(path, filename);


       

        File.WriteAllText(pathAndFile,jsonList);
        */


        var path = "out";

        string filename = "personne.json";


        string pathAndFile = Path.Combine(path, filename);

        
        string text = File.ReadAllText(pathAndFile);

        var personne = JsonConvert.DeserializeObject<List<Personne>>(text);

        foreach(var p in personne)
        {

            p.Afficher();
        }
             





    }






}
