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
        String pasta = @"C:\Users\morei\Documents\GitHub\Estudo_C\ArquivosPastas\Arquivos\";
        String pasta_backup = @"C:\Users\morei\Documents\GitHub\Estudo_C\ArquivosPastas\Arquivos\Backup\";
        String pasta_lixeira = @"C:\Users\morei\Documents\GitHub\Estudo_C\ArquivosPastas\Arquivos\Lixeira\";
        String pasta_importante = @"C:\Users\morei\Documents\GitHub\Estudo_C\ArquivosPastas\Arquivos\Arquivos importantes\";

        //"C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\ArquivosPastas\\Arquivos\\";
        String arquivo = "Teste.txt";
        bool has;// = File.Exists(pasta + arquivo);

        public Form1()
        {
            InitializeComponent();

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            this.pasta = @"C:\Users\morei\Documents\GitHub\Estudo_C\ArquivosPastas\Arquivos\";
            //"C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\ArquivosPastas\\Arquivos\\";
            this.arquivo = "Teste.txt";
            this.has = File.Exists(pasta + arquivo);
            if (has)
            {
                lblResultado.Text = "Arquivo já existe.";
                //Console.ReadLine();
                //File.Delete(pasta + arquivo);
            }
            else
            {
                File.Create(pasta + arquivo).Close();
                lblResultado.Text = "Arquivo criado";
            }



        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            this.has = File.Exists(pasta + arquivo);
            if (has)
            {
                File.Copy(pasta + arquivo, pasta + arquivo + " (Cópia).txt", true);
                lblResultado.Text = "Arquivo copiado!";
            }
            else
            {
                lblResultado.Text = "Arquivo fonte não existe.";

            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            this.has = File.Exists(pasta + arquivo);
            if (has)
            {
                if (File.Exists(pasta_importante + arquivo))
                {
                    File.Delete(pasta_importante + arquivo);
                }
                File.Move(pasta + arquivo, pasta_importante + arquivo);
            }
            else
            {
                lblResultado.Text = "O Arquivo não existe para ser movido.";
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            this.has = File.Exists(pasta + arquivo);
            if (has)
            {
                File.Copy(pasta + arquivo, pasta_backup + "bkp_" + arquivo, true);
                File.Move(pasta + arquivo, pasta_lixeira + arquivo);
            }
            else
            {
                lblResultado.Text = "Não foi possível apagar o arquivo.";
            }
        }
    }
}
