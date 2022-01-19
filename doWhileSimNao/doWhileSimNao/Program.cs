using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace doWhileSimNao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine());
                F = 9.0 * C / 5.0 + 32;
                Console.WriteLine("Equivalente a Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n?)");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');

            Console.ReadLine(); 

        }
    }
}
