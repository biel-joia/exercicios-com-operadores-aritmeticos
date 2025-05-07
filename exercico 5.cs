using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            double v3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            double v4 = Convert.ToDouble(Console.ReadLine());

            double media = (v1 + v2 + v3 + v4) / 4;

            Console.WriteLine("A média aritmética é: " + media);
        }
    }
}
