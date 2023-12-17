using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Média Geral dos Alunos";
            Console.Write("Quantos alunos deseja cadastrar?\n");
            int qtdade_alunos = 0;
            String nome_aluno;
            int notas_aluno;
            Aluno[] alunos;

            while (qtdade_alunos == 0)
            {
                try
                {
                    qtdade_alunos = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Digite um número inteiro");
                }
            }
            alunos = new Aluno[qtdade_alunos];
            for (int i = 0;i<alunos.Length;i++){
                    Console.Write("Qual o nome do aluno #" + (i+1) + "?\n");
                    try
                    {
                        nome_aluno = (Console.ReadLine());
                        Console.Write("Quantas notas o aluno " + nome_aluno + " possui?\n");
                        notas_aluno = int.Parse(Console.ReadLine());
                    alunos[i] = new Aluno(nome_aluno, notas_aluno);
                    alunos[i].InformarNotas();
                    Console.WriteLine();

                    //Console.WriteLine ("A média do '" + nome_aluno + "' é: " + alunos[i].RetornarMedia());
                }
                catch (Exception ex) {
                        Console.WriteLine("Nome ou notas inválidos. Revise os dados informados.");
                        i--;
                    }
            }
            foreach(Aluno aluno in alunos)
            {
                Console.WriteLine("A média do aluno '" + aluno.nome + "' é: " + aluno.RetornarMedia());
            }
            Console.ReadLine();

        }
    }
}
