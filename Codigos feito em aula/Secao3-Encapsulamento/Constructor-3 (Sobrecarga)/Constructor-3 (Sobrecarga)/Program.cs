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

            /*Código que daria erro por ter dois atributos, o sistema só aceita ser chamado com 1 ou com 3:
             * Produto p = new Produto(nome, preco); */
           
                Produto p = new Produto(nome, preco, estoque); // código correto por conter os 3 atributos.
                Console.WriteLine($"Dados do produto: " + p);
            while (true) {
                Console.Write("Nome: ");
                 nome = Console.ReadLine();
                 p = new Produto(nome); // Código correto pois chama o construtor com apenas 1 atributo. Criando um objeto apenas com o atributo nome,
                                        // os atributos preço e estoque serão iniciados com um valor padrão, sem o uso de variaveis no construtor.
                 Console.WriteLine($"Dados atualizados: " + p);
            }
        }
    }
}