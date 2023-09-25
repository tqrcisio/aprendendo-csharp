// Um unico construtor com todos os parâmetros, isso obriga preencher todos os dados da classe para inicializar o programa.
namespace Constructor2 {
    class Produto {
        public string Nome;
        public double Preco;
        public int Estoque;

        
        public Produto(string nome, double preco, int estoque) {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
        public void RemoverProdutos(int qtde) {
            Estoque -= qtde;
        }
        public void AdicionarProdutos(int qtde) {
            Estoque += qtde;
        }
        public double ValorTotalEmEstoque() {
            return Estoque * Preco;
        }
        public override string ToString() {
            string saida = $"{Nome}, $ {Preco:F2},{ValorTotalEmEstoque()} unidades, Total: $ {ValorTotalEmEstoque():F2}";
            return saida;
        }
    }
}
