namespace GeraEstoque.Models;

public class Produto
{
    //construtor
    public Produto(){}

    // propriedades


    public string id = Guid.NewGuid().ToString();
    public string nome { get; set; }
    public string quantidade { get; set; }
    public int custo { get; set; }
    public int venda { get; set; }

    public override string ToString() => $" Produto: Id: {id} |  Nome: {nome} | Qtd: {quantidade} | R$ Compra: {custo} | R$ Venda: {venda}";


    

}