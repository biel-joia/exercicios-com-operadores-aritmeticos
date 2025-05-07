using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor em milhas marítimas: ");
            double milhas = Convert.ToDouble(Console.ReadLine());

            double quilometros = milhas * 1.852;

            Console.WriteLine("O valor em quilômetros é: " + quilometros);
        }
    }
}
