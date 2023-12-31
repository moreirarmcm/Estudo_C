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

        public void btnEnviar_Click(object sender, EventArgs e)
        {
            int index = -1;
            int check_dados = 0;
           
            foreach(Pessoa p in pessoas)
            {
                if (p.nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(p);
                }
            }
            
            check_dados = ChecandoCampos();
           
            char sexo;
            if (radioMasc.Checked)
            {
                sexo = 'M';
            }else if (radioFem.Checked)
            {
                sexo = 'F';
            }else 
            {
                sexo = 'O';
            }
            
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txtNome.Text;
            pessoa.data_nascimento = txtData.Text;
            pessoa.estado_civil = comboEC.SelectedItem.ToString();
            pessoa.telefone = txtTelefone.Text;
            pessoa.veiculo = checkVeiculo.Checked;
            pessoa.casa_propria = checkCasa.Checked;
            pessoa.sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(pessoa);

            }
            else
            {
                pessoas[index] = pessoa;
            }
            btnLimpar_Click(sender, EventArgs.Empty);
            Listar();
        }

        private int ChecandoCampos()
        {
            int checando = 0;
            if (txtNome.Text == "")
            {
                checando++;
                MessageBox.Show("Preencha o campo nome.");
                txtNome.Focus();
            }
            if (txtTelefone.Text == "(  )      -")
            {
                checando++;
                MessageBox.Show("Preencha o campo telefone.");
                txtTelefone.Focus();
            }
            return checando;

        }
     
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtData.Text = "";
            comboEC.SelectedIndex = 0;
            txtTelefone.Text = "";
            checkCasa.Checked = false;
            checkVeiculo.Checked = false;
            radioMasc.Checked = true;
            radioFem.Checked = false;
            radioOth.Checked = false;
            txtNome.Focus() ;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = listLista.SelectedIndex;
            pessoas.RemoveAt(indice);
            Listar();
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

        private void listLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Pessoa p = pessoas[listLista.SelectedIndex];
            txtNome.Text = p.nome;
            txtData.Text = p.data_nascimento;
            comboEC.SelectedItem = p.estado_civil;
            txtTelefone.Text = p.telefone;
            checkCasa.Checked = p.casa_propria;
            checkVeiculo.Checked = p.veiculo;
            switch (p.sexo)
            {
                case 'M' :
                    radioMasc.Checked = true;
                    radioFem.Checked = false;
                    radioOth.Checked = false;
                    break;
                case 'F' :
                    radioMasc.Checked = false;
                    radioFem.Checked = true;
                    radioOth.Checked = false;
                    break;

                default:
                    radioMasc.Checked = false;
                    radioFem.Checked = false;
                    radioOth.Checked = true;
                    break;
            }
    
        }
    }
}
