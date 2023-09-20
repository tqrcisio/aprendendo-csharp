using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                int calc2 = i * i;
                int calc3 = i * i * i;
                Console.WriteLine($"{i} {calc2} {calc3}");
            }
        }
    }
}
