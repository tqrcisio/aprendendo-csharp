using System;
using System.Globalization;

namespace Exercicio004 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o raio do circulo: ");
            double raioCirculo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double result = 3.14159 * Math.Pow(raioCirculo, 2);
            Console.WriteLine($"A={result.ToString("F4",CultureInfo.InvariantCulture)}");
        }
    }
}