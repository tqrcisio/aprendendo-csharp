using Constructor2;
using System;
using System.Globalization;

/* Programa de produtos com o uso de um unico construtor, que por si só já obriga
  o preenchimento dos atributos da classe para a mesma ser inicializada.*/
 
namespace ProdutoEntradaSaida {
    class Pdv {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do produto ");
            

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, estoque);
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