using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, media;

            Console.WriteLine("Digite o valor da primeira nota: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor da segunda nota: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor da terceira nota: ");
            c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = ((a * 2) + (b * 3) + (c*5)) / 10;

            Console.WriteLine("Media = " + media.ToString
                ("F1", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
