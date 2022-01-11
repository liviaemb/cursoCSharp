using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace calculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;
            double pi = 3.14159;
            string[] vet; 

            vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            triangulo = (a * c) / 2;
            circulo = pi * c * c;
            trapezio = (a + b) * c / 2;
            quadrado = b * b;
            retangulo = a * b; 
            
            Console.WriteLine("Triângulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
