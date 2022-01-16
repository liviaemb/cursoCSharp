using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite valores para A e B: ");

            string [] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores [0]);
            int b = int.Parse(valores [1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São múltiplos!");
            }
            else
            {
                Console.WriteLine("Não são múltiplos!");
            }

            Console.ReadLine();



        }
    }
}
