using System;

namespace Propiedades {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados iniciais: ");
            Console.Write("Nome: ");

            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qtde = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco, qtde);
            p.Quantidade = 0;
            Console.WriteLine(p.Preco);
        }
    }
}