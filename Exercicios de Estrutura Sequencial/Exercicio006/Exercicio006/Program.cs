using System;
using System.Globalization;

namespace Exercicio006 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite seu nome: ");
            string nomeCompleto = Console.ReadLine();
            Console.Write("Digite a quantidade de quartos: ");
            int numQuartos = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço do aluguel: ");
            double precoAluguel = double.Parse(Console.ReadLine());
            Console.Write("Digite seu sobrenome, idade e altura: ");
            string[] info = Console.ReadLine().Split(' ');

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(numQuartos);
            Console.WriteLine(precoAluguel);
            Console.WriteLine(info[0]);
            Console.WriteLine(info[1]);
            Console.WriteLine(info[2]);
            Console.ReadLine();
        }
    }
}