using Ex003;
using System;
using System.Globalization;

namespace Exercicio003 {
    class Ex003 {
        static void Main(string[] args) {
            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            Retangulo r = new Retangulo();
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("ÁREA = " + r.Area(), CultureInfo.InvariantCulture);
            Console.WriteLine("PERIMETRO = " + r.Perimetro(), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL = " + r.Diagonal(),CultureInfo.InvariantCulture);
        }
    }
}