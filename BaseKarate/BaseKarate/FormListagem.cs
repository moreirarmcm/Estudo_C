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
            ListaDados();
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaDados()
        {
           
            DataTable tabela_dados = new DataTable();
            //tabela_dados = administracao.ListandoDados();
            try
            {
                tabela_dados = administracao.ListandoDados();
                foreach (DataRow td in tabela_dados.Rows)
                {
                    dataLista.Rows.Add(td.ItemArray);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
