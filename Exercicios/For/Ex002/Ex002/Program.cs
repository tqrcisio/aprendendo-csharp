using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor de n:");
            int n = int.Parse(Console.ReadLine());
            int somaA = 0; 
            int somaB = 0;
            for (int i = 0; i < n; i++) {
                Console.Write("Digite um número inteiro: ");
                int num = int.Parse(Console.ReadLine());
                if(num >= 10 && num <= 20) {
                    somaA++;
                } else {
                    somaB++;
                }
            }
            Console.WriteLine(somaA + " in");
            Console.WriteLine(somaB + " out");
        }
    }
}
