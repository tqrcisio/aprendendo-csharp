using System;
using System.Globalization;

namespace Exercicio007 {
    class Program {
        static void Main(string[] args) {
            int a, b, c, d, diff;
            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de D: ");
            d = int.Parse(Console.ReadLine());

            diff = (a * b - c * d);
            Console.WriteLine(diff);
        }
    }
}