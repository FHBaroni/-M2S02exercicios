using GeraEstoque.Repositories;

namespace GeraEstoque.Screens;

class ListarProdutoScreen
{
    public static void Iniciar(ProdutoRepository repository)
    {
        Console.Clear();
        System.Console.WriteLine("LISTA DE PRODUTOS CADASTRADOS");
        System.Console.WriteLine("--------------------------------");
        foreach (var produto in repository.Produtos)
        {
            Console.WriteLine(produto.ToString());
            //System.Console.WriteLine($"Id: {produto.id}");
            //System.Console.WriteLine($"Nome do Produto: {produto.nome}");
            //System.Console.WriteLine($"QTD em Estoque: {produto.quantidadeEmEstoque}");
            //System.Console.WriteLine($"R$ Compra: {produto.valorCompra.ToString("c")}");
            //System.Console.WriteLine($"R$ Venda: {produto.valorVenda.ToString("c")}");
            //System.Console.WriteLine("=============================");
            //System.Console.WriteLine(produto.ToString());

            //Console.ForegroundColor = ConsoleColor.Green;

            //System.Console.WriteLine("=============================");
        }
        Console.ReadLine();
        MenuScreen.Iniciar(repository);
    }
}
//Implemente a classe** ListarProdutosScreen** criada no exercício **2**, adicionando um método** Iniciar** estático e público,
//    que recebe uma instância de ** ProdutoRepository**. Lembre-se de configurar corretamente o* namespace* e as importações.