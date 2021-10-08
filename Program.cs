using System;
using System.Globalization;

namespace OO_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); 

            System.Console.WriteLine("Entre os dados do produto:");
            System.Console.Write("Produto: ");
            p.Nome = Console.ReadLine();
            System.Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados do produto "+ p);

            System.Console.WriteLine("Digite quantos produtos serão adicionados: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionaProduto(qtd);
            System.Console.WriteLine("Dados atualizados: "+p);

            System.Console.WriteLine("Digite quantos produtos serão retirados: ");
            int qtd2 = int.Parse(Console.ReadLine());
            p.RetiraProduto(qtd2);
            System.Console.WriteLine("Dados atualizados: "+p);

        }
    }

}
