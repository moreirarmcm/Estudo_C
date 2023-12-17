using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Aluno
    {
        public String nome { get; private set; }
        public double[] notas;

        public Aluno(string nome, int provas)
        {
            this.nome = nome;
            notas = new double[provas];
        }
        public void InformarNotas()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite o valor da nota " + (i + 1) + ": ");
                try
                {
                    this.notas[i] = Double.Parse(Console.ReadLine());
                    //Console.Write(notas[i]);
                }catch (Exception ex) {
                    Console.WriteLine("Digite uma nota válida!");
                    i--;
                }
            }
        }

        public double RetornarMedia() {
            double media = 0;
            for (int i = 0; i < notas.Length; i++)  {
                    media = media + notas[i];
                }
        
            return media/notas.Length;
        }

    }
}
