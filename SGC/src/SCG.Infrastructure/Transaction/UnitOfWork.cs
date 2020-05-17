using SCG.Infrastructure.Data;
using SCG.Infrastructure.Transaction.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCG.Infrastructure.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SgcContext _sgcContext;
        public UnitOfWork(SgcContext  sgcContext)
        {
            this._sgcContext = sgcContext;
        }
        public void Commit()
        {
            _sgcContext.SaveChanges();
        }
    }
}
