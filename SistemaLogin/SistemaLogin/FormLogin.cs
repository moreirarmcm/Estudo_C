using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;
            Close();

        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            if (CadastroUsuarios.Login (txtUsuario.Text, txtSenha.Text))
            {
                this.Close();
            }
            else
            {
                //txtSenha.Clear();
                txtSenha.Text = "";
                txtSenha.Focus();
                MessageBox.Show("Acesso negado!");
                Close();
            }
        }
    }
}
