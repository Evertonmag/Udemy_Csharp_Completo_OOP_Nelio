using System;
using System.Globalization;

namespace Exemplo;
internal class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto("TV", 500.00, 10 );

        p.Nome = "TV 4K";

        


        #region Construtores / sobrecargas
        /*
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            //Produto p1 = new Produto(nome, preco);
            //Produto p2 = new Produto();

            //Produto p3 = new Produto()
            //{
            //    Nome = nome,
            //    Preco = preco,
            //    Quantidade = quantidade
            //};

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o número deprodutos a ser ADICIONADA ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine("\nDados Atualizados : " + p);

            Console.Write("\nDigite o número deprodutos a ser REMOVIDA do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("\nDados Atualizados : " + p);
        */
        #endregion
    }
}
