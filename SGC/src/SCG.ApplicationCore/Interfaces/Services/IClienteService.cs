using SCG.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SCG.ApplicationCore.Interfaces.Services
{
    public interface IClienteService : IServiceBase 
    {
        Cliente Adicionar(Cliente entity);
        void Atualizar(Cliente entity);
        IEnumerable<Cliente> ObterTodos(string[] includes = null);

        Cliente ObterPorId(int id);

        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);

        void Remover(Cliente entity);
    }
}
