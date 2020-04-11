using EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;

namespace Vista.EntityFramework.Services
{
    public class TransaccionRepository : ITransaccionRepository
    {
        private DbSet<Transaccion> cDbSetTransaccion;

        public TransaccionRepository(BomberosContext pContext)
        {
            cDbSetTransaccion = pContext.Set<Transaccion>();
        }
    }
}
