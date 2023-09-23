using MembrosEstaticos_2;
using System;
using System.Globalization;

namespace MembrosEstaticos2 {
    class Program {
        static void Main(string[] args) {
            Calculadora calc = new Calculadora();
            Console.Write("Entre com o valor do raio: ");
            calc.r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Circunferência = " + calc.Circunferencia().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + calc.Volume().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi = " + calc.pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}