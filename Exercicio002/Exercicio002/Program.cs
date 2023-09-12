using System;

namespace Exercicio002 {
    class Program {
        static void Main(string[] args) {
            // ENTRADA DE DADOS
            Console.Write("Digite aqui seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite aqui sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite aqui seu endereço completo, no formato: 'Rua,Cidade,Estado'");
            // EXEMPLO DE ENTRADA DE DADOS COM SPLIT.
            string[] enderecoCompleto = Console.ReadLine().Split(','); ;
            string ruaFormatada = enderecoCompleto[0];
            string cidadeFormatada = enderecoCompleto[1];
            string estadoFormatado = enderecoCompleto[2];
            // SAÍDA DE DADOS
            Console.WriteLine($"Bem-vindo, {nome}.");
            Console.WriteLine($"O ano que você nasceu foi: {2023 - idade}, então você tem {idade} anos.");
            Console.WriteLine($"Você mora na rua {ruaFormatada}, na cidade {cidadeFormatada}, no estado {estadoFormatado}");

        }
    }
}