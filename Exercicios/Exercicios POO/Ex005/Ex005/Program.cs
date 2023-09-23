using System;
using System.Globalization;

namespace Ex005 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Nome do aluno: ");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.A1 = double.Parse(Console.ReadLine());
            aluno.A2 = double.Parse(Console.ReadLine());
            aluno.A3 = double.Parse(Console.ReadLine());
            Console.WriteLine(aluno);
        }
    }
}