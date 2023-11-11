using System.Collections.Generic;
using Entity;

namespace Repository;
public interface IClienteRepository
{
    void Salvar(Cliente cliente);
    Cliente ProcurarPorId(int id);

    List<Cliente> ProcurarPorNome(string nome);

    List<Cliente> ListarTodos();

    void Alterar(Cliente cliente);
    void Excluir(Cliente id);

}
