using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            AjusteComboBox(); //Cria os estados civis na ComboBox 

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AjusteComboBox()
        {
            comboEC.Items.Add("Solteiro");
            comboEC.Items.Add("Casado");
            comboEC.Items.Add("Viúvo");
            comboEC.Items.Add("Separado");
            comboEC.SelectedIndex = 0;
        }
        public void Listar()
        {
            listLista.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                //listLista.Items.Add(p.ToString());
                listLista.Items.Add(p.nome);
            }
        }
    }
}
