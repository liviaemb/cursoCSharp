using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forNumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;

            Console.WriteLine("Digite um número: ");
            X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }

            Console.ReadLine();
        }
    }
}
