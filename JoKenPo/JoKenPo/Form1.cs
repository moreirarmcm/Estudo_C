using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartJogo(0);

        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartJogo(1);

        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartJogo(2);

        }

        private void StartJogo(int opcao)
        {
            lblResultado.Visible = false;
            Jogo jogo = new Jogo();
            switch (jogo.Jogar(opcao))
            {
                case Jogo.resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("Ganhar.png");
                    goto default;
                case Jogo.resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("Empatar.png");
                      goto default;
                case Jogo.resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("Perder.png");
                      goto default;
                default:
                    picVoce.Image = jogo.img_jogador;
                    picMaquina.Image = jogo.img_maquina;
                    break;
            }
            
        }
    }
}
