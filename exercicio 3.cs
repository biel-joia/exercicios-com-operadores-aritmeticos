﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da diagonal do quadrado: ");
            double diagonal = Convert.ToDouble(Console.ReadLine());

            double area = (diagonal * diagonal) / 2;

            Console.WriteLine("A área do quadrado é: ");
        }
    }
}
