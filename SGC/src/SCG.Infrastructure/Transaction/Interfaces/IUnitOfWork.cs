using System;
using System.Collections.Generic;
using System.Text;

namespace SCG.Infrastructure.Transaction.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
