using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            List<String> lista = new List <String> ();
            lista.Add("Renan");
            lista.Add("Rayane");
            lista.Add("Ruan");
            lista.Sort ();
            Lista.Items.AddRange(lista.ToArray());
            Lista.Items.Add("A lista possui " + lista.Count.ToString() + " itens.");

          /*  if (lista.Contains("Renan"))
            {
                MessageBox.Show("Há um Renan");
            }*/
        }

        private void btnHashset_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear ();
            HashSet<String> veiculos = new HashSet<String>() {"Carro","Avião","Helicóptero","Barco" };
            Lista.Items.AddRange(veiculos.ToArray());

        } 

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            Dictionary<int, String> alunos = new Dictionary<int, String>()
            {
                {1,"Renan"},
                {2,"Rayane"},
                {3, "Ruan"}
            };
            alunos.Add(4, "Ramon");
            foreach(KeyValuePair <int,String> aluno in alunos)
            {
                //Lista.Items.Add(aluno);
                Lista.Items.Add(aluno.Value);
            }   
        
        }

        private void btnSorted_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            SortedList<int, string> lista_ordenada = new SortedList<int, string>()
            {
                {1,"Renan"},
                {2,"Rayane"},
                {3, "Ruan"}
                
            };
            foreach(KeyValuePair<int,string> lista in lista_ordenada)
            {
                Lista.Items.Add (lista.Value);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            SortedSet<string> sorted_set = new SortedSet<string>()
            {
                "Renan",
                "Ramon",
                "Douglas",
                "Caio"
            };
            Lista.Items.AddRange(sorted_set.ToArray());
            MessageBox.Show(sorted_set.ElementAt(1));
        } 
    }
}
