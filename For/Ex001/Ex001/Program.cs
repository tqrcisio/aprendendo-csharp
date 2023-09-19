using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor de x:");
            int x = int.Parse(Console.ReadLine());
            for (int i = x; i > 0; i--) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}