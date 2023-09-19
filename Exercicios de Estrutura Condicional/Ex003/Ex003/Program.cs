using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor de A e B aqui: ");
            string[] ab = Console.ReadLine().Split(' ');
            int maior = 0, menor = 0;
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            if (a > b) {
               maior = a;
                menor = b;
            } else {
               maior = b;
               menor = a;
            }
            if (maior % menor == 0) {
                Console.WriteLine("São Multiplos");
            } else {
                Console.WriteLine("Não Multiplos");
            }
        }
    }
}