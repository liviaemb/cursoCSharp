using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace salarioBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vendedor;
            double salario, vendas, comissao, total;

            Console.WriteLine("Digite o nome do vendedor: ");
            vendedor = Console.ReadLine();
            Console.WriteLine("Digite o valor do salário de " + vendedor + ":");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor total das vendas de " + vendedor + ":");
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = vendas * 15 / 100;

            total = salario + comissao;

            Console.WriteLine("O valor total do salário esse mês de " + vendedor + 
                " foi de: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine(); 
        }
    }
}
