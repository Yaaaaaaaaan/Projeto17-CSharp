using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma(2, 3);
            int s2 = Calculadora.Soma(3, 4, 5, 7);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadLine();
        }
    }
}
