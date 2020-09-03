using System.Globalization;

namespace PordutoEstoque
{
    class Produto
    {
        private string _nome;
        public double _preco{ get; private set; }
        public int _quantidade{ get; private set; }

        public Produto() { 
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
        
            get { return _quantidade; }
        }
   
        public double ValorTorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
                + ", $ ,"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + "unidades, Total: $"
                + ValorTorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
