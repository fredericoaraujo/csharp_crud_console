using System;
using System.ComponentModel.Design;
using DTO;
using Entity;
using Service;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        int opcao = 0;
        Program programa = new Program();
        while(opcao != 5)
        {
            programa.Menu();
            string? opcaoChar = Console.ReadLine();
            if (int.TryParse(opcaoChar, out int opcaoConvertida))
            {
                opcao = opcaoConvertida;
            }
        }*/

        ClienteService service = new ClienteService();
        ClienteEntradaCadastroDTO cadastro = new ClienteEntradaCadastroDTO();
        cadastro.Nome = "Fred Araujo";
        cadastro.DataNascimento = DateOnly.Parse("01/05/1983");
        cadastro.Desconto = decimal.Parse("10");
        service.Salvar(cadastro);

        cadastro = new ClienteEntradaCadastroDTO();
        cadastro.Nome = "Frederico Augusto";
        cadastro.DataNascimento = DateOnly.Parse("01/05/1983");
        cadastro.Desconto = decimal.Parse("10");
        service.Salvar(cadastro);

        cadastro = new ClienteEntradaCadastroDTO();
        cadastro.Nome = "Charlotte";
        cadastro.DataNascimento = DateOnly.Parse("16/11/2020");
        cadastro.Desconto = decimal.Parse("5");
        service.Salvar(cadastro);
        
        Console.WriteLine(service.ListarTodos().Count());

        Console.WriteLine("X-----------------------X C O N S U L T A  P O R  N O M E X-------------------------X");
        List<Cliente> lista = service.ProcurarPorNome("Fred");
        foreach(Cliente cliente in lista)
        {
            Console.WriteLine(cliente);
        }

        Console.WriteLine("X-----------------------X C O N S U L T A  P O R  I D X-------------------------X");
        Cliente charlotte = service.ProcurarPorId(3);
        Console.WriteLine(charlotte);

        Console.WriteLine("X-----------------------X A L T E R A R  D A D O S X-------------------------X");
        ClienteEntradaAlteracaoDTO alterado = new ClienteEntradaAlteracaoDTO();
        alterado.Nome = "Charlotte MPP Araujo";
        alterado.DataNascimento = DateOnly.Parse("16/11/2020");
        alterado.Desconto = decimal.Parse("5");
        service.Alterar(3, alterado);
        charlotte = service.ProcurarPorId(3);
        Console.WriteLine(charlotte);

        Console.WriteLine("X-----------------------X EXCLUIR ID 1 X-------------------------X");
        service.Excluir(1);

        Console.WriteLine("X-----------------------X LISTAR TODOS X-------------------------X");
        foreach(Cliente cliente in service.ListarTodos())
        {
            Console.WriteLine(cliente);
        }
        
    }

    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("C A D A S T R O  D E  C L I E N T E S");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("1 - Incluir Cliente");
        Console.WriteLine("2 - Listar Clientes");
        Console.WriteLine("3 - Editar Cliente");
        Console.WriteLine("4 - Excluir Cliente");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------------------------------");
        Console.Write("Opção: ");

    }
}