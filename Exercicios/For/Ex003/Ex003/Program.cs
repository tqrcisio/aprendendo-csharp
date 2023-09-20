using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número de casos de teste: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.Write($"Digite 3 valores decimais para o calculo da média ({i+1}): ");
                string[] strings = Console.ReadLine().Split(' ');
                double a = double.Parse(strings[0], CultureInfo.InvariantCulture);
                double b = double.Parse(strings[1], CultureInfo.InvariantCulture);
                double c = double.Parse(strings[2], CultureInfo.InvariantCulture);

                double p1 = 2.0, p2 = 3.0, p3 = 5.0;
                double mediaPonderada = (p1 * a + p2 * b + p3 * c) / (p1 + p2 + p3);
                Console.WriteLine("Média Ponderada: " + mediaPonderada.ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
