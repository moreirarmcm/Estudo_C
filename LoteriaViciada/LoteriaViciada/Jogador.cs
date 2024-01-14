using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaViciada
{
    internal class Jogador
    {
        private int codigo { get; }
        public String nome { get; set; }
        public int[] aposta { get; }

        public Jogador(string _nome, int[] _aposta)
        {
           // this.codigo = _codigo;
            this.nome = _nome;
            for (int i = 0; i < _aposta.Length; i++)
            {
                this.aposta[i] = _aposta[i];
            }
        }
    }
}