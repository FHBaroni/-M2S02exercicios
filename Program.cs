namespace GeraEstoque;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(@"Seja bem vindo ao GeraEstoque 1.0
----------------------------------------
1  Cadastrar produto
2  Consultar produto
3  Modificar produto
4  Excluir produto
0  Sair

Digite a opção: ");
    

    var option = (Console.ReadLine());   
    switch(option)
    {
        case "1": 
                CadastrarProduto ();
                break;
        default: break;
    }
    static void CadastrarProduto ()
    {
    Console.WriteLine("CadastrarProduto ok");
    }

    }
}