using System;
using System.Xml.Linq;

namespace Program
{


    class Enfant : Etudiant
    {

        string infosEtudes;
        string classeEcole;

        Dictionary<string, float> notesMoyennes;


        public Enfant(string nom, int age, string infoEtudes = null, string classeEcole = null, Dictionary<string, float> notesMoyennes = null) : base(nom, age)
        {

            this.infosEtudes = infoEtudes;
            this.classeEcole = classeEcole;
            this.notesMoyennes = notesMoyennes;
        }

        public override void Afficher()
        {
            AfficherNomAge();

            Console.WriteLine("     Etablissement scolaire : " + infosEtudes);
            Console.WriteLine("     Enfant en classe de : " + classeEcole);


            if (notesMoyennes is not null && notesMoyennes.Count > 0 )
            {

                Console.WriteLine("     Notes Moyenne : ");
                foreach (var notes in notesMoyennes)
                {
                    Console.WriteLine("     " + notes.Key + " : " + notes.Value + "/10");
                }
            }

            if (professeurPrincipal is not null)
            {
                professeurPrincipal.Afficher();

            }


        }



    }


    class Etudiant : Personne
    {

        string infosEtudes;

        public Personne professeurPrincipal; 

        public Etudiant(string nom, int age,string emploi =null,string infoEtudes = null) : base(nom, age, emploi) {
        
            this.infosEtudes = infoEtudes;
            
        }

        public override void Afficher ()
        {
            AfficherNomAge();

            Console.WriteLine("     Etablissement scolaire : " + infosEtudes) ;


            if(professeurPrincipal is not null)
            {
               professeurPrincipal.Afficher();

            }


        }

        

    }


    class Personne : IAffichable
    {

        static int nombrePersonne = 0;


        //public string nom{get ;set}



        public string nom { get; init; }
        public int age { get; init; }
        protected string emploi;
        protected int numeroPersonne;


        //Full info
        public Personne(string nom = null, int age = 0, string emploi = null)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;
            nombrePersonne++;
            this.numeroPersonne = nombrePersonne;

        }
        

        public virtual void Afficher()
        {
            AfficherNomAge();

            if (emploi is not null)
            {

                Console.WriteLine("     Emploi : " + emploi);
            }
            else
            {
                Console.WriteLine("     Aucun emploi spécifié");
            }


        }

        protected void AfficherNomAge()
        {

            Console.WriteLine("Bonjour Personne " + numeroPersonne);
            Console.WriteLine("     Nom :" + nom);
            Console.WriteLine("     Age :" + age + " ans");

        }


        public static void AfficherNombrePersonne()
        {
            Console.WriteLine("Le nombre de personne de la liste est : " + Personne.nombrePersonne);

        }


    }



    class TableDeMultiplication : IAffichable
    {

        int numero; 

        public TableDeMultiplication(int numero)
        { 
            
            this.numero = numero; 
        
        
        }

        public void Afficher() 
        {

            Console.WriteLine("Table de multiplication de " + numero);

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + numero + " = " + (numero * i));
            }
        
        
        }


    }



    interface IAffichable
    {
        void Afficher();
    }




    class Program
    {
        static void Main(string[] args)
        {




            var elements = new List<IAffichable> { new Personne("Paul",34,"Ouvrier"),
                new Personne("Jacques", 39, "Infirmier"),
                new Etudiant("Paul",17,"Etudiant","Ecole Lalouveir"),
                new Enfant("Jules", 8, "Etudiant", "Ecole Lalouveir"),
                new TableDeMultiplication(5)
                                                };


            //elements = elements.Where(p => p.nom[0]  == 'D' && p.age >25).ToList();



            foreach (var element in elements)
            {
                element.Afficher();
                

            }

            Personne.AfficherNombrePersonne();



            






            

            



            


        }
    }
}