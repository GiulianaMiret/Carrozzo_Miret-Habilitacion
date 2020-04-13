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
    public class PersonaRepository : IPersonaRepository
    {
        private DbSet<Persona> cDbSetPersona;

        public PersonaRepository(BomberosContext pContext)
        {
            cDbSetPersona = pContext.Set<Persona>();
        }
    }
}
