using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteriaViciada
{
    public partial class Form1 : Form
    {

        int[] escolha = new int[6];
        string txt_escolha = "oS números escolhidos são: ";
        int id = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAposta.Text = txt_escolha;
        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 1;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }        
        }
        private void b2_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 2;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }
        }
        private void b3_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 3;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }
        }
        private void b4_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 4;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }
        }
        private void b5_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 5;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }
        }
        private void b6_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 6;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }
        }
        private void b7_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 7;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }
        }
        private void b8_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 8;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }
        }
        private void b9_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 9;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }
        }
        private void b10_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                escolha[id] = 10;
                txt_escolha += escolha[id].ToString() + ", ";
                id++;
            }
        }
    }
}
