namespace GeraEstoque.Screens;


public static class CriarProdutoScreen
{
    public static void Iniciar() {

            var id = Guid.NewGuid();
            Console.WriteLine(" Digite o nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine(" Digite a quantidade em estoque");
            int quantidade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" Digite o valor de compra");
            decimal valorCompra = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" Digite o valor de venda");
            decimal valorVenda = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($@"
  
 Produto cadastrado com sucesso!

 Nome: Produto {nome}
 Qtd: {quantidade}
 R$ Compra: R$ {valorCompra}
 R$ Venda:  R$ {valorVenda}
 ID: {id};

 Pressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
        MenuScreen.Iniciar();


    }
    
	
}
