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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin form_login = new FormLogin();
            while (CadastroUsuarios.usuarioLogado == null)
            {
                this.Visible = false;
                form_login.ShowDialog();
                if (FormLogin.cancelar == true)
                {
                    Application.Exit();
                    return; //Para finalizar o laço
                }
            }
            label_boasVindas.Text = "Bem vindo (a) \n" + CadastroUsuarios.usuarioLogado.Nome.ToString();
            this.Visible = true;
            //this.Close();

            //form_login.Show();
            //form_login.ShowDialog();
        }
    }
}
