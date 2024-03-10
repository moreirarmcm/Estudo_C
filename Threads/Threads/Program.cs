using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Tarefa)); 
            t.Start();

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Principal");
                Dormir();

            }
            Console.ReadKey();
           
        }

        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread");
                Dormir();
            }
        }

        static void Dormir()
        {
            Thread.Sleep(1000);
        }


    }
}
