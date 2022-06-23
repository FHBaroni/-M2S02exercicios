namespace GeraEstoque;

using GeraEstoque.Screens;
using GeraEstoque.Repositories;

class Program
{
  static void Main()
  {
        var repository = new ProdutoRepository();
        //ProdutoRepository.ListaProdutos.add(new string() { });
    MenuScreen.Iniciar(repository);
  }
}