using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            // Fórmula da média geométrica: raiz quadrada de (valor1 * valor2)
            double mediaGeometrica = Math.Sqrt(valor1 * valor2);

            Console.WriteLine("A média geométrica é: " + mediaGeometrica);
        }
    }
}
