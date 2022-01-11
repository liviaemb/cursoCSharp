using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, soma;

            Console.WriteLine("Digite o primeiro número: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = double.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("Aqui está o resultado: " + soma);
            Console.ReadLine();  

        }
    }
}
