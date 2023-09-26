using Exerc7;
using System;
using System.Globalization;

namespace Ex7 {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Deseja iniciar a conta com um saldo inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'n') {
                if (resp == 's') {
                    Console.Write("Entre com o saldo inicial da conta: ");
                    double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta = new ContaBancaria(numConta, nomeTitular, saldoInicial);
                    Console.WriteLine(conta);
                } else {
                    conta = new ContaBancaria(numConta, nomeTitular);
                    Console.WriteLine(conta);
                }
                Console.Write("Entre com o valor do depósito: ");
                conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(conta);
                Console.WriteLine("");
                Console.Write("Entre com o valor do saque: ");
                conta.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(conta);
            }
        }
    }
}