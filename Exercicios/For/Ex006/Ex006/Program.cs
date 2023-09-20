using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--) {
                int calc = n / i;
                if (n % i == 0) {
                    Console.WriteLine(calc);
                }
            }
        }
    }
}
