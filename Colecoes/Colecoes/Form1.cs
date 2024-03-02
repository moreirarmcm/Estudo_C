using System;
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
            List <String> lista = new List <String> ();
            lista.Add("Renan");
            lista.Add("Rayane");
            lista.Add("Ruan");
            Lista.Items.Clear ();
            lista.Sort ();
            Lista.Items.AddRange(lista.ToArray());
            Lista.Items.Add("A lista possui " + lista.Count.ToString() + " itens.");

          /*  if (lista.Contains("Renan"))
            {
                MessageBox.Show("Há um Renan");
            }*/
        }
    }
}
