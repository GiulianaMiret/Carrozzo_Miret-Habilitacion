using EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;

namespace Vista.EntityFramework.Services
{
    public interface ISocioRepository : IRepository<Socio>
    {
        int getMaxNroSocio();
    }
}
