using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, horas; 
            double valorHora, salario;

            Console.WriteLine("Digite o número do funcionário: ");
            numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor recebido por hora trabalhada: ");
            valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);  

            salario = horas * valorHora;

            Console.WriteLine("O número do funcionário é: " + numero + " e o seu salário é: R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));    
            Console.ReadLine();


        }
    }
}
