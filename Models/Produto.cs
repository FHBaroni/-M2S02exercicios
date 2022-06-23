namespace GeraEstoque.Models;

public class Produto
{
    //construtor
    public Produto(string nome, int quantidadeEmEstoque, double valorCompra, double valorVenda) {}

    // propriedades


    public string id = Guid.NewGuid().ToString();
    public string nome { get; set; }
    public int quantidadeEmEstoque { get; set; }
    public double valorCompra { get; set; }
    public double valorVenda { get; set; }

   public override string ToString()
    {
        return $" Produto: Id: {id} |  Nome: {nome} | Qtd: {quantidadeEmEstoque} | R$ Compra: {valorCompra} | R$ Venda: {valorVenda}";
    }         

}