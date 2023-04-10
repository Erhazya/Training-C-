using System;
using System.Text;

    class Program
    {



        class Employes {

            public int matricule { get; init; }
            public string name { get; init; }
            public string prenom { get; init; }
            public int dateNaissance { get; init; }
            public int dateEmbauche { get; init; }
            public float salaire { get; init; }



            public Employes(int matricule, string name, string prenom, int dateNaissance, int dateEmbauche, float salaire)
            {
                this.matricule = matricule;
                this.name = name;
                this.prenom = prenom;
                this.dateNaissance = dateNaissance;
                this.dateEmbauche = dateEmbauche;   
                this.salaire = salaire;





            }


            public void Afficher()
            {
                Console.WriteLine("Matricule : " + matricule);
                Console.WriteLine("Nom : " + name);
                Console.WriteLine("Prénom : " + prenom);
                Console.WriteLine("Année de Naissance : " + dateNaissance);
                Console.WriteLine("Date d'embauche : " + dateEmbauche);
                Console.WriteLine("Salaire : " + salaire + " €");




            }

            public void Anciennete(int dateEmbauche)
            {
                Afficher();
                int annee = DateTime.Now.Year;  
                
                int anciennete = annee - dateEmbauche;

                Console.WriteLine("8 années d'ancienneté");
            

            }

            public void ActualiserSalaire(int dateEmbauche,float salaire)
            {
                Anciennete(dateEmbauche);
                int annee = DateTime.Now.Year;

           
                salaire += 100 * (annee -dateEmbauche);

                Console.WriteLine("Votre salaire est actuellement de " + salaire + " €");

            }








        }











        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Employes employe1 = new Employes(1, "Herlander", "Logan", 1980, 2000, 1000);
            //employe1.Afficher();
            //employe1.Anciennete(employe1.dateEmbauche);


            employe1.ActualiserSalaire(employe1.dateEmbauche,employe1.salaire) ;

            




        }
    }
