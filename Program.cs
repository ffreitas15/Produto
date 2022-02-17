using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            System.Console.WriteLine("Entre com os dados do produto");
            System.Console.WriteLine("nome: ");

            p.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite o Preço:  ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque:  ");
            p.Quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("dados do protudo" + p);

            System.Console.WriteLine("digete o numero para ser colocado em estoque :");
            int qte = int.Parse(Console.ReadLine());
            p.adicionarProdutos(qte);
            System.Console.WriteLine("Daddos atualizados");


            System.Console.WriteLine("digete o numero para ser removido em estoque :");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            System.Console.WriteLine("Daddos atualizados" + p);
        }
    }
}
