namespace GeraEstoque.Repositories;

using GeraEstoque.Models;

public class ProdutoRepository
{
    IList<Produto> ListaProdutos;

    public ProdutoRepository()
    {
        ListaProdutos = new List<Produto>();
    }
}




