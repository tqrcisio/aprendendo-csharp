using MembrosEstaticos_3;
using System;
using System.Globalization;

namespace MembrosEstaticos3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);
            double pi = Calculadora.pi;
            Console.WriteLine("Circunferencia = " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi = " + pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}