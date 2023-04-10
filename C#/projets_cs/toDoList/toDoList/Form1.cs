using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace toDoList
{
    public partial class ToDoList : Form
    {
        private int clickcount = 0; //clickcount pour le nombre de box

        public bool TesteurTaskNotEmpty(string text)
        {


            if (text.Trim() == "" || text == "Veuillez entrer une tâche")
            {
                //If de si la textbox est égale a Rien ou au message prédéfini

                return true;


            }
            return false;

        }





        public void CreationCheckBox(int id)
        {


            var checkBox = new System.Windows.Forms.CheckBox(); // Créer une nouvelle CheckBox
            if (TesteurTaskNotEmpty(textBox1.Text))
            {
                textBox1.Text = "Veuillez entrer une tâche";

            }
            else {




                this.checkedListBox1.Items.Add(textBox1.Text);

                textBox1.Clear();   

            }



        }

        public void RemoveAllBox()
        {
            checkedListBox1.Items.Clear();


            clickcount = 0;


        }

        public void RemoveSelectedBox()
        {


            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox1.GetItemChecked(i))
                    checkedListBox1.Items.RemoveAt(i);


            }



        }


        public void SaveInFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Configurer le dialogue de sélection de fichier
            saveFileDialog1.InitialDirectory = Application.StartupPath; // Répertoire initial
            saveFileDialog1.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"; // Filtre des types de fichiers
            saveFileDialog1.FilterIndex = 1; // Type de fichier sélectionné par défaut

            // Afficher la fenêtre de dialogue de sélection de fichier
            DialogResult result = saveFileDialog1.ShowDialog();

            // Vérifier si un fichier a été sélectionné
            if (result == DialogResult.OK)
            {
                // Récupérer le chemin complet du fichier sélectionné
                string filePath = saveFileDialog1.FileName;
                int i = 0;
                foreach (var item in checkedListBox1.Items)
                {

                    File.AppendAllText(filePath, item.ToString() + ";" + checkedListBox1.GetItemCheckState(i).ToString() + "\n");
                    i++;
                }

            }





        }

        public void OpenWithLastFile()
        {
            var folder = new DirectoryInfo(Application.StartupPath);
            var files = folder.EnumerateFiles();


            var lastModifiedFile = files.OrderBy(fi => fi.Extension == ".txt").Last();


           
                 
            var filePath = lastModifiedFile.FullName;
            LoadFile(filePath);
            return; 
                
            

            

            
        }


        public void LoadFile(string file = null)
        {
           checkedListBox1.Items.Clear();

           if(file is null)
           {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = Application.StartupPath;
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Récupérer le chemin complet du fichier sélectionné
                    string filePath = openFileDialog1.FileName;

                    // Faire quelque chose avec le fichier sélectionné, par exemple l'afficher dans un label
                    file = filePath;
                }
                
                
            }
            
           if (File.Exists(file))
           {

                try {

                    int index = 0;
                    foreach (var Lines in File.ReadLines(file))
                    {

                        var boxName = Lines.Split(';')[0];
                        var boxStatus = Lines.Split(';')[1];
                        bool status;

                        if (boxStatus.Equals("Checked"))
                        {
                            status = true;
                        }
                        else status = false;

                        checkedListBox1.Items.Add(boxName);
                        checkedListBox1.SetItemChecked(index, status);




                        index++;


                    }







                }
                catch (Exception) { }
                 

               

           }


            


           


            
            
            


        }




        public ToDoList()
        {
            InitializeComponent();
            OpenWithLastFile();
        }





        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)            //La box de toute les checkbox
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)            //Box de texte où ecrire la déf de la task
        {
        }
        




        private void button2_Click(object sender, EventArgs e) //Creation check box
        {
            clickcount++;


            CreationCheckBox(clickcount);

            

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            RemoveAllBox();
        }//remove all box

      

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveSelectedBox();
        }//remove box selected

        

        private void button4_Click(object sender, EventArgs e) //sauvegarder
        {
            SaveInFile();
        }





        private void button5_Click(object sender, EventArgs e) //Charger des task 
        {
            LoadFile();
        }
    }
}
