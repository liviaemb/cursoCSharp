using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = i * n;
                Console.WriteLine(i + " x " + n + " = " + result);
            }
            Console.ReadLine();
        }
    }
}
