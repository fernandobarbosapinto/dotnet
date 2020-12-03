using System;
using System.Globalization;
namespace CourseExempleObjectToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Cadastrar produto:");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a serem adicionados ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Atualização nos dados! Foi adicionado mais {quantidade} produtos: {p}");

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a serem removidos do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Atualização nos dados! Foi removido mais {quantidade} produtos: {p}");
        }
    }
}
