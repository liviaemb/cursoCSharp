using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace calculoEsfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume, raio, pi = 3.14159;

            Console.WriteLine("Digite o raio da esfera");
            raio =double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            volume = (4 / 3.0) * pi * (raio * raio * raio); 

            Console.WriteLine("O Volume da esfera é: " + volume.ToString("F3", CultureInfo.InvariantCulture));  
            Console.ReadLine();


        }
    }
}
