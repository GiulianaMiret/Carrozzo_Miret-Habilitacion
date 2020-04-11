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
    public class ModificacionRepository : IModificacionRespository
    {
        private DbSet<Modificacion> cDbSetModificacion;

        public ModificacionRepository(BomberosContext pContext)
        {
            cDbSetModificacion = pContext.Set<Modificacion>();
        }
    }
}
