namespace GeraEstoque.Screens;
using GeraEstoque.Repositories;

public static class MenuScreen
{
	public static void Iniciar (ProdutoRepository repository)
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
                CriarProdutoScreen.Iniciar(repository);Iniciar(repository);
            //Iniciar();
                break;
           case "0":
                System.Console.WriteLine("Fim da execução"); 
                break;
           
        }
    
   }
}
