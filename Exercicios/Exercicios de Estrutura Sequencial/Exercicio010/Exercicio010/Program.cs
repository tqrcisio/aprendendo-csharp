using System;
using System.Globalization;

namespace Exercicio010 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite aqui 3 valores: ");
            string[] value = Console.ReadLine().Split(' ');
            double pi = 3.14159, result, a, b, c;
            a = double.Parse(value[0], CultureInfo.InvariantCulture);
            b = double.Parse(value[1], CultureInfo.InvariantCulture);
            c = double.Parse(value[2], CultureInfo.InvariantCulture);
            // TRIÂNGULO
            result = a * c / 2.00;
            Console.WriteLine($"O resultado do calculo da área do triângulo é: {result.ToString("F3", CultureInfo.InvariantCulture)}.");
            // CIRCULO
            result = (c * c) * pi;
            Console.WriteLine($"O resultado do calculo da área do circulo é: {result.ToString("F3", CultureInfo.InvariantCulture)}.");
            // TRAPÉZIO
            result = (a + b) * c / 2.00;
            Console.WriteLine($"O resultado do calculo da área do trapézio é: {result.ToString("F3", CultureInfo.InvariantCulture)}.");
            // QUADRADO
            result = b * b;
            Console.WriteLine($"O resultado do calculo da área do quadrado é: {result.ToString("F3", CultureInfo.InvariantCulture)}.");
            // RETÂNGULO
            result = a * b;
            Console.WriteLine($"O resultado do calculo da área do quadrado é: {result.ToString("F3", CultureInfo.InvariantCulture)}.");
        }
    }
}