using System;
using System.Globalization;

namespace Exercicio006 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite aqui o código do funcionário: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite aqui as horas trabalhadas do funcionário: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Digite aqui o preço da hora do funcionário: ");
            double precoHora = double.Parse(Console.ReadLine());
            double salario = precoHora * horasTrabalhadas;
             
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Salário: R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}