using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace consumoCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distancia, combustivel, consumo; 

            Console.WriteLine("Digite a distância percorida: ");
            distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de combustível gasto: ");
            combustivel = double.Parse(Console.ReadLine());

            consumo = distancia / combustivel;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + "km/l");
            Console.ReadLine(); 
        }
    }
}
