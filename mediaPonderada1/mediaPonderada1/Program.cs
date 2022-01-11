using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace mediaPonderada1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, media;

            Console.WriteLine("Digite o valor da primeira nota: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor da segunda nota: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((a * 3.5) + (b * 7.5)) / 11;

            Console.WriteLine("Media = " + media.ToString
                ("F5", CultureInfo.InvariantCulture));
            Console.ReadLine(); 


        }

    }
}
