using System;

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
            return estoque;
        }
    }
}
