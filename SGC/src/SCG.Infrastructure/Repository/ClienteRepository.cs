using SCG.ApplicationCore.Entity;
using SCG.ApplicationCore.Interfaces.Repository;
using SCG.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCG.Infrastructure.Repository
{
   public class ClienteRepository:EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(SgcContext sgcContext):base(sgcContext)
        {
                
        }
    }
}
