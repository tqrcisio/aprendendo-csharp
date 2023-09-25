/* Sobrecarga de Construtores (2 Construtores): Nesse exemplo usamos dois construtores, um com apenas 1 atributo e outro com todos os atributos.
 * Nesse caso a classe Produto só pode ser instanciada com um unico atributo ou com 3 atributos. Se usarmos 2 atributos,
 * como por exemplo Nome e Preço, o sistema vai dar erro já que não criamos um construtor com 2 atributos. */
namespace Constructor2 {
    class Produto {
        public string Nome;
        public double Preco;
        public int Estoque;
        
        public Produto(string nome) {
            Nome = nome;
            Preco = 2500;
            Estoque = 5;
        }

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
