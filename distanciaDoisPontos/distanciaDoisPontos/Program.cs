using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace distanciaDoisPontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distancia, p1, p2;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0]);
            y1 = double.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet[0]);
            y2 = double.Parse(vet[1]);  

            p1 = Math.Pow(x2 - x1, 2);
            p2 = Math.Pow(y2 - y1, 2);

            distancia = Math.Sqrt(p1 + p2);

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
