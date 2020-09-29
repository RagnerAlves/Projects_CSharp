using System;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {           

            Console.WriteLine("Entre com os dados do produto: ");

            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o pre�o do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Produto2 p = new Produto2(nome, preco);

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
