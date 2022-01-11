using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, PROD;

            Console.WriteLine("Digite o valor 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            b = int.Parse(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine("PROD= " + PROD);
            Console.ReadLine();


        }
    }
}
