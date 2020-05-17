using prmToolkit.NotificationPattern;
using SCG.ApplicationCore.Entity;
using SCG.ApplicationCore.Interfaces.Repository;
using SCG.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SCG.ApplicationCore.Services
{
    public class ClienteService : Notifiable, IClienteService
    {

        private readonly IClienteRepository _repository;
        public ClienteService(IClienteRepository repository)
        {
            this._repository = repository;
        }
        public Cliente Adicionar(Cliente entity)
        {

            AddNotifications(entity);

            if (IsInvalid()) return null;

           return this._repository.Adicionar(entity);
        }

        public void Atualizar(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObterTodos(string[] includes = null)
        {
           return this._repository.ObterTodos(new[] {"Contato" });
        }

        public void Remover(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
