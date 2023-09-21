using Ex004;
using System;
using System.Globalization;

namespace Exercicio003 {
    class Ex004 {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do funcionario: ");
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario: " + f);
        }
    }
}