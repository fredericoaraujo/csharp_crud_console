using System.Collections.Generic;
using Entity;

namespace Repository;
public class ClienteRepository : IClienteRepository
{
    List<Cliente> clientes = new List<Cliente>();
    public void Alterar(Cliente cliente)
    {
        clientes.Remove(ProcurarPorId(cliente.Id));
        clientes.Add(cliente);
    }

    public void Excluir(Cliente cliente)
    {
        clientes.Remove(cliente);
    }

    public List<Cliente> ListarTodos()
    {
        if (clientes.Count == 0)
        {
            throw new Exception();
        }
        return clientes.OrderBy(p => p.Id).ToList();
    }

    public Cliente ProcurarPorId(int id)
    {
        return clientes.Where(p => p.Id == id).First();
    }

    public List<Cliente> ProcurarPorNome(string nome)
    {
        return clientes.Where(p => p.Nome.Contains(nome)).ToList();
    }

    public void Salvar(Cliente cliente)
    {
        clientes.Add(cliente);
    }
}
