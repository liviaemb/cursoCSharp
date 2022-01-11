using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace areaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            double n = 3.14159;

            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            raio = Math.Pow(raio, 2.0); 

            area = n * raio; 

            Console.WriteLine("A área do círculo é: " + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine(); 

        }
    }
}
