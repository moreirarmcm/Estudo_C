using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulandoStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string texto = "Este tipo de variável é alfanumérico.";
            if (texto.Contains("tipo"))
            {
                lbl_string.Text = texto;
            }
            else
            {
                lbl_string.Text = "Não é alfanumérico";
            }
        }
    }
}
