using System;

namespace produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto cadProduto = new Produto();
            Console.WriteLine("Digite o código do produto");
            cadProduto.codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a descrição do produto: ");
            cadProduto.descricao = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            cadProduto.preco = Convert.ToDouble(Console.ReadLine());
            

            Produto cadProduto2 = new Produto();
            Console.WriteLine("Digite o código do produto: ");
            cadProduto2.codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a descricao do produto: ");
            cadProduto2.descricao = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: ");
            cadProduto2.preco = Convert.ToDouble(Console.ReadLine());
            cadProduto.Mostrar();
            cadProduto2.Mostrar();

            double valorTotal = cadProduto.preco + cadProduto2.preco;
            
            Console.WriteLine("Valor total dos produtos R$ "+valorTotal);
            Console.ReadKey();
        }
    }
}
