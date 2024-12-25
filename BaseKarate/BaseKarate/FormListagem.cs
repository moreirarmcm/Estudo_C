using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BaseKarate
{
    public partial class FormListagem : Form
    {
        private Administracao administracao = new Administracao();
        private DataTable tabela_dados;
        public FormListagem()
        {
            InitializeComponent();
            tabela_dados = administracao.ListandoDados(false, null);
            foreach (DataRow dt in tabela_dados.Rows)
            {
                dataLista.Rows.Add(dt.ItemArray);
            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaDados(bool alunoEspecifico, string consulta)
        {
            if (alunoEspecifico == true)
            {
                dataLista.Rows.Clear();
                try
                {
                    DataTable tabela_dados = administracao.ListandoDados(alunoEspecifico, consulta);
                    // dataLista2.DataSource = tabela_dados;
                    foreach (DataRow dt in tabela_dados.Rows)
                    {
                        dataLista.Rows.Add(dt.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text == "" || txtConsulta.Text == null)
            {
                ListaDados(false, null);
            }
            else
            {
                ListaDados(true, txtConsulta.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int codigo_aluno = (int)dataLista.SelectedRows[0].Cells[0].Value;
            FormCadastramento formCadastramento = new FormCadastramento(codigo_aluno);
            formCadastramento.ShowDialog();
        }
    }
}
