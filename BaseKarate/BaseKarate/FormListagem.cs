using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        Administracao administracao = new Administracao();
        public FormListagem()
        {
            InitializeComponent();
            // ListaDados();
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaDados()
        {
          
            /*try
            {
                DataTable tabela_dados = administracao.ListandoDados();
                lblTeste.Text = "Entrou no foreach para adicionar no edittext.";
                // dataLista2.DataSource = tabela_dados;
                foreach (DataRow dt in tabela_dados.Rows)
                {
                    dataLista2.Rows.Add(dt.ItemArray);
                }
                }
            catch (Exception ex)
            {
               lblTeste.Text = " - " + ex.Message;
            }*/
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            ListaDados();
        }
    }
}
