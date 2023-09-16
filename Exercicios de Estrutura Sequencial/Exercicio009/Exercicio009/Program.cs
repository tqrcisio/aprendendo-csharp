using System;
using System.Globalization;

namespace Exercicio009 {
    class Program {
        static void Main(string[] args) {
            Console.Write("1 - Digite os dados no seguinte formato: codigo;numPecas;valorUnit: ");
            string[] produto1 = Console.ReadLine().Split(';');
            Console.Write("2 - Digite os dados no seguinte formato: codigo;numPecas;valorUnit: ");
            string[] produto2 = Console.ReadLine().Split(';');
            double subTotal1 = double.Parse(produto1[2]) * double.Parse(produto1[1]);
            double subTotal2 = double.Parse(produto2[2]) * double.Parse(produto2[1]);
            double total =  subTotal1 + subTotal2;
            Console.WriteLine($"Valor a pagar: R$ {total}");
            Console.WriteLine("    Toque em qualquer tecla para fechar...");
            Console.ReadKey();
            
        }
    }
}