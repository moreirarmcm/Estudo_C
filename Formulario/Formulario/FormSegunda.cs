using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormSegunda : Form
    {
        public String mensagem { get; set; }
        public FormSegunda()
        {
            InitializeComponent();
        }

        public FormSegunda(String Mensagem)
        {
            this.mensagem = Mensagem;
            InitializeComponent();
        }
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => Application.Run(new FormMain()));
            t.Start();

        }

        private void FormSegunda_Load(object sender, EventArgs e)
        {
            txtMensagem.Text = mensagem;
        }
    }
}
