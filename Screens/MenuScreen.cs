namespace GeraEstoque.Screens;


public static class MenuScreen
{
	public static void Iniciar ()
{
		 static void Menu()
    {

        Console.Write(@"
 Seja bem vindo ao GeraEstoque 1.0
 ----------------------------------------
 1  Cadastrar produto
 2  Consultar produto
 3  Modificar produto
 4  Excluir produto
 0  Sair

        Digite a opção: ");

        var option = (Console.ReadLine());
        switch (option)
        {
            case "1":
                CadastrarProduto();
                break;
            case "2":
                Menu();
                break;
            case "3":
                Menu();
                break;
            case "4":
                Menu();
                break;
            case "0":
                System.Console.WriteLine("Fim da execução"); ;
                break;
            default: break;
        }
    }
    static void CadastrarProduto()
    {
        var id = Guid.NewGuid();
        Console.WriteLine(" Digite o nome do produto");
        string nome = Console.ReadLine();
        Console.WriteLine(" Digite a quantidade em estoque");
        int quantidade = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(" Digite o valor de compra");
        decimal valorCompra = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(" Digite o valor de venda");
        decimal valorVenda = Convert.ToDecimal                         (Console.ReadLine());
        Console.WriteLine($@"
  
 Produto cadastrado com sucesso!

 Nome: Produto {nome}
 Qtd: {quantidade}
 R$ Compra: R$ {valorCompra}
 R$ Venda:  R$ {valorVenda}
 ID: {id};

 Pressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Menu();

    }
}
}
