using System;
using System.Globalization;

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

            Console.WriteLine($"Dados do produto: {p.nome}, $ {p.preco:F2},{p.ValorTotalEmEstoque()} unidades, Total: $ {(p.preco * p.estoque):F2}");

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: {p.nome}, $ {p.preco:F2},{p.ValorTotalEmEstoque()} unidades, Total: $ {(p.preco * p.estoque):F2}");

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: {p.nome}, $ {p.preco:F2},{p.ValorTotalEmEstoque()} unidades, Total: $ {(p.preco * p.estoque):F2}");
        }
    }
}