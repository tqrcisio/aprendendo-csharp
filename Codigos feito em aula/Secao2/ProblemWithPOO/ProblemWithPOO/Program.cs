using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor de X: ");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de X: ");
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de X: ");
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de Y: ");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de Y: ");
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de Y: ");
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            Console.WriteLine($"Área de X = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
            if (areaX > areaY) {
                Console.WriteLine("Maior área = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("Maior área = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
        }
    }
}