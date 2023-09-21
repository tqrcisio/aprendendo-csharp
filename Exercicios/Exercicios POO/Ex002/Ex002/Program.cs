using System;
using System.Globalization;

// Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
namespace Ex002 {
    class Program {
        static void Main(string[] args) {
            Funcionario func1, func2;
            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            func1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            func2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (func1.salario + func2.salario) / 2;
            Console.WriteLine("Salário médio = " + media);
        }
    }
}