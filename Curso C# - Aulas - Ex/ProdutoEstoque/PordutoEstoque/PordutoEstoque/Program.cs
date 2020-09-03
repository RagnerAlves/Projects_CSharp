using System;

namespace PordutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.WriteLine("Digite o nome do produto: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade do produto em estoque é: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado em estoque: ");
            int qnte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qnte);
            Console.WriteLine("Dados Atualizados:" + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser removidos do estoque: ");
            qnte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qnte);
            Console.WriteLine("Dados Atualizados:" + p);

        }
    }
}
