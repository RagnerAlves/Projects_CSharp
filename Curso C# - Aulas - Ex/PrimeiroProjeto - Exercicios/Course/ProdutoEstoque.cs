using System.Globalization;

namespace Course
{
    internal class ProdutoEstoque
    {

        private string? _nome;
        public double Preco { get; private set; }
        private int Quantidade { get; set; }

        public ProdutoEstoque( string? nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public ProdutoEstoque(string? nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                   + ", $"
                   + Preco.ToString("F4", CultureInfo.InvariantCulture)
                   + ",  "
                   + Quantidade
                   + " "
                   + "unidades, Total: $"
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
