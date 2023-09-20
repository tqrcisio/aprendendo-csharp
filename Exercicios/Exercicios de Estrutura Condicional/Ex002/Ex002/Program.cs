using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero inteiro: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}