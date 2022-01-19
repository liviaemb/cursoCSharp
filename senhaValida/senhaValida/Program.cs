using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senhaValida
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2020)
            {
                Console.WriteLine("Senha incorreta");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Seja bem-vindo!"); 
            Console.ReadLine();

        }
    }
}