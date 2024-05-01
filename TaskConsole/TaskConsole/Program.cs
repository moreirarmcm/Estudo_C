using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task Parte 1

            // Task t1 = new Task(Tarefa);
            //t1.Start();

            //  Task t2 = Task.Run(Tarefa);

            //  Task.Run(Tarefa);

            //Task.Factory.StartNew(Tarefa);

            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Tarefa anônima " + i);
            //    }
            //});
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Principal.");
            //}
            //Console.ReadLine();
            #endregion

            #region Task Parte 2
            //Task[] tasks = 
            //    {
            //        Task.Factory.StartNew(() => {Console.WriteLine("Tarefa #1"); }),
            //        Task.Factory.StartNew(() => {Console.WriteLine("Tarefa #2");}),
            //        Task.Factory.StartNew(() => {Console.WriteLine("Tarefa #3");}),
            //        Task.Factory.StartNew(() => {Console.WriteLine("Tarefa #4");}),
            //        Task.Factory.StartNew(() => {Console.WriteLine("Tarefa #5");})
            //    };
            //Task.WaitAll(tasks);
            //Console.WriteLine("Principal");
            //Console.ReadLine();
            #endregion

            Task<int> tarefa1 = Task.Factory.StartNew(() => 
            {
                return new Random().Next(10);
            });

            Task<int> tarefa2 = tarefa1.ContinueWith((num) => { return Dobro(num.Result); });//; Dobro(tarefa1.Result) });
            Task<String> tarefa3 = tarefa2.ContinueWith((num) => {
                    return "Valor final é " + num.Result;
                });//; Dobro(tarefa1.Result) });


            Console.WriteLine(tarefa3.Result);
            Console.ReadKey();
        }

        static int Dobro(int x)
        {
            return x * 2;
        }

        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa " + i);
            }
        }

    }
}
