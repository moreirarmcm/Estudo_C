using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaseKarate
{
    public partial class FormCadastramento : Form
    {
        private string nome_aluno, cpf_aluno, endereco, contato_aluno, contato_responsavel, graduacao, nome_responsavel, cpf_responsavel, parentesco;
        private DateTime data_nascimento, inicio_karate;
        private char sexo;
        private int acao = 0;
        public FormCadastramento()
        {
            InitializeComponent();
            timeInicio.CustomFormat = "MMMM yyyy";
        }
        public FormCadastramento(int acao)
        {
            this.acao = acao;
            InitializeComponent();
            timeInicio.CustomFormat = "MMMM yyyy";
            Administracao administracao = new Administracao();
            DataTable tabela_dados = administracao.ListandoDados(true, acao.ToString());
            DataRow linha_dados = tabela_dados.Rows[0];

            btnInsert.Text = "Atualizar dados";
            btnLimpar.Visible = false;
            
            txtNomeAluno.Text = linha_dados["NomeAluno"].ToString();
            txtCPF.Text = linha_dados["CPF"].ToString();
            txtEndereco.Text = linha_dados["Endereco"].ToString();
            if (linha_dados["Sexo"].ToString().Equals("M"))
            {
                radioMasculino.Checked = true;
            }
            else
            {
                radioFeminino.Checked = true;
            }
            txtContatoAluno.Text = linha_dados["Contato"].ToString();
            comboGraduacao.SelectedItem = linha_dados["Graduacao"].ToString();
            comboGraduacao.Enabled = false;
            txtNomeResponsavel.Text = linha_dados["NomeResponsavel"].ToString();
            txtCPFResponsavel.Text = linha_dados["CPFResponsavel"].ToString(); ;
            comboParentesco.SelectedItem = linha_dados["GrauParentesco"].ToString();
            timeDataNascimento.Value = Convert.ToDateTime(linha_dados["Nascimento"]);
            ;
            txtContatoResponsavel.Text = linha_dados["ContatoResponsavel"].ToString();
            //timeInicio.Value;


        }
        private void FormCadastramento_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (this.acao == 0)
            {
                nome_aluno = txtNomeAluno.Text;
                cpf_aluno = txtCPF.Text;
                endereco = txtEndereco.Text;
                contato_aluno = txtContatoAluno.Text;
                graduacao = comboGraduacao.SelectedItem.ToString();
                nome_responsavel = txtNomeResponsavel.Text;
                cpf_responsavel = txtCPFResponsavel.Text;
                parentesco = comboParentesco.SelectedItem.ToString();
                data_nascimento = timeDataNascimento.Value;
                contato_responsavel = txtContatoResponsavel.Text;
                inicio_karate = timeInicio.Value;
                if (radioMasculino.Checked)
                {
                    sexo = 'M';
                }
                else if (radioFeminino.Checked)
                {
                    sexo = 'F';
                }
                Administracao administracao = new Administracao();
                lblTeste.Text = administracao.InserindoDados(nome_aluno, cpf_aluno, endereco, contato_aluno, contato_responsavel, graduacao, nome_responsavel, cpf_responsavel, parentesco, data_nascimento, inicio_karate, sexo);
                if (lblTeste.Text == "Dados inseridos com sucesso.")
                {
                    LimparCampos(); 
                }
            }
            else
            {
                
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            txtNomeAluno.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtContatoAluno.Clear();
            comboGraduacao.Text = "";
            txtNomeResponsavel.Clear();
            txtCPFResponsavel.Clear();
            comboParentesco.Text = "";
            timeDataNascimento.Text = "";
            txtContatoResponsavel.Clear();
            timeInicio.Text = "";
            radioMasculino.Checked = false;
            radioFeminino.Checked = false;
        }
    }
}
    