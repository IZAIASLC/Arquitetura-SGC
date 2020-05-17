using Microsoft.EntityFrameworkCore;
using SCG.ApplicationCore.Entity;
using SCG.ApplicationCore.Interfaces.Repository;
using SCG.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SCG.Infrastructure.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {


        private readonly SgcContext _dbContext;

        public EFRepository(SgcContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public virtual TEntity Adicionar(TEntity entity)
        {
             _dbContext.Set<TEntity>().Add(entity);
          
            return entity;
        }

        public virtual void Atualizar(TEntity entity)
        {
            _dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


        }

        public  IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbContext.Set<TEntity>().Where(predicado).AsEnumerable();
        }

        public virtual TEntity ObterPorId(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos(string[] includes = null)
        {
 
            var query = _dbContext.Set<TEntity>().AsQueryable();

            if (includes != null && includes.Count() > 0)
            {
                foreach (var include in includes)
                    query = query.Include(include).AsQueryable();
            }

            ////as IQueryable<DRF>



            //var result = (from cli in _dbContext.Clientes
            //              join cont in _dbContext.Contatos on cli.ClienteId equals cont.ClienteId

            //              select cli 

            //               ) as IQueryable;



            //var xxx = result.GroupBy(a => a.Nome);


            return query;
        }

        public void Remover(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
