using System;
using System.Globalization;

namespace ProdutoEntradaSaida {
     class Produto {
        public string nome;
        public double preco;
        public int estoque;

        public void RemoverProdutos(int qtde) {
            estoque -= qtde;
        }
        public void AdicionarProdutos(int qtde) {
            estoque += qtde;
        }
        public double ValorTotalEmEstoque() {
            return estoque * preco;
        }
        public override string ToString() {
            string saida = $"{nome}, $ {preco:F2},{ValorTotalEmEstoque()} unidades, Total: $ {ValorTotalEmEstoque():F2}";
            return saida;
        }
    }
}
