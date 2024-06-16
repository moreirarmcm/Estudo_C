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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSgundo_Click(object sender, EventArgs e)
        {
            FormSegunda formSegunda = new FormSegunda("Mensagem automática");
            // formSegunda.Show();
            this.Hide();
            formSegunda.ShowDialog();
            this.Show();
        }

        private void btnSegundoThread_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => Application.Run(new FormSegunda("Mensagem automática")));
            t.Start();

        }
    }
}
