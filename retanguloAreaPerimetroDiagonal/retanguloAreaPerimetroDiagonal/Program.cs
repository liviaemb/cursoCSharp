using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace retanguloAreaPerimetroDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a,b,area, perimetro, diagonal;

            Console.WriteLine("Digite a altura do retângulo: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a base do retângulo: ");
            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);      

            area = a * b;
            perimetro = 2 * b + 2 * a;
            diagonal =  Math.Sqrt(Math.Pow (b, 2.0) + Math.Pow (a, 2.0));

            Console.WriteLine("A área  do retângulo é: " + area.ToString ("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("O perímetro do retângulo é: " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A diagonal do retângulo é: " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
