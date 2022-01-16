using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aumentoDeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] valores = Console.ReadLine().Split(' ');
            double salario = double.Parse(valores[0]);

            double percentual;

            if (salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.00)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.00)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000.00)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            double reajuste = salario * percentual / 100.0;
            double novoSalario = salario + reajuste;

            Console.WriteLine("Novo salário: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
