namespace GeraEstoque.Models;

public class Produto
{

    // propriedades
    public string id { get; set; }
    public string nome { get; set; }
    public int quantidadeEmEstoque { get; set; }
    public double valorCompra { get; set; }
    public double valorVenda { get; set; }

    public Produto() { }

    public Produto(string nome, int quantidadeEmEstoque, double valorCompra, double valorVenda)
    {
        this.id = Guid.NewGuid().ToString();
        this.nome = nome;
        this.quantidadeEmEstoque = quantidadeEmEstoque;
        this.valorCompra = valorCompra;
        this.valorVenda = valorVenda;
    }

    public override string ToString()
    {
        return string.Format("Produto: Id: {0} | Nome: {1} | Qtd: {2}| R$ Compra: {3:c} | R$ Venda: {4:c}", id, nome, quantidadeEmEstoque, valorCompra, valorVenda);
    }
}