using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio do círculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * raio * raio;

            Console.WriteLine("A área do círculo é: " + area);
        }
    }
}
