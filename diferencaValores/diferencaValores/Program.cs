using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace diferencaValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            Console.WriteLine("Digite o valor A: ");
            a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor B: ");
            b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor C: ");
            c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor D: ");
            d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            diferenca = (a * b - c * d);

            Console.WriteLine("A diferença dos valores é: " + diferenca);
            Console.ReadLine(); 

        }
    }
}
