using System;
using System.Globalization;

namespace Ex006 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double dolarParaReal = ConversorDeMoeda.DolarParaReal(cot, dol);
            Console.WriteLine("Valor a ser pago em reais = " + dolarParaReal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}