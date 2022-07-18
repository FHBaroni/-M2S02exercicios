using GeraEstoque.Models;
using GeraEstoque.Repositories;

namespace GeraEstoque.Screens;

public static class CriarProdutoScreen
{
    public static void Iniciar(ProdutoRepository repository)
    {

        string id = Guid.NewGuid().ToString();
        Console.WriteLine(" Digite o nome do produto");
        string nome = Console.ReadLine();
        Console.WriteLine(" Digite a quantidade em estoque");
        int quantidade = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(" Digite o valor de compra");
        double valorCompra = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" Digite o valor de venda");
        var valorVenda = Convert.ToDouble(Console.ReadLine());

        var produto = new Produto(nome, quantidade, valorCompra, valorVenda);
        repository.Produtos.Add(produto);
        Console.WriteLine($" Produto cadastrado com sucesso! Pressione qualquer tecla para voltar ao menu principal");

        Console.ReadKey();
        MenuScreen.Iniciar(repository);
    }
}

