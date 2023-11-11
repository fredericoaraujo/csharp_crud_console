using DTO;
using Entity;
using Repository;

namespace Service;
public class ClienteService
{
    IClienteRepository repository = new ClienteRepository();

    public bool Alterar(int id, ClienteEntradaAlteracaoDTO clienteEntradaAlteracaoDTO)
    {
        bool resultado = false;
        Cliente cliente = ProcurarPorId(id);
        if (cliente != null)
        {
            cliente.Nome = clienteEntradaAlteracaoDTO.Nome;
            cliente.Desconto = clienteEntradaAlteracaoDTO.Desconto;
            cliente.DataNascimento = clienteEntradaAlteracaoDTO.DataNascimento;
            cliente.Nome = cliente.Nome;
            cliente.AlteradoEm = DateTime.Now.AddSeconds(10);
            repository.Alterar(cliente);
            resultado = true;
        }
        return resultado;
    }

    public bool Excluir(int id)
    {
        bool resultado = false;
        Cliente cliente = ProcurarPorId(id);
        if (cliente != null)
        {
            repository.Excluir(cliente);
            resultado = true;
        }
        return resultado;
    }

    public List<Cliente> ListarTodos()
    {
        return repository.ListarTodos();
    }

    public Cliente ProcurarPorId(int id)
    {
        return repository.ProcurarPorId(id);
    }

    public List<Cliente> ProcurarPorNome(string nome)
    {
        return repository.ProcurarPorNome(nome);
    }

    public void Salvar(ClienteEntradaCadastroDTO clienteEntradaCadastroDTO)
    {
        int maxId = 0;
        try
        {
            Cliente clienteEncontrado = ListarTodos().Last();
            maxId = clienteEncontrado.Id;
        }
        catch { }

        maxId++;
        Cliente cliente = new Cliente();
        cliente.Id = maxId;
        cliente.Nome = clienteEntradaCadastroDTO.Nome;
        cliente.DataNascimento = clienteEntradaCadastroDTO.DataNascimento;
        cliente.Desconto = clienteEntradaCadastroDTO.Desconto;
        cliente.CadastradoEm = DateTime.Now;
        cliente.AlteradoEm = DateTime.Now;
        repository.Salvar(cliente);
    }

}
