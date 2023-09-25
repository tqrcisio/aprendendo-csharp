using System.Globalization;
    
namespace Propiedades {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto() {
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string Nome { // Propiedade com get e set do nome, para mudar o atributo como se fosse uma variavel, mas podendo colocar lógica
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) { // lógica condicional no atributo set, para o atributo nome só aceitar valores que não são nulos e maiores que 1
                    _nome = value;
                }
            }
        }
        public double Preco { // Propiedade get para retornar preço
            get { return _preco; }
        }
        public int Quantidade { // Propiedade get para retornar quantidade
            get { return _quantidade; }
        }
        public double ValorTotalEmEstoque { // Propiedade get para retornar o valor total em estoque.
            get { return _preco * _quantidade; }
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}