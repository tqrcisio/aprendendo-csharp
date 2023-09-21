using System;
using System.Globalization;

/*
Fazer um programa para ler os dados de um produto em estoque (nome, preço e
quantidade no estoque). Em seguida:
• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
estoque)
• Realizar uma entrada no estoque e mostrar novamente os dados do produto
• Realizar uma saída no estoque e mostrar novamente os dados do produto
*/

namespace ProdutoEntradaSaida {
    class Pdv {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do produto ");
            Produto p = new Produto();

            Console.Write("Nome: ");
            p.nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.estoque = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: " + p);

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: " + p);

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: " + p);
        }
    }
}