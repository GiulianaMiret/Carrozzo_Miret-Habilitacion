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
    public class PagoRepository : IPagoRepository
    {
        private DbSet<Pago> cDbSetPago;
        
        public PagoRepository(BomberosContext pContext)
        {
            cDbSetPago = pContext.Set<Pago>();
        }
    }
}
