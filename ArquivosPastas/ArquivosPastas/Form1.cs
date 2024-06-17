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

namespace ArquivosPastas
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            String pasta = @"C:\Users\morei\Documents\GitHub\Estudo_C\ArquivosPastas\Arquivos\";
            //"C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\ArquivosPastas\\Arquivos\\";
            String arquivo = "Teste.txt";
            bool has = File.Exists(pasta + arquivo);
            if (has)
            {
                lblResultado.Text = "Existe";
                //Console.ReadLine();
                File.Delete(pasta + arquivo);
            }
            else
            {
                File.Create(pasta + arquivo).Close();
                lblResultado.Text = "Arquivo criado";
            }


           
        }
    }
}
