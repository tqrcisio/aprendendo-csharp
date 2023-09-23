using System;
using System.Globalization;

namespace MembrosEstaticos1 {
    class Program {
        static double pi = 3.14;
        static void Main(string[] args) {
           
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double vol = Volume(raio);
            Console.WriteLine("Circunferência = " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI = " + pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circunferencia(double r) {
            double calc = 2.0 * pi * r;
            return calc;
        }
        static double Volume(double r) {
            double calc = 4.0 / 3.0 * pi * r * r * r;
            return calc;
        }
    }
}