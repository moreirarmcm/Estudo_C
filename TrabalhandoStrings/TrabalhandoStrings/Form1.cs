using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoStrings
{
    public partial class Form1 : Form
    
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            decimal valor = 19.87m;
            int temp = 27;
            String s = String.Format("O valor do produto é {0} e a temperatura é {1}", valor, temp);
            s = String.Format("O valor do produto é {0:N3} (com 3 decimais) e a temperatura é {1}", valor, temp);
            s = String.Format("O valor do produto é {0:C2} (em formato de moeda) e a temperatura é {1}", valor, temp);
            String h = String.Format("Hoje é {0:d} (isso é o dia atual) e são {0:t} ( isso é a hora)", DateTime.Now);
            h = String.Format("Hoje é {0:D} (outro formato) e são {0:T} (outro formato)", DateTime.Now);
            String g = $"Hoje é {DateTime.Now:D} (outro formato) e são {DateTime.Now:T} (outro formato)";


            lblTexto.Text = g;
        }
    }
}
