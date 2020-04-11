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
    public class RubroRepository : IRubroRepository
    {
        private DbSet<Rubro> cDbSetRubro;

        public RubroRepository(BomberosContext pContext)
        {
            cDbSetRubro = pContext.Set<Rubro>();
        }
    }
}
