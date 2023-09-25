using System.Globalization;

namespace Propiedades {
    class Produto {
        private string _nome;
        public double Preco { get; private set; } // Auto propierty, quando deixamos o set como private, impossibilitamos de atribuir um novo valor a ele, ao contrário do get que nesse caso está permitido.
        public double Quantidade { get; set; } // nesse caso eu posso fazer o get e o set livremente fora dessa classe, já que também é uma variavel public
        public Produto() {
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque {
            get { return Preco * Quantidade; }
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}