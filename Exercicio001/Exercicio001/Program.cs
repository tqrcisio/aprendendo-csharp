using System;
using System.Globalization;

namespace Exercicio001 {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            // EXEMPLO DE SAÍDA DE DADOS COM PLACEHOLDERS, USANDO string.Format()
            string mensagem1 = string.Format("Produtos:\n{0}, cujo preço é $ {1}\n{2}, cujo preço é $ {3}", produto1, preco1, produto2, preco2);
            Console.WriteLine(mensagem1);

            // EXEMPLO DE SAÍDA DE DADOS COM CONCATENAÇÃO
            string mensagem2 = "Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero;
            Console.WriteLine(mensagem2);

            // EXEMPLO DE SAÍDA DE DADOS COM INTERPOLAÇÃO
            // Exemplo do uso do CultureInfo.InvariantCulture para imprimir a variavel medida com os numeros
            // usando a formatação '##.##' sem o uso da virgula como é o padrão da formatação 'pt-BR'
            // Usando o método ToString para formatar a string medida em 3 e 2 casas decimais
            string mensagem3 = $"Medida com oito casas decimais: {medida}," +
                $"\nArredondado (três casas decimais): {medida:F3}" +
                $"\nSeparador decimal invariant culture: {medida.ToString("F2", CultureInfo.InvariantCulture)}";
            Console.WriteLine(mensagem3);

            Console.ReadKey();
        }
    }
}