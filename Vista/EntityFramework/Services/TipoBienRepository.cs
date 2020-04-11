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
   public class TipoBienRepository : ITipoBienRepository
    {
        private DbSet<TipoBien> cDbSetTipoBien;

        public TipoBienRepository(BomberosContext pContext)
        {
            cDbSetTipoBien = pContext.Set<TipoBien>();
        }
    }
}
