using System;

namespace Exercicio003 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int result = n1 + n2;
            Console.WriteLine(string.Format("O resultado da soma dos números é: {0}", result));
        }
    }
}