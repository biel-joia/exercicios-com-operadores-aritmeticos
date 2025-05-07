using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da base do triângulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = (baseTriangulo * altura) / 2;

            Console.WriteLine("A área do triângulo é: ");
        }
    }
}
