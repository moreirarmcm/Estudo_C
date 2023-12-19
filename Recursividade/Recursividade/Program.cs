using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estudo 1
            Recursiva recursiva = new Recursiva();
            //recursiva.Executar("Olá mundo!", 5);
            recursiva.ExecutarRecursivo("Olá mundo!", 5);
            Console.ReadLine();
            */

        }

        static int Fatorial(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            return n * Fatorial(n - 1);
         }
    }
}
