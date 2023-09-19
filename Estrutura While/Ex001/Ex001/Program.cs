using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
                Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();
            while (senha != "2002") {
                Console.Write("Senha Incorreta! Digite novamente: ");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso permitido!");
        }
    }
}