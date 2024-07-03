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
using System.Xml.Linq;

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(@"C:\Users\morei\Documents\GitHub\Estudo_C\ArquivosPastas\Arquivos\");
            Lista.Items.Clear();
            Lista.Items.Add(file.FullName);
            Lista.Items.Add(file.Directory.FullName);
            Lista.Items.Add(file.LastAccessTime);



        }
    }
}
