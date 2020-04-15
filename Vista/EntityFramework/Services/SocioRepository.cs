using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;
using System.Data.Entity;
using EntityFramework;
using EntityFramework.Services;
using System.Linq.Expressions;

namespace Vista.EntityFramework.Services
{
    public class SocioRepository : ISocioRepository
    {
        private readonly BomberosContext cBomberosContext;
        private DbSet<Socio> cDbSetSocio;

        public SocioRepository(BomberosContext pContext)
        {
            cBomberosContext = pContext;
            cDbSetSocio = pContext.Set<Socio>();
        }

        public int getMaxNroSocio()
        {
            if(cDbSetSocio.Count() > 0)
            {
                return cDbSetSocio.Max(x => x.NroSocio);
            }
            return 0;
        }
    }
}
