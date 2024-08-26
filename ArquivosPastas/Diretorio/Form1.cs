using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExiste_Click(object sender, EventArgs e)
        {
            string caminho = @"C:\Users\morei\Documents\GitHub\Estudo_C\ArquivosPastas\";
            bool res = Directory.Exists(caminho + @"\Arquivos");
            Lista.Items.Add(res);
            if (!res)
            {
                Directory.CreateDirectory(caminho + "Arquivos");
            }
            else
            {
                Directory.Delete(caminho + "Arquivos");
            }

        }
    }
}
